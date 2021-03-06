using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_NamedJobObjectLimit : WMIBase
    {
        
        private string m_Collection;
        
        private string m_Setting;
        
        private string m_MyPath;
        
        public Win32_NamedJobObjectLimit()
        {
        }
        
        public string Collection
        {
            get
            {
                return this.m_Collection;
            }
            set
            {
                this.m_Collection = value;
            }
        }
        
        public string Setting
        {
            get
            {
                return this.m_Setting;
            }
            set
            {
                this.m_Setting = value;
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
