using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_LoadOrderGroup : WMIBase
    {
        
        private string m_Caption;
        
        private string m_Description;
        
        private bool m_DriverEnabled;
        
        private uint m_GroupOrder;
        
        private string m_InstallDate;
        
        private string m_Name;
        
        private string m_Status;
        
        private string m_MyPath;
        
        public Win32_LoadOrderGroup()
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
        
        public bool DriverEnabled
        {
            get
            {
                return this.m_DriverEnabled;
            }
            set
            {
                this.m_DriverEnabled = value;
            }
        }
        
        public uint GroupOrder
        {
            get
            {
                return this.m_GroupOrder;
            }
            set
            {
                this.m_GroupOrder = value;
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
