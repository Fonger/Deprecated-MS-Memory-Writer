using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Security.Cryptography;

namespace MS_MemoryWriter
{



    public partial class frmMain : Form
    {
        int MSPID = 0;
        IntPtr MShProcess = IntPtr.Zero;
        int[] AllocID = new int[1000];

        public frmMain()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void HackListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void AddAssemblyCode(string ScriptName, string Script)
        {

        }

        public void AddHackList(int index, ListView LV, string aName, int aAddress, HackType aHackType, string Script, int offset)
        {

            ListViewItem lvi = null;
            switch (aHackType)
            {
                case HackType._Byte:
                case HackType._2Bytes:
                case HackType._4Bytes:
                    lvi = new ListViewItem(new string[] { aName, aAddress.ToString("X8"), aHackType.ToString(), "?" });
                    break;
                case HackType._Pointer:
                    lvi = new ListViewItem(new string[] { aName, string.Format("P[{0:X8}]+{1:X4}", aAddress, offset), "4bytes Pointer", "?" });
                    break;
                case HackType.AssemblyScript:
                    lvi = new ListViewItem(new string[] { aName, " - ", "Auto Assemble Script", Script });
                    break;
                default:
                    break;
            }

            if (index == -1)
                LV.Items.Add(lvi);
            else
                LV.Items.Insert(index, lvi);
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                NimoFunction.DarkUnHSEagle();
                System.Threading.Thread.Sleep(250);

                Process[] MSProc = Process.GetProcessesByName("MapleStory");
                if (MSProc.Length == 0)
                {
                    MSStatus.Text = "No MapleStory Attached!";
                    MessageBox.Show("未找到 MapleStory.exe", "MS-Memory Writer by nimo1993", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                IntPtr hProcess = API.OpenProcess(API.ProcessAccessFlags.All, false, MSProc[0].Id);

                NimoFunction.NimoHSCRCBypass(hProcess);

                MSPID = MSProc[0].Id;
                MShProcess = hProcess;
                API.CEInitialize(MSPID, MShProcess);
                MSStatus.Text = string.Format("MapleStory.exe - PID: {0:X4} Process Handle: {1:X4}", MSProc[0].Id, hProcess);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void 新增toolStripButton_Click(object sender, EventArgs e)
        {
            AddHack();
        }

        private void timerReadValue_Tick(object sender, EventArgs e)
        {
            try
            {


                int number;
                foreach (ListViewItem item in HackListView.Items)
                {
                    byte[] buffer;
                    switch (item.SubItems[2].Text)
                    {
                        case "_Byte":
                            buffer = new byte[1];
                            if (API.ReadProcessMemory(MShProcess, (IntPtr)Convert.ToInt32(item.SubItems[1].Text, 16), buffer, 1, out number))
                            {
                                if (IsHex.Checked)
                                    item.SubItems[3].Text = buffer[0].ToString("X2");
                                else
                                    item.SubItems[3].Text = buffer[0].ToString();
                            }
                            else
                            {
                                item.SubItems[3].Text = "?";
                            }
                            break;
                        case "_2Bbytes":
                            buffer = new byte[2];
                            if (API.ReadProcessMemory(MShProcess, (IntPtr)Convert.ToInt32(item.SubItems[1].Text, 16), buffer, 2, out number))
                            {
                                if (IsHex.Checked)
                                    item.SubItems[3].Text = BitConverter.ToInt16(buffer, 0).ToString("X4");
                                else
                                    item.SubItems[3].Text = BitConverter.ToInt16(buffer, 0).ToString();
                            }
                            else
                            {
                                item.SubItems[3].Text = "?";
                            }

                            break;
                        case "_4Bytes":
                            buffer = new byte[4];
                            if (API.ReadProcessMemory(MShProcess, (IntPtr)Convert.ToInt32(item.SubItems[1].Text, 16), buffer, 4, out number))
                            {
                                if (IsHex.Checked)
                                    item.SubItems[3].Text = BitConverter.ToInt32(buffer, 0).ToString("X8");
                                else
                                    item.SubItems[3].Text = BitConverter.ToInt32(buffer, 0).ToString();
                            }
                            else
                            {
                                item.SubItems[3].Text = "?";
                            }
                            break;
                        case "4bytes Pointer":
                            buffer = new byte[4];
                            if (API.ReadProcessMemory(MShProcess, (IntPtr)Convert.ToInt32(item.SubItems[1].Text.Substring(2, 8), 16), buffer, 4, out number))
                            {
                                IntPtr targetAddr = (IntPtr)(BitConverter.ToInt32(buffer, 0) + Convert.ToInt32(item.SubItems[1].Text.Substring(12, 4), 16));

                                if (API.ReadProcessMemory(MShProcess, targetAddr, buffer, 4, out number))
                                {
                                    if (IsHex.Checked)
                                        item.SubItems[3].Text = BitConverter.ToInt32(buffer, 0).ToString("X8");
                                    else
                                        item.SubItems[3].Text = BitConverter.ToInt32(buffer, 0).ToString();
                                }
                                else
                                {
                                    item.SubItems[3].Text = "?";
                                }
                            }
                            else
                            {
                                item.SubItems[3].Text = "?";
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            {
            }

        }

        private void HackListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void 內容CToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 刪除toolStripButton_Click(object sender, EventArgs e)
        {
            RemoveHack();
        }

        private void 編輯StripButton1_Click(object sender, EventArgs e)
        {
            EditHack();
        }


        void AddHack()
        {
            frmAdd FA = new frmAdd();
            FA.Text = "新增(Add)";
            DialogResult DR = FA.ShowDialog();
            if (DR == DialogResult.OK)
            {
                switch (FA.MSTAB.SelectedIndex)
                {
                    case 0:
                        HackType SetHT;
                        switch (FA.comType.SelectedIndex)
                        {
                            case 0:
                                SetHT = HackType._Byte;
                                break;
                            case 1:
                                SetHT = HackType._2Bytes;
                                break;
                            default:
                                SetHT = HackType._4Bytes;
                                break;
                        }
                        AddHackList(-1, HackListView, FA.txtName.Text, Convert.ToInt32(FA.txtAddress.Text, 16), SetHT, "", 0);
                        break;
                    case 1:
                        AddHackList(-1, HackListView, FA.txtName.Text, Convert.ToInt32(FA.txtAOP.Text, 16), HackType._Pointer, "", Convert.ToInt32(FA.txtOffset.Text, 16));
                        break;
                    default:
                        AddHackList(-1, HackListView, FA.txtName.Text, 0, HackType.AssemblyScript, FA.txtASM.Text, 0);
                        break;
                }

            }
        }

        void RemoveHack()
        {
            if (HackListView.SelectedItems.Count == 0)
                return;

            if (HackListView.SelectedItems[0].Checked)
            {
                MessageBox.Show("這個項目正在使用，請先取消打勾\nThe item is enabled. Please unlock the item first.");
                return;
            }

            HackListView.SelectedItems[0].Remove();
        }

        void EditHack()
        {
            if (HackListView.SelectedItems.Count == 0)
                return;

            if (HackListView.SelectedItems[0].Checked)
            {
                MessageBox.Show("這個項目正在使用，請先取消打勾\nThe item is enabled. Please unlock the item first.");
                return;
            }

            frmAdd FA = new frmAdd();
            FA.Text = "編輯(Edit)";
            switch (HackListView.SelectedItems[0].SubItems[2].Text)
            {
                case "Auto Assemble Script":
                    FA.MSTAB.SelectedIndex = 2;
                    FA.txtASM.Text = HackListView.SelectedItems[0].SubItems[3].Text;
                    break;

                case "4bytes Pointer":
                    FA.MSTAB.SelectedIndex = 1;
                    string PointerStr = HackListView.SelectedItems[0].SubItems[1].Text;
                    FA.txtAOP.Text = PointerStr.Substring(2, 8);
                    FA.txtOffset.Text = PointerStr.Substring(12, 4);
                    break;
                default:
                    FA.MSTAB.SelectedIndex = 0;
                    switch (HackListView.SelectedItems[0].SubItems[2].Text)
                    {
                        case "_Byte":
                            FA.comType.SelectedIndex = 0;
                            break;
                        case "_2Bytes":
                            FA.comType.SelectedIndex = 1;
                            break;
                        default:
                            FA.comType.SelectedIndex = 2;
                            break;
                    }
                    FA.txtAddress.Text = HackListView.SelectedItems[0].SubItems[1].Text;
                    break;
            }

            FA.txtName.Text = HackListView.SelectedItems[0].SubItems[0].Text;

            DialogResult DR = FA.ShowDialog();


            if (DR == DialogResult.OK)
            {

                switch (FA.MSTAB.SelectedIndex)
                {
                    case 0:
                        HackType SetHT;
                        switch (FA.comType.SelectedIndex)
                        {
                            case 0:
                                SetHT = HackType._Byte;
                                break;
                            case 1:
                                SetHT = HackType._2Bytes;
                                break;
                            default:
                                SetHT = HackType._4Bytes;
                                break;
                        }

                        AddHackList(HackListView.SelectedItems[0].Index, HackListView, FA.txtName.Text, Convert.ToInt32(FA.txtAddress.Text, 16), SetHT, "", 0);
                        break;
                    case 1:
                        AddHackList(HackListView.SelectedItems[0].Index, HackListView, FA.txtName.Text, Convert.ToInt32(FA.txtAOP.Text, 16), HackType._Pointer, "", Convert.ToInt32(FA.txtOffset.Text, 16));
                        break;
                    default:
                        AddHackList(HackListView.SelectedItems[0].Index, HackListView, FA.txtName.Text, 0, HackType.AssemblyScript, FA.txtASM.Text, 0);
                        break;
                }

                HackListView.SelectedItems[0].Remove();
            }
        }

        private void 新增項目AddAItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddHack();
        }

        private void 編輯選取項目EditTheSelectedItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditHack();
        }

        private void 刪除選取項目RemoveTheSelectedItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveHack();
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();

        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        void NewFile()
        {
            if (MessageBox.Show("確定要開新檔案?若檔案未儲存將會遺失\nAre you sure to open a new file? If your file isn't saved, the record will be missing.", "MS-MemoryWriter by nimo1993", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;

            foreach (ListViewItem item in HackListView.Items)
            {
                if (item.Checked)
                {
                    MessageBox.Show("這些項目正在使用，請先取消打勾\nThese items are enabled. Please unlock these items first.");
                    return;
                }
            }

            toolStripFileName.Text = "* Unsaved *";
            HackListView.Items.Clear();
        }
        void OpenFile()
        {

            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "MS-Memory Writer 儲存檔案";
            OFD.Filter = "NIMO file (*.nimo)|*.nimo|All files|*.*";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                StreamReader SR = new StreamReader(OFD.FileName, Encoding.Default);
                string[] datas = SR.ReadToEnd().Split(new string[] { "|N-O-L|" }, StringSplitOptions.None);
                foreach (string item in datas)
                {
                    if (item == "")
                    {
                        break;
                    }
                    string[] lineitem = item.Split(new string[] { "|N-O|" }, StringSplitOptions.None);
                    ListViewItem lvi = new ListViewItem(lineitem);
                    HackListView.Items.Add(lvi);
                }
                toolStripFileName.Text = OFD.FileName;
                SR.Close();
            }
            
        }
        void SaveFile()
        {
            try
            {

                if (HackListView.Items.Count == 0)
                {
                    throw new Exception("沒有任何資料可以儲存!");
                }

                if (toolStripFileName.Text == "* Unsaved *")
                {
                    SaveFileDialog SFD = new SaveFileDialog();
                    SFD.Title = "MS-Memory Writer 儲存檔案";
                    SFD.Filter = "NIMO file (*.nimo)|*.nimo|All files|*.*";
                    if (SFD.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    toolStripFileName.Text = SFD.FileName;
                }

                StreamWriter SW = new StreamWriter(toolStripFileName.Text, false, Encoding.Default);

                foreach (ListViewItem item in HackListView.Items)
                {
                    for (int i = 0; i < 4; i++)
                    {

                        SW.Write(item.SubItems[i].Text);
                        SW.Write("|N-O|");
                    }
                    SW.Write("|N-O-L|");
                }

                SW.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void SaveFileAs()
        {
            try
            {
                if (HackListView.Items.Count == 0)
                {
                    throw new Exception("沒有任何資料可以儲存!");
                }


                SaveFileDialog SFD = new SaveFileDialog();
                SFD.Title = "MS-Memory Writer 儲存檔案";
                SFD.Filter = "NIMO file (*.nimo)|*.nimo|All files|*.*";
                if (SFD.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                toolStripFileName.Text = SFD.FileName;
                StreamWriter SW = new StreamWriter(toolStripFileName.Text, false, Encoding.Default);

                foreach (ListViewItem item in HackListView.Items)
                {
                    for (int i = 0; i < 4; i++)
                    {

                        SW.Write(item.SubItems[i].Text);
                        SW.Write("|N-O|");
                    }
                    SW.Write("|N-O-L|");
                }

                SW.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        bool IsAdd = true;
        private void HackListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            IsAdd = false;
        }

        private void HackListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (IsAdd)
            {
                return;
            }
            IsAdd = true;

            switch (e.Item.SubItems[2].Text)
            {
                case "Auto Assemble Script":
                    string Script = e.Item.SubItems[3].Text;
                    API.CEAutoAsm(Script, e.Item.Checked, out AllocID[e.Item.Index]);
                    break;
                case "_Byte":
                case "_2Bytes":
                case "_4Bytes":
                default:
                    MessageBox.Show("鎖定Value尚未完成!");
                    break;
            }

        }

        private void 刪除RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditHack();
        }

        private void 刪除RemoveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RemoveHack();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("確定要離開?若檔案未儲存將會遺失\nAre you sure to exit? If the file isn't saved, the record will be missing.", "MS-MemoryWriter by nimo1993", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public enum HackType : int
    {
        _Byte = 0,
        _2Bytes = 1,
        _4Bytes = 2,
        _Pointer = 3,
        AssemblyScript = 4

    }

}