namespace MS_MemoryWriter
{
    partial class frmAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd));
            this.MSTAB = new System.Windows.Forms.TabControl();
            this.tabAddr = new System.Windows.Forms.TabPage();
            this.comType = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPointer = new System.Windows.Forms.TabPage();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAOP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabASM = new System.Windows.Forms.TabPage();
            this.txtASM = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.MSTAB.SuspendLayout();
            this.tabAddr.SuspendLayout();
            this.tabPointer.SuspendLayout();
            this.tabASM.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSTAB
            // 
            this.MSTAB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MSTAB.Controls.Add(this.tabAddr);
            this.MSTAB.Controls.Add(this.tabPointer);
            this.MSTAB.Controls.Add(this.tabASM);
            this.MSTAB.Location = new System.Drawing.Point(12, 42);
            this.MSTAB.Name = "MSTAB";
            this.MSTAB.SelectedIndex = 0;
            this.MSTAB.Size = new System.Drawing.Size(321, 283);
            this.MSTAB.TabIndex = 0;
            // 
            // tabAddr
            // 
            this.tabAddr.Controls.Add(this.comType);
            this.tabAddr.Controls.Add(this.txtAddress);
            this.tabAddr.Controls.Add(this.label2);
            this.tabAddr.Controls.Add(this.label1);
            this.tabAddr.Location = new System.Drawing.Point(4, 21);
            this.tabAddr.Name = "tabAddr";
            this.tabAddr.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddr.Size = new System.Drawing.Size(313, 258);
            this.tabAddr.TabIndex = 0;
            this.tabAddr.Text = "位址(Address)";
            this.tabAddr.UseVisualStyleBackColor = true;
            // 
            // comType
            // 
            this.comType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comType.Items.AddRange(new object[] {
            "Byte",
            "2 Bytes",
            "4 Bytes"});
            this.comType.Location = new System.Drawing.Point(136, 51);
            this.comType.Name = "comType";
            this.comType.Size = new System.Drawing.Size(111, 20);
            this.comType.TabIndex = 0;
            this.comType.SelectedIndexChanged += new System.EventHandler(this.comType_SelectedIndexChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(135, 17);
            this.txtAddress.MaxLength = 8;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(113, 22);
            this.txtAddress.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "型態(Type):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "位址(Address):";
            // 
            // tabPointer
            // 
            this.tabPointer.Controls.Add(this.txtOffset);
            this.tabPointer.Controls.Add(this.label4);
            this.tabPointer.Controls.Add(this.txtAOP);
            this.tabPointer.Controls.Add(this.label3);
            this.tabPointer.Location = new System.Drawing.Point(4, 21);
            this.tabPointer.Name = "tabPointer";
            this.tabPointer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPointer.Size = new System.Drawing.Size(313, 258);
            this.tabPointer.TabIndex = 1;
            this.tabPointer.Text = "指標(Pointer)";
            this.tabPointer.UseVisualStyleBackColor = true;
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(171, 52);
            this.txtOffset.MaxLength = 4;
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(113, 22);
            this.txtOffset.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "偏移值(Offset):";
            // 
            // txtAOP
            // 
            this.txtAOP.Location = new System.Drawing.Point(171, 13);
            this.txtAOP.MaxLength = 8;
            this.txtAOP.Name = "txtAOP";
            this.txtAOP.Size = new System.Drawing.Size(113, 22);
            this.txtAOP.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "指標位址(Address of Pointer):";
            // 
            // tabASM
            // 
            this.tabASM.Controls.Add(this.txtASM);
            this.tabASM.Location = new System.Drawing.Point(4, 21);
            this.tabASM.Name = "tabASM";
            this.tabASM.Size = new System.Drawing.Size(313, 258);
            this.tabASM.TabIndex = 2;
            this.tabASM.Text = "組合語言(Auto Assemble)";
            this.tabASM.UseVisualStyleBackColor = true;
            // 
            // txtASM
            // 
            this.txtASM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtASM.Location = new System.Drawing.Point(10, 9);
            this.txtASM.MaxLength = 0;
            this.txtASM.Multiline = true;
            this.txtASM.Name = "txtASM";
            this.txtASM.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtASM.Size = new System.Drawing.Size(293, 246);
            this.txtASM.TabIndex = 0;
            this.txtASM.WordWrap = false;
            this.txtASM.TextChanged += new System.EventHandler(this.txtASM_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(12, 332);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(134, 27);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "確定(&OK)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(199, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 27);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消(&Cancel)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "名稱(Name):";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(90, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 22);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "No Name";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(349, 371);
            this.ControlBox = false;
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.MSTAB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MS-Memory Writer by nimo1993.";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.MSTAB.ResumeLayout(false);
            this.tabAddr.ResumeLayout(false);
            this.tabAddr.PerformLayout();
            this.tabPointer.ResumeLayout(false);
            this.tabPointer.PerformLayout();
            this.tabASM.ResumeLayout(false);
            this.tabASM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabAddr;
        private System.Windows.Forms.TabPage tabPointer;
        private System.Windows.Forms.TabPage tabASM;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabControl MSTAB;
        public System.Windows.Forms.ComboBox comType;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtAOP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtASM;
        public System.Windows.Forms.TextBox txtName;

    }
}