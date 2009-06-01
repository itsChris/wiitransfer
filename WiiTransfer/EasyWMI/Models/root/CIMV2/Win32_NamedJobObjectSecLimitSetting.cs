using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_NamedJobObjectSecLimitSetting : WMIBase
    {
        
        private string m_Caption;
        
        private string m_Description;
        
        private object m_PrivilegesToDelete;
        
        private object m_RestrictedSIDs;
        
        private uint m_SecurityLimitFlags;
        
        private string m_SettingID;
        
        private object m_SIDsToDisable;
        
        private string m_MyPath;
        
        public Win32_NamedJobObjectSecLimitSetting()
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
        
        public object PrivilegesToDelete
        {
            get
            {
                return this.m_PrivilegesToDelete;
            }
            set
            {
                this.m_PrivilegesToDelete = value;
            }
        }
        
        public object RestrictedSIDs
        {
            get
            {
                return this.m_RestrictedSIDs;
            }
            set
            {
                this.m_RestrictedSIDs = value;
            }
        }
        
        public uint SecurityLimitFlags
        {
            get
            {
                return this.m_SecurityLimitFlags;
            }
            set
            {
                this.m_SecurityLimitFlags = value;
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
        
        public object SIDsToDisable
        {
            get
            {
                return this.m_SIDsToDisable;
            }
            set
            {
                this.m_SIDsToDisable = value;
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
