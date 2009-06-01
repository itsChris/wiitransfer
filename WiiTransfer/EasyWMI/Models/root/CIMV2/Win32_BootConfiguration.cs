using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_BootConfiguration : WMIBase
    {
        
        private string m_BootDirectory;
        
        private string m_Caption;
        
        private string m_ConfigurationPath;
        
        private string m_Description;
        
        private string m_LastDrive;
        
        private string m_Name;
        
        private string m_ScratchDirectory;
        
        private string m_SettingID;
        
        private string m_TempDirectory;
        
        private string m_MyPath;
        
        public Win32_BootConfiguration()
        {
        }
        
        public string BootDirectory
        {
            get
            {
                return this.m_BootDirectory;
            }
            set
            {
                this.m_BootDirectory = value;
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
        
        public string ConfigurationPath
        {
            get
            {
                return this.m_ConfigurationPath;
            }
            set
            {
                this.m_ConfigurationPath = value;
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
        
        public string LastDrive
        {
            get
            {
                return this.m_LastDrive;
            }
            set
            {
                this.m_LastDrive = value;
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
        
        public string ScratchDirectory
        {
            get
            {
                return this.m_ScratchDirectory;
            }
            set
            {
                this.m_ScratchDirectory = value;
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
        
        public string TempDirectory
        {
            get
            {
                return this.m_TempDirectory;
            }
            set
            {
                this.m_TempDirectory = value;
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
