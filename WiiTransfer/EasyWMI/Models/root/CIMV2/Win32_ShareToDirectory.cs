using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_ShareToDirectory : WMIBase
    {
        
        private string m_Share;
        
        private string m_SharedElement;
        
        private string m_MyPath;
        
        public Win32_ShareToDirectory()
        {
        }
        
        public string Share
        {
            get
            {
                return this.m_Share;
            }
            set
            {
                this.m_Share = value;
            }
        }
        
        public string SharedElement
        {
            get
            {
                return this.m_SharedElement;
            }
            set
            {
                this.m_SharedElement = value;
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
