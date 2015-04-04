using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MS_MemoryWriter
{
    class NimoFunction
    {
        /// <summary>
        /// Fake Taskmgr APIBypassing BY 小可, Translation BY NIMO1993.
        /// </summary>
        public static void DarkUnHSEagle()
        {
            /*
             * 感謝 大可 提供PEB偽造ImagePathName方法，原C++作
             	_asm
            	{
		            mov eax,fs:[0x30]    //eax points to PEB
            		mov eax,[eax+0x010]  //eax points to _PEB->_RTL_USER_PROCESS_PARAMETERS
            		add eax,0x38         //eax points to ImagePathName(UNICODE_STRING)
            		add eax,0x4			 //UNICODE_STRING.Buffer
            		mov ebx,wszImagePathName
            		mov [eax],ebx
            		mov eax,[eax]
            	}
            */
            API.PROCESS_BASIC_INFORMATION PBI = new API.PROCESS_BASIC_INFORMATION();
            int nsize;

            API.NtQueryInformationProcess((IntPtr)(-1), API.PROCESSINFOCLASS.ProcessBasicInformation, ref PBI, Marshal.SizeOf(typeof(API.PROCESS_BASIC_INFORMATION)), out nsize);
            int PEBBaseAddress = PBI.PebBaseAddress;
            int RTL_USER_PROCESS_PARAMETERS = Marshal.ReadInt32((IntPtr)(PEBBaseAddress + 0x10));
            int ImagePathName_UNICODE_STRING = RTL_USER_PROCESS_PARAMETERS + 0x38;
            int UNICODE_STRING_Buffer = ImagePathName_UNICODE_STRING + 0x4; //儲存字串所在位址的Buffer
            IntPtr FakeTaskMgr = Marshal.StringToHGlobalAuto(Environment.SystemDirectory + @"\" + Program.tak);
            Marshal.WriteIntPtr((IntPtr)UNICODE_STRING_Buffer, FakeTaskMgr); //置換成自己偽裝的位址
            Environment.CurrentDirectory = Environment.SystemDirectory;
        }

        /// <summary>
        /// HackShield CRC Bypass BY NIMO1993.
        /// </summary>
        /// <param name="hProcess">受HS保護的 Process Handle</param>
        public static void NimoHSCRCBypass(IntPtr hProcess)
        {
            byte[] jmp = { 0xE9};

            int OPAddress = API.GetProcAddress(API.GetModuleHandle("kernel32.dll"), "OpenProcess");
            byte[] OPAddressByte = BitConverter.GetBytes(OPAddress);
            byte[] CRCBypassAOB = { 0x64, 0xa1, 0x20, 0x00, 0x00, 0x00, 0x3b, 0x44, 0x24, 0x0c, 0x75, 0x10, 0x64, 0xc7, 0x05, 0x34, 0x00, 0x00, 0x00, 0x57, 0x00, 0x00, 0x00, 0x31, 0xc0, 0xc2, 0x0c, 0x00, 0x8b, 0xff, 0x55, 0x8b, 0xec };
            int NimoHSCRCBypassAddress = API.VirtualAllocEx(hProcess, 0, CRCBypassAOB.Length, API.AllocationType.Commit, API.MemoryProtection.ReadWrite);

            WriteBinaryMemory(hProcess, (IntPtr)NimoHSCRCBypassAddress, CRCBypassAOB, false);
            byte[] JumpToScript = BitConverter.GetBytes(NimoHSCRCBypassAddress - (OPAddress + 5));
            byte[] ScriptToAPI = BitConverter.GetBytes((OPAddress + 5) - (NimoHSCRCBypassAddress + CRCBypassAOB.Length + 5));

            WriteBinaryMemory(hProcess, (IntPtr)(NimoHSCRCBypassAddress + CRCBypassAOB.Length), jmp, false);
            WriteBinaryMemory(hProcess, (IntPtr)(NimoHSCRCBypassAddress + CRCBypassAOB.Length + 1), ScriptToAPI, false);

            WriteBinaryMemory(hProcess, (IntPtr)OPAddress, jmp, true);
            WriteBinaryMemory(hProcess, (IntPtr)(OPAddress + 1), JumpToScript, true);
           
        }

        public static bool WriteBinaryMemory(IntPtr hProcess, IntPtr BaseAddress, byte[] buffer, bool IsUnprotect)
        {
            int lpNumberOfBytesWritten;
            bool ret;

            if (IsUnprotect)
            {
                API.MemoryProtection OldProtect;
                API.VirtualProtectEx(hProcess, BaseAddress, (UIntPtr)buffer.Length, API.MemoryProtection.ReadWrite, out OldProtect);
                ret = API.WriteProcessMemory(hProcess, BaseAddress, buffer, (UIntPtr)buffer.Length, out lpNumberOfBytesWritten);
                API.VirtualProtectEx(hProcess, BaseAddress, (UIntPtr)buffer.Length, OldProtect, out OldProtect);
                return ret;
            }
            else
                return API.WriteProcessMemory(hProcess, BaseAddress, buffer, (UIntPtr)buffer.Length, out lpNumberOfBytesWritten);            
        }

        public static bool ReadBinaryMemory(IntPtr hProcess, IntPtr BaseAddress, byte[] buffer, int ReadSize)
        {
            int lpNumberOfBytesRead;
            return API.ReadProcessMemory(hProcess, BaseAddress, buffer, (UIntPtr)ReadSize, out lpNumberOfBytesRead);
        }
    }
}
