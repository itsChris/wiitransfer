using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_NETFramework_NETCLRRemoting : WMIBase
    {
        
        private string m_Caption;
        
        private uint m_Channels;
        
        private uint m_ContextBoundClassesLoaded;
        
        private ulong m_ContextBoundObjectsAllocPersec;
        
        private uint m_ContextProxies;
        
        private uint m_Contexts;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private ulong m_RemoteCallsPersec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_TotalRemoteCalls;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_NETFramework_NETCLRRemoting()
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
        
        public uint Channels
        {
            get
            {
                return this.m_Channels;
            }
            set
            {
                this.m_Channels = value;
            }
        }
        
        public uint ContextBoundClassesLoaded
        {
            get
            {
                return this.m_ContextBoundClassesLoaded;
            }
            set
            {
                this.m_ContextBoundClassesLoaded = value;
            }
        }
        
        public ulong ContextBoundObjectsAllocPersec
        {
            get
            {
                return this.m_ContextBoundObjectsAllocPersec;
            }
            set
            {
                this.m_ContextBoundObjectsAllocPersec = value;
            }
        }
        
        public uint ContextProxies
        {
            get
            {
                return this.m_ContextProxies;
            }
            set
            {
                this.m_ContextProxies = value;
            }
        }
        
        public uint Contexts
        {
            get
            {
                return this.m_Contexts;
            }
            set
            {
                this.m_Contexts = value;
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
        
        public ulong RemoteCallsPersec
        {
            get
            {
                return this.m_RemoteCallsPersec;
            }
            set
            {
                this.m_RemoteCallsPersec = value;
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
        
        public uint TotalRemoteCalls
        {
            get
            {
                return this.m_TotalRemoteCalls;
            }
            set
            {
                this.m_TotalRemoteCalls = value;
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
