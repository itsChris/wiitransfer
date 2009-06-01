using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_DependentService : WMIBase
    {
        
        private string m_Antecedent;
        
        private string m_Dependent;
        
        private ushort m_TypeOfDependency;
        
        private string m_MyPath;
        
        public Win32_DependentService()
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
        
        public ushort TypeOfDependency
        {
            get
            {
                return this.m_TypeOfDependency;
            }
            set
            {
                this.m_TypeOfDependency = value;
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
