using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_QuotaSetting : WMIBase
    {
        
        private string m_Caption;
        
        private long m_DefaultLimit;
        
        private long m_DefaultWarningLimit;
        
        private string m_Description;
        
        private bool m_ExceededNotification;
        
        private string m_SettingID;
        
        private uint m_State;
        
        private string m_VolumePath;
        
        private bool m_WarningExceededNotification;
        
        private string m_MyPath;
        
        public Win32_QuotaSetting()
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
        
        public long DefaultLimit
        {
            get
            {
                return this.m_DefaultLimit;
            }
            set
            {
                this.m_DefaultLimit = value;
            }
        }
        
        public long DefaultWarningLimit
        {
            get
            {
                return this.m_DefaultWarningLimit;
            }
            set
            {
                this.m_DefaultWarningLimit = value;
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
        
        public bool ExceededNotification
        {
            get
            {
                return this.m_ExceededNotification;
            }
            set
            {
                this.m_ExceededNotification = value;
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
        
        public uint State
        {
            get
            {
                return this.m_State;
            }
            set
            {
                this.m_State = value;
            }
        }
        
        public string VolumePath
        {
            get
            {
                return this.m_VolumePath;
            }
            set
            {
                this.m_VolumePath = value;
            }
        }
        
        public bool WarningExceededNotification
        {
            get
            {
                return this.m_WarningExceededNotification;
            }
            set
            {
                this.m_WarningExceededNotification = value;
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
