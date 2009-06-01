using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_CIMLogicalDeviceCIMDataFile : WMIBase
    {
        
        private string m_Antecedent;
        
        private string m_Dependent;
        
        private ushort m_Purpose;
        
        private string m_PurposeDescription;
        
        private string m_MyPath;
        
        public Win32_CIMLogicalDeviceCIMDataFile()
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
        
        public ushort Purpose
        {
            get
            {
                return this.m_Purpose;
            }
            set
            {
                this.m_Purpose = value;
            }
        }
        
        public string PurposeDescription
        {
            get
            {
                return this.m_PurposeDescription;
            }
            set
            {
                this.m_PurposeDescription = value;
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
