using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_StartupCommand : WMIBase
    {
        
        private string m_Caption;
        
        private string m_Command;
        
        private string m_Description;
        
        private string m_Location;
        
        private string m_Name;
        
        private string m_SettingID;
        
        private string m_User;
        
        private string m_UserSID;
        
        private string m_MyPath;
        
        public Win32_StartupCommand()
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
        
        public string Command
        {
            get
            {
                return this.m_Command;
            }
            set
            {
                this.m_Command = value;
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
        
        public string Location
        {
            get
            {
                return this.m_Location;
            }
            set
            {
                this.m_Location = value;
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
        
        public string User
        {
            get
            {
                return this.m_User;
            }
            set
            {
                this.m_User = value;
            }
        }
        
        public string UserSID
        {
            get
            {
                return this.m_UserSID;
            }
            set
            {
                this.m_UserSID = value;
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
