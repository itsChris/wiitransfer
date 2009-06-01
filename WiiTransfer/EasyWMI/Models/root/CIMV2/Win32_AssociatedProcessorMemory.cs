using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_AssociatedProcessorMemory : WMIBase
    {
        
        private string m_Antecedent;
        
        private uint m_BusSpeed;
        
        private string m_Dependent;
        
        private string m_MyPath;
        
        public Win32_AssociatedProcessorMemory()
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
        
        public uint BusSpeed
        {
            get
            {
                return this.m_BusSpeed;
            }
            set
            {
                this.m_BusSpeed = value;
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
