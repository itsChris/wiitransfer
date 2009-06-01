using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_ComputerSystemProduct : WMIBase
    {
        
        private string m_Caption;
        
        private string m_Description;
        
        private string m_IdentifyingNumber;
        
        private string m_Name;
        
        private string m_SKUNumber;
        
        private string m_UUID;
        
        private string m_Vendor;
        
        private string m_Version;
        
        private string m_MyPath;
        
        public Win32_ComputerSystemProduct()
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
        
        public string IdentifyingNumber
        {
            get
            {
                return this.m_IdentifyingNumber;
            }
            set
            {
                this.m_IdentifyingNumber = value;
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
        
        public string SKUNumber
        {
            get
            {
                return this.m_SKUNumber;
            }
            set
            {
                this.m_SKUNumber = value;
            }
        }
        
        public string UUID
        {
            get
            {
                return this.m_UUID;
            }
            set
            {
                this.m_UUID = value;
            }
        }
        
        public string Vendor
        {
            get
            {
                return this.m_Vendor;
            }
            set
            {
                this.m_Vendor = value;
            }
        }
        
        public string Version
        {
            get
            {
                return this.m_Version;
            }
            set
            {
                this.m_Version = value;
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
