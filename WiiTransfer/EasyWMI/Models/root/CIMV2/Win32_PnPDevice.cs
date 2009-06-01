using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PnPDevice : WMIBase
    {
        
        private string m_SameElement;
        
        private string m_SystemElement;
        
        private string m_MyPath;
        
        public Win32_PnPDevice()
        {
        }
        
        public string SameElement
        {
            get
            {
                return this.m_SameElement;
            }
            set
            {
                this.m_SameElement = value;
            }
        }
        
        public string SystemElement
        {
            get
            {
                return this.m_SystemElement;
            }
            set
            {
                this.m_SystemElement = value;
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
