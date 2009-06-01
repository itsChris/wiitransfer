using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_NETFramework_NETCLRExceptions : WMIBase
    {
        
        private string m_Caption;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private uint m_NumberofExcepsThrown;
        
        private uint m_NumberofExcepsThrownPersec;
        
        private ulong m_NumberofFiltersPersec;
        
        private ulong m_NumberofFinallysPersec;
        
        private uint m_ThrowToCatchDepthPersec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_NETFramework_NETCLRExceptions()
        {
        }
        
        public string Caption
        {
            get
            {
                return this.m_Caption;
            }
            set
            {
                this.m_Caption = value;
            }
        }
        
        public string Description
        {
            get
            {
                return this.m_Description;
            }
            set
            {
                this.m_Description = value;
            }
        }
        
        public ulong Frequency_Object
        {
            get
            {
                return this.m_Frequency_Object;
            }
            set
            {
                this.m_Frequency_Object = value;
            }
        }
        
        public ulong Frequency_PerfTime
        {
            get
            {
                return this.m_Frequency_PerfTime;
            }
            set
            {
                this.m_Frequency_PerfTime = value;
            }
        }
        
        public ulong Frequency_Sys100NS
        {
            get
            {
                return this.m_Frequency_Sys100NS;
            }
            set
            {
                this.m_Frequency_Sys100NS = value;
            }
        }
        
        public string Name
        {
            get
            {
                return this.m_Name;
            }
            set
            {
                this.m_Name = value;
            }
        }
        
        public uint NumberofExcepsThrown
        {
            get
            {
                return this.m_NumberofExcepsThrown;
            }
            set
            {
                this.m_NumberofExcepsThrown = value;
            }
        }
        
        public uint NumberofExcepsThrownPersec
        {
            get
            {
                return this.m_NumberofExcepsThrownPersec;
            }
            set
            {
                this.m_NumberofExcepsThrownPersec = value;
            }
        }
        
        public ulong NumberofFiltersPersec
        {
            get
            {
                return this.m_NumberofFiltersPersec;
            }
            set
            {
                this.m_NumberofFiltersPersec = value;
            }
        }
        
        public ulong NumberofFinallysPersec
        {
            get
            {
                return this.m_NumberofFinallysPersec;
            }
            set
            {
                this.m_NumberofFinallysPersec = value;
            }
        }
        
        public uint ThrowToCatchDepthPersec
        {
            get
            {
                return this.m_ThrowToCatchDepthPersec;
            }
            set
            {
                this.m_ThrowToCatchDepthPersec = value;
            }
        }
        
        public ulong Timestamp_Object
        {
            get
            {
                return this.m_Timestamp_Object;
            }
            set
            {
                this.m_Timestamp_Object = value;
            }
        }
        
        public ulong Timestamp_PerfTime
        {
            get
            {
                return this.m_Timestamp_PerfTime;
            }
            set
            {
                this.m_Timestamp_PerfTime = value;
            }
        }
        
        public ulong Timestamp_Sys100NS
        {
            get
            {
                return this.m_Timestamp_Sys100NS;
            }
            set
            {
                this.m_Timestamp_Sys100NS = value;
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
