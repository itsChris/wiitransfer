using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_ImplementedCategory : WMIBase
    {
        
        private string m_Category;
        
        private string m_Component;
        
        private string m_MyPath;
        
        public Win32_ImplementedCategory()
        {
        }
        
        public string Category
        {
            get
            {
                return this.m_Category;
            }
            set
            {
                this.m_Category = value;
            }
        }
        
        public string Component
        {
            get
            {
                return this.m_Component;
            }
            set
            {
                this.m_Component = value;
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
