using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_NamedJobObjectProcess : WMIBase
    {
        
        private string m_Collection;
        
        private string m_Member;
        
        private string m_MyPath;
        
        public Win32_NamedJobObjectProcess()
        {
        }
        
        public string Collection
        {
            get
            {
                return this.m_Collection;
            }
            set
            {
                this.m_Collection = value;
            }
        }
        
        public string Member
        {
            get
            {
                return this.m_Member;
            }
            set
            {
                this.m_Member = value;
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
