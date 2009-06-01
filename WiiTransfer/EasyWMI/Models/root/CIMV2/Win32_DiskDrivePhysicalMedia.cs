using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_DiskDrivePhysicalMedia : WMIBase
    {
        
        private string m_Antecedent;
        
        private string m_Dependent;
        
        private string m_MyPath;
        
        public Win32_DiskDrivePhysicalMedia()
        {
        }
        
        public string Antecedent
        {
            get
            {
                return this.m_Antecedent;
            }
            set
            {
                this.m_Antecedent = value;
            }
        }
        
        public string Dependent
        {
            get
            {
                return this.m_Dependent;
            }
            set
            {
                this.m_Dependent = value;
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
