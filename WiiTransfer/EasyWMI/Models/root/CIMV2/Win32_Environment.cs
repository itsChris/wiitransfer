using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_Environment : WMIBase
    {
        
        private string m_Caption;
        
        private string m_Description;
        
        private string m_InstallDate;
        
        private string m_Name;
        
        private string m_Status;
        
        private bool m_SystemVariable;
        
        private string m_UserName;
        
        private string m_VariableValue;
        
        private string m_MyPath;
        
        public Win32_Environment()
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
        
        public bool SystemVariable
        {
            get
            {
                return this.m_SystemVariable;
            }
            set
            {
                this.m_SystemVariable = value;
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
        
        public string VariableValue
        {
            get
            {
                return this.m_VariableValue;
            }
            set
            {
                this.m_VariableValue = value;
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
