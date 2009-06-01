using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_NETFramework_NETCLRInterop : WMIBase
    {
        
        private string m_Caption;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private uint m_NumberofCCWs;
        
        private uint m_Numberofmarshalling;
        
        private uint m_NumberofStubs;
        
        private uint m_NumberofTLBexportsPersec;
        
        private uint m_NumberofTLBimportsPersec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_NETFramework_NETCLRInterop()
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
        
        public uint NumberofCCWs
        {
            get
            {
                return this.m_NumberofCCWs;
            }
            set
            {
                this.m_NumberofCCWs = value;
            }
        }
        
        public uint Numberofmarshalling
        {
            get
            {
                return this.m_Numberofmarshalling;
            }
            set
            {
                this.m_Numberofmarshalling = value;
            }
        }
        
        public uint NumberofStubs
        {
            get
            {
                return this.m_NumberofStubs;
            }
            set
            {
                this.m_NumberofStubs = value;
            }
        }
        
        public uint NumberofTLBexportsPersec
        {
            get
            {
                return this.m_NumberofTLBexportsPersec;
            }
            set
            {
                this.m_NumberofTLBexportsPersec = value;
            }
        }
        
        public uint NumberofTLBimportsPersec
        {
            get
            {
                return this.m_NumberofTLBimportsPersec;
            }
            set
            {
                this.m_NumberofTLBimportsPersec = value;
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
