using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PhysicalMemoryLocation : WMIBase
    {
        
        private string m_GroupComponent;
        
        private string m_LocationWithinContainer;
        
        private string m_PartComponent;
        
        private string m_MyPath;
        
        public Win32_PhysicalMemoryLocation()
        {
        }
        
        public string GroupComponent
        {
            get
            {
                return this.m_GroupComponent;
            }
            set
            {
                this.m_GroupComponent = value;
            }
        }
        
        public string LocationWithinContainer
        {
            get
            {
                return this.m_LocationWithinContainer;
            }
            set
            {
                this.m_LocationWithinContainer = value;
            }
        }
        
        public string PartComponent
        {
            get
            {
                return this.m_PartComponent;
            }
            set
            {
                this.m_PartComponent = value;
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
