using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_NTLogEventLog : WMIBase
    {
        
        private string m_Log;
        
        private string m_Record;
        
        private string m_MyPath;
        
        public Win32_NTLogEventLog()
        {
        }
        
        public string Log
        {
            get
            {
                return this.m_Log;
            }
            set
            {
                this.m_Log = value;
            }
        }
        
        public string Record
        {
            get
            {
                return this.m_Record;
            }
            set
            {
                this.m_Record = value;
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
