using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_NETFramework_NETCLRJit : WMIBase
    {
        
        private string m_Caption;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_ILBytesJittedPersec;
        
        private string m_Name;
        
        private uint m_NumberofILBytesJitted;
        
        private uint m_NumberofMethodsJitted;
        
        private uint m_PercentTimeinJit;
        
        private uint m_PercentTimeinJit_Base;
        
        private uint m_StandardJitFailures;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_TotalNumberofILBytesJitted;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_NETFramework_NETCLRJit()
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
        
        public uint ILBytesJittedPersec
        {
            get
            {
                return this.m_ILBytesJittedPersec;
            }
            set
            {
                this.m_ILBytesJittedPersec = value;
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
        
        public uint NumberofILBytesJitted
        {
            get
            {
                return this.m_NumberofILBytesJitted;
            }
            set
            {
                this.m_NumberofILBytesJitted = value;
            }
        }
        
        public uint NumberofMethodsJitted
        {
            get
            {
                return this.m_NumberofMethodsJitted;
            }
            set
            {
                this.m_NumberofMethodsJitted = value;
            }
        }
        
        public uint PercentTimeinJit
        {
            get
            {
                return this.m_PercentTimeinJit;
            }
            set
            {
                this.m_PercentTimeinJit = value;
            }
        }
        
        public uint PercentTimeinJit_Base
        {
            get
            {
                return this.m_PercentTimeinJit_Base;
            }
            set
            {
                this.m_PercentTimeinJit_Base = value;
            }
        }
        
        public uint StandardJitFailures
        {
            get
            {
                return this.m_StandardJitFailures;
            }
            set
            {
                this.m_StandardJitFailures = value;
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
        
        public uint TotalNumberofILBytesJitted
        {
            get
            {
                return this.m_TotalNumberofILBytesJitted;
            }
            set
            {
                this.m_TotalNumberofILBytesJitted = value;
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
