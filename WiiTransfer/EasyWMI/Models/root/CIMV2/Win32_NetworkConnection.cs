using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_NetworkConnection : WMIBase
    {
        
        private uint m_AccessMask;
        
        private string m_Caption;
        
        private string m_Comment;
        
        private string m_ConnectionState;
        
        private string m_ConnectionType;
        
        private string m_Description;
        
        private string m_DisplayType;
        
        private string m_InstallDate;
        
        private string m_LocalName;
        
        private string m_Name;
        
        private bool m_Persistent;
        
        private string m_ProviderName;
        
        private string m_RemoteName;
        
        private string m_RemotePath;
        
        private string m_ResourceType;
        
        private string m_Status;
        
        private string m_UserName;
        
        private string m_MyPath;
        
        public Win32_NetworkConnection()
        {
        }
        
        public uint AccessMask
        {
            get
            {
                return this.m_AccessMask;
            }
            set
            {
                this.m_AccessMask = value;
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
        
        public string Comment
        {
            get
            {
                return this.m_Comment;
            }
            set
            {
                this.m_Comment = value;
            }
        }
        
        public string ConnectionState
        {
            get
            {
                return this.m_ConnectionState;
            }
            set
            {
                this.m_ConnectionState = value;
            }
        }
        
        public string ConnectionType
        {
            get
            {
                return this.m_ConnectionType;
            }
            set
            {
                this.m_ConnectionType = value;
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
        
        public string DisplayType
        {
            get
            {
                return this.m_DisplayType;
            }
            set
            {
                this.m_DisplayType = value;
            }
        }
        
        public string InstallDate
        {
            get
            {
                return this.m_InstallDate;
            }
            set
            {
                this.m_InstallDate = value;
            }
        }
        
        public string LocalName
        {
            get
            {
                return this.m_LocalName;
            }
            set
            {
                this.m_LocalName = value;
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
        
        public string ProviderName
        {
            get
            {
                return this.m_ProviderName;
            }
            set
            {
                this.m_ProviderName = value;
            }
        }
        
        public string RemoteName
        {
            get
            {
                return this.m_RemoteName;
            }
            set
            {
                this.m_RemoteName = value;
            }
        }
        
        public string RemotePath
        {
            get
            {
                return this.m_RemotePath;
            }
            set
            {
                this.m_RemotePath = value;
            }
        }
        
        public string ResourceType
        {
            get
            {
                return this.m_ResourceType;
            }
            set
            {
                this.m_ResourceType = value;
            }
        }
        
        public string Status
        {
            get
            {
                return this.m_Status;
            }
            set
            {
                this.m_Status = value;
            }
        }
        
        public string UserName
        {
            get
            {
                return this.m_UserName;
            }
            set
            {
                this.m_UserName = value;
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
