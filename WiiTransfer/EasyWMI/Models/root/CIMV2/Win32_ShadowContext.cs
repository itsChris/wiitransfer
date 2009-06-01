using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_ShadowContext : WMIBase
    {
        
        private string m_Caption;
        
        private bool m_ClientAccessible;
        
        private string m_Description;
        
        private bool m_Differential;
        
        private bool m_ExposedLocally;
        
        private bool m_ExposedRemotely;
        
        private bool m_HardwareAssisted;
        
        private bool m_Imported;
        
        private string m_Name;
        
        private bool m_NoAutoRelease;
        
        private bool m_NotSurfaced;
        
        private bool m_NoWriters;
        
        private bool m_Persistent;
        
        private bool m_Plex;
        
        private string m_SettingID;
        
        private bool m_Transportable;
        
        private string m_MyPath;
        
        public Win32_ShadowContext()
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
        
        public bool ClientAccessible
        {
            get
            {
                return this.m_ClientAccessible;
            }
            set
            {
                this.m_ClientAccessible = value;
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
        
        public bool Differential
        {
            get
            {
                return this.m_Differential;
            }
            set
            {
                this.m_Differential = value;
            }
        }
        
        public bool ExposedLocally
        {
            get
            {
                return this.m_ExposedLocally;
            }
            set
            {
                this.m_ExposedLocally = value;
            }
        }
        
        public bool ExposedRemotely
        {
            get
            {
                return this.m_ExposedRemotely;
            }
            set
            {
                this.m_ExposedRemotely = value;
            }
        }
        
        public bool HardwareAssisted
        {
            get
            {
                return this.m_HardwareAssisted;
            }
            set
            {
                this.m_HardwareAssisted = value;
            }
        }
        
        public bool Imported
        {
            get
            {
                return this.m_Imported;
            }
            set
            {
                this.m_Imported = value;
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
        
        public bool NoAutoRelease
        {
            get
            {
                return this.m_NoAutoRelease;
            }
            set
            {
                this.m_NoAutoRelease = value;
            }
        }
        
        public bool NotSurfaced
        {
            get
            {
                return this.m_NotSurfaced;
            }
            set
            {
                this.m_NotSurfaced = value;
            }
        }
        
        public bool NoWriters
        {
            get
            {
                return this.m_NoWriters;
            }
            set
            {
                this.m_NoWriters = value;
            }
        }
        
        public bool Persistent
        {
            get
            {
                return this.m_Persistent;
            }
            set
            {
                this.m_Persistent = value;
            }
        }
        
        public bool Plex
        {
            get
            {
                return this.m_Plex;
            }
            set
            {
                this.m_Plex = value;
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
        
        public bool Transportable
        {
            get
            {
                return this.m_Transportable;
            }
            set
            {
                this.m_Transportable = value;
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
