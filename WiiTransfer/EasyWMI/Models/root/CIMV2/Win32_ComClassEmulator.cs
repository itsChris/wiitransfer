using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_ComClassEmulator : WMIBase
    {
        
        private string m_NewVersion;
        
        private string m_OldVersion;
        
        private string m_MyPath;
        
        public Win32_ComClassEmulator()
        {
        }
        
        public string NewVersion
        {
            get
            {
                return this.m_NewVersion;
            }
            set
            {
                this.m_NewVersion = value;
            }
        }
        
        public string OldVersion
        {
            get
            {
                return this.m_OldVersion;
            }
            set
            {
                this.m_OldVersion = value;
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
