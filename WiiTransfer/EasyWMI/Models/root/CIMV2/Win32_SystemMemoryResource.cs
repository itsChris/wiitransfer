using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_SystemMemoryResource : WMIBase
    {
        
        private string m_Caption;
        
        private string m_CreationClassName;
        
        private string m_CSCreationClassName;
        
        private string m_CSName;
        
        private string m_Description;
        
        private ulong m_EndingAddress;
        
        private string m_InstallDate;
        
        private string m_MemoryType;
        
        private string m_Name;
        
        private ulong m_StartingAddress;
        
        private string m_Status;
        
        private string m_MyPath;
        
        public Win32_SystemMemoryResource()
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
        
        public string CreationClassName
        {
            get
            {
                return this.m_CreationClassName;
            }
            set
            {
                this.m_CreationClassName = value;
            }
        }
        
        public string CSCreationClassName
        {
            get
            {
                return this.m_CSCreationClassName;
            }
            set
            {
                this.m_CSCreationClassName = value;
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
        
        public ulong EndingAddress
        {
            get
            {
                return this.m_EndingAddress;
            }
            set
            {
                this.m_EndingAddress = value;
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
        
        public string MemoryType
        {
            get
            {
                return this.m_MemoryType;
            }
            set
            {
                this.m_MemoryType = value;
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
        
        public ulong StartingAddress
        {
            get
            {
                return this.m_StartingAddress;
            }
            set
            {
                this.m_StartingAddress = value;
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
