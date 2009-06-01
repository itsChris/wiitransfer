using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_MountPoint : WMIBase
    {
        
        private string m_Directory;
        
        private string m_Volume;
        
        private string m_MyPath;
        
        public Win32_MountPoint()
        {
        }
        
        public string Directory
        {
            get
            {
                return this.m_Directory;
            }
            set
            {
                this.m_Directory = value;
            }
        }
        
        public string Volume
        {
            get
            {
                return this.m_Volume;
            }
            set
            {
                this.m_Volume = value;
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
