using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_LogonSession : WMIBase
    {
        
        private string m_AuthenticationPackage;
        
        private string m_Caption;
        
        private string m_Description;
        
        private string m_InstallDate;
        
        private string m_LogonId;
        
        private uint m_LogonType;
        
        private string m_Name;
        
        private string m_StartTime;
        
        private string m_Status;
        
        private string m_MyPath;
        
        public Win32_LogonSession()
        {
        }
        
        public string AuthenticationPackage
        {
            get
            {
                return this.m_AuthenticationPackage;
            }
            set
            {
                this.m_AuthenticationPackage = value;
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
        
        public string LogonId
        {
            get
            {
                return this.m_LogonId;
            }
            set
            {
                this.m_LogonId = value;
            }
        }
        
        public uint LogonType
        {
            get
            {
                return this.m_LogonType;
            }
            set
            {
                this.m_LogonType = value;
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
        
        public string StartTime
        {
            get
            {
                return this.m_StartTime;
            }
            set
            {
                this.m_StartTime = value;
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
