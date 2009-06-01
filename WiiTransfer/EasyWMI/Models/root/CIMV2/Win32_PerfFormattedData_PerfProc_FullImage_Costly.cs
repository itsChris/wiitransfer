using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_PerfProc_FullImage_Costly : WMIBase
    {
        
        private string m_Caption;
        
        private string m_Description;
        
        private ulong m_ExecReadOnly;
        
        private ulong m_ExecReadPerWrite;
        
        private ulong m_Executable;
        
        private ulong m_ExecWriteCopy;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private ulong m_NoAccess;
        
        private ulong m_ReadOnly;
        
        private ulong m_ReadPerWrite;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private ulong m_WriteCopy;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_PerfProc_FullImage_Costly()
        {
        }
        
        public string Caption
        {
            get
            {
                return this.m_Caption;
            }
            set
            {
                this.m_Caption = value;
            }
        }
        
        public string Description
        {
            get
            {
                return this.m_Description;
            }
            set
            {
                this.m_Description = value;
            }
        }
        
        public ulong ExecReadOnly
        {
            get
            {
                return this.m_ExecReadOnly;
            }
            set
            {
                this.m_ExecReadOnly = value;
            }
        }
        
        public ulong ExecReadPerWrite
        {
            get
            {
                return this.m_ExecReadPerWrite;
            }
            set
            {
                this.m_ExecReadPerWrite = value;
            }
        }
        
        public ulong Executable
        {
            get
            {
                return this.m_Executable;
            }
            set
            {
                this.m_Executable = value;
            }
        }
        
        public ulong ExecWriteCopy
        {
            get
            {
                return this.m_ExecWriteCopy;
            }
            set
            {
                this.m_ExecWriteCopy = value;
            }
        }
        
        public ulong Frequency_Object
        {
            get
            {
                return this.m_Frequency_Object;
            }
            set
            {
                this.m_Frequency_Object = value;
            }
        }
        
        public ulong Frequency_PerfTime
        {
            get
            {
                return this.m_Frequency_PerfTime;
            }
            set
            {
                this.m_Frequency_PerfTime = value;
            }
        }
        
        public ulong Frequency_Sys100NS
        {
            get
            {
                return this.m_Frequency_Sys100NS;
            }
            set
            {
                this.m_Frequency_Sys100NS = value;
            }
        }
        
        public string Name
        {
            get
            {
                return this.m_Name;
            }
            set
            {
                this.m_Name = value;
            }
        }
        
        public ulong NoAccess
        {
            get
            {
                return this.m_NoAccess;
            }
            set
            {
                this.m_NoAccess = value;
            }
        }
        
        public ulong ReadOnly
        {
            get
            {
                return this.m_ReadOnly;
            }
            set
            {
                this.m_ReadOnly = value;
            }
        }
        
        public ulong ReadPerWrite
        {
            get
            {
                return this.m_ReadPerWrite;
            }
            set
            {
                this.m_ReadPerWrite = value;
            }
        }
        
        public ulong Timestamp_Object
        {
            get
            {
                return this.m_Timestamp_Object;
            }
            set
            {
                this.m_Timestamp_Object = value;
            }
        }
        
        public ulong Timestamp_PerfTime
        {
            get
            {
                return this.m_Timestamp_PerfTime;
            }
            set
            {
                this.m_Timestamp_PerfTime = value;
            }
        }
        
        public ulong Timestamp_Sys100NS
        {
            get
            {
                return this.m_Timestamp_Sys100NS;
            }
            set
            {
                this.m_Timestamp_Sys100NS = value;
            }
        }
        
        public ulong WriteCopy
        {
            get
            {
                return this.m_WriteCopy;
            }
            set
            {
                this.m_WriteCopy = value;
            }
        }
        
        public string MyPath
        {
            get
            {
                return this.m_MyPath;
            }
            set
            {
                this.m_MyPath = value;
            }
        }
    }
}
