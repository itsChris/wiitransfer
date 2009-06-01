using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_WMISetting : WMIBase
    {
        
        private string m_ASPScriptDefaultNamespace;
        
        private bool m_ASPScriptEnabled;
        
        private string [] m_AutorecoverMofs;
        
        private uint m_AutoStartWin9X;
        
        private uint m_BackupInterval;
        
        private string m_BackupLastTime;
        
        private string m_BuildVersion;
        
        private string m_Caption;
        
        private string m_DatabaseDirectory;
        
        private uint m_DatabaseMaxSize;
        
        private string m_Description;
        
        private bool m_EnableAnonWin9xConnections;
        
        private bool m_EnableEvents;
        
        private bool m_EnableStartupHeapPreallocation;
        
        private uint m_HighThresholdOnClientObjects;
        
        private uint m_HighThresholdOnEvents;
        
        private string m_InstallationDirectory;
        
        private uint m_LastStartupHeapPreallocation;
        
        private string m_LoggingDirectory;
        
        private uint m_LoggingLevel;
        
        private uint m_LowThresholdOnClientObjects;
        
        private uint m_LowThresholdOnEvents;
        
        private uint m_MaxLogFileSize;
        
        private uint m_MaxWaitOnClientObjects;
        
        private uint m_MaxWaitOnEvents;
        
        private string m_MofSelfInstallDirectory;
        
        private string m_SettingID;
        
        private string m_MyPath;
        
        public Win32_WMISetting()
        {
        }
        
        public string ASPScriptDefaultNamespace
        {
            get
            {
                return this.m_ASPScriptDefaultNamespace;
            }
            set
            {
                this.m_ASPScriptDefaultNamespace = value;
            }
        }
        
        public bool ASPScriptEnabled
        {
            get
            {
                return this.m_ASPScriptEnabled;
            }
            set
            {
                this.m_ASPScriptEnabled = value;
            }
        }
        
        public string [] AutorecoverMofs
        {
            get
            {
                return this.m_AutorecoverMofs;
            }
            set
            {
                this.m_AutorecoverMofs = value;
            }
        }
        
        public uint AutoStartWin9X
        {
            get
            {
                return this.m_AutoStartWin9X;
            }
            set
            {
                this.m_AutoStartWin9X = value;
            }
        }
        
        public uint BackupInterval
        {
            get
            {
                return this.m_BackupInterval;
            }
            set
            {
                this.m_BackupInterval = value;
            }
        }
        
        public string BackupLastTime
        {
            get
            {
                return this.m_BackupLastTime;
            }
            set
            {
                this.m_BackupLastTime = value;
            }
        }
        
        public string BuildVersion
        {
            get
            {
                return this.m_BuildVersion;
            }
            set
            {
                this.m_BuildVersion = value;
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
        
        public string DatabaseDirectory
        {
            get
            {
                return this.m_DatabaseDirectory;
            }
            set
            {
                this.m_DatabaseDirectory = value;
            }
        }
        
        public uint DatabaseMaxSize
        {
            get
            {
                return this.m_DatabaseMaxSize;
            }
            set
            {
                this.m_DatabaseMaxSize = value;
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
        
        public bool EnableAnonWin9xConnections
        {
            get
            {
                return this.m_EnableAnonWin9xConnections;
            }
            set
            {
                this.m_EnableAnonWin9xConnections = value;
            }
        }
        
        public bool EnableEvents
        {
            get
            {
                return this.m_EnableEvents;
            }
            set
            {
                this.m_EnableEvents = value;
            }
        }
        
        public bool EnableStartupHeapPreallocation
        {
            get
            {
                return this.m_EnableStartupHeapPreallocation;
            }
            set
            {
                this.m_EnableStartupHeapPreallocation = value;
            }
        }
        
        public uint HighThresholdOnClientObjects
        {
            get
            {
                return this.m_HighThresholdOnClientObjects;
            }
            set
            {
                this.m_HighThresholdOnClientObjects = value;
            }
        }
        
        public uint HighThresholdOnEvents
        {
            get
            {
                return this.m_HighThresholdOnEvents;
            }
            set
            {
                this.m_HighThresholdOnEvents = value;
            }
        }
        
        public string InstallationDirectory
        {
            get
            {
                return this.m_InstallationDirectory;
            }
            set
            {
                this.m_InstallationDirectory = value;
            }
        }
        
        public uint LastStartupHeapPreallocation
        {
            get
            {
                return this.m_LastStartupHeapPreallocation;
            }
            set
            {
                this.m_LastStartupHeapPreallocation = value;
            }
        }
        
        public string LoggingDirectory
        {
            get
            {
                return this.m_LoggingDirectory;
            }
            set
            {
                this.m_LoggingDirectory = value;
            }
        }
        
        public uint LoggingLevel
        {
            get
            {
                return this.m_LoggingLevel;
            }
            set
            {
                this.m_LoggingLevel = value;
            }
        }
        
        public uint LowThresholdOnClientObjects
        {
            get
            {
                return this.m_LowThresholdOnClientObjects;
            }
            set
            {
                this.m_LowThresholdOnClientObjects = value;
            }
        }
        
        public uint LowThresholdOnEvents
        {
            get
            {
                return this.m_LowThresholdOnEvents;
            }
            set
            {
                this.m_LowThresholdOnEvents = value;
            }
        }
        
        public uint MaxLogFileSize
        {
            get
            {
                return this.m_MaxLogFileSize;
            }
            set
            {
                this.m_MaxLogFileSize = value;
            }
        }
        
        public uint MaxWaitOnClientObjects
        {
            get
            {
                return this.m_MaxWaitOnClientObjects;
            }
            set
            {
                this.m_MaxWaitOnClientObjects = value;
            }
        }
        
        public uint MaxWaitOnEvents
        {
            get
            {
                return this.m_MaxWaitOnEvents;
            }
            set
            {
                this.m_MaxWaitOnEvents = value;
            }
        }
        
        public string MofSelfInstallDirectory
        {
            get
            {
                return this.m_MofSelfInstallDirectory;
            }
            set
            {
                this.m_MofSelfInstallDirectory = value;
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
