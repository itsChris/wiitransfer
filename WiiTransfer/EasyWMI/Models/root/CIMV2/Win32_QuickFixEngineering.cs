using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_QuickFixEngineering : WMIBase
    {
        
        private string m_Caption;
        
        private string m_CSName;
        
        private string m_Description;
        
        private string m_FixComments;
        
        private string m_HotFixID;
        
        private string m_InstallDate;
        
        private string m_InstalledBy;
        
        private string m_InstalledOn;
        
        private string m_Name;
        
        private string m_ServicePackInEffect;
        
        private string m_Status;
        
        private string m_MyPath;
        
        public Win32_QuickFixEngineering()
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
        
        public string CSName
        {
            get
            {
                return this.m_CSName;
            }
            set
            {
                this.m_CSName = value;
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
        
        public string FixComments
        {
            get
            {
                return this.m_FixComments;
            }
            set
            {
                this.m_FixComments = value;
            }
        }
        
        public string HotFixID
        {
            get
            {
                return this.m_HotFixID;
            }
            set
            {
                this.m_HotFixID = value;
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
        
        public string InstalledBy
        {
            get
            {
                return this.m_InstalledBy;
            }
            set
            {
                this.m_InstalledBy = value;
            }
        }
        
        public string InstalledOn
        {
            get
            {
                return this.m_InstalledOn;
            }
            set
            {
                this.m_InstalledOn = value;
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
        
        public string ServicePackInEffect
        {
            get
            {
                return this.m_ServicePackInEffect;
            }
            set
            {
                this.m_ServicePackInEffect = value;
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
