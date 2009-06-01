using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_NamedJobObjectStatistics : WMIBase
    {
        
        private string m_Collection;
        
        private string m_Stats;
        
        private string m_MyPath;
        
        public Win32_NamedJobObjectStatistics()
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
        
        public string Stats
        {
            get
            {
                return this.m_Stats;
            }
            set
            {
                this.m_Stats = value;
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
