using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_ProductSoftwareFeatures : WMIBase
    {
        
        private string m_Component;
        
        private string m_Product;
        
        private string m_MyPath;
        
        public Win32_ProductSoftwareFeatures()
        {
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
        
        public string Product
        {
            get
            {
                return this.m_Product;
            }
            set
            {
                this.m_Product = value;
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
