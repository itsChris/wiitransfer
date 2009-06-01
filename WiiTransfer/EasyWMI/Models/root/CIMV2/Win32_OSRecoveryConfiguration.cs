using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_OSRecoveryConfiguration : WMIBase
    {
        
        private bool m_AutoReboot;
        
        private string m_Caption;
        
        private string m_DebugFilePath;
        
        private uint m_DebugInfoType;
        
        private string m_Description;
        
        private string m_ExpandedDebugFilePath;
        
        private string m_ExpandedMiniDumpDirectory;
        
        private bool m_KernelDumpOnly;
        
        private string m_MiniDumpDirectory;
        
        private string m_Name;
        
        private bool m_OverwriteExistingDebugFile;
        
        private bool m_SendAdminAlert;
        
        private string m_SettingID;
        
        private bool m_WriteDebugInfo;
        
        private bool m_WriteToSystemLog;
        
        private string m_MyPath;
        
        public Win32_OSRecoveryConfiguration()
        {
        }
        
        public bool AutoReboot
        {
            get
            {
                return this.m_AutoReboot;
            }
            set
            {
                this.m_AutoReboot = value;
            }
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
        
        public string DebugFilePath
        {
            get
            {
                return this.m_DebugFilePath;
            }
            set
            {
                this.m_DebugFilePath = value;
            }
        }
        
        public uint DebugInfoType
        {
            get
            {
                return this.m_DebugInfoType;
            }
            set
            {
                this.m_DebugInfoType = value;
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
        
        public string ExpandedDebugFilePath
        {
            get
            {
                return this.m_ExpandedDebugFilePath;
            }
            set
            {
                this.m_ExpandedDebugFilePath = value;
            }
        }
        
        public string ExpandedMiniDumpDirectory
        {
            get
            {
                return this.m_ExpandedMiniDumpDirectory;
            }
            set
            {
                this.m_ExpandedMiniDumpDirectory = value;
            }
        }
        
        public bool KernelDumpOnly
        {
            get
            {
                return this.m_KernelDumpOnly;
            }
            set
            {
                this.m_KernelDumpOnly = value;
            }
        }
        
        public string MiniDumpDirectory
        {
            get
            {
                return this.m_MiniDumpDirectory;
            }
            set
            {
                this.m_MiniDumpDirectory = value;
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
        
        public bool OverwriteExistingDebugFile
        {
            get
            {
                return this.m_OverwriteExistingDebugFile;
            }
            set
            {
                this.m_OverwriteExistingDebugFile = value;
            }
        }
        
        public bool SendAdminAlert
        {
            get
            {
                return this.m_SendAdminAlert;
            }
            set
            {
                this.m_SendAdminAlert = value;
            }
        }
        
        public string SettingID
        {
            get
            {
                return this.m_SettingID;
            }
            set
            {
                this.m_SettingID = value;
            }
        }
        
        public bool WriteDebugInfo
        {
            get
            {
                return this.m_WriteDebugInfo;
            }
            set
            {
                this.m_WriteDebugInfo = value;
            }
        }
        
        public bool WriteToSystemLog
        {
            get
            {
                return this.m_WriteToSystemLog;
            }
            set
            {
                this.m_WriteToSystemLog = value;
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
