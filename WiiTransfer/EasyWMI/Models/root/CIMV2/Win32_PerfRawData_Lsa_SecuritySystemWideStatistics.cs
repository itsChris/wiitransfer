using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_Lsa_SecuritySystemWideStatistics : WMIBase
    {
        
        private uint m_ActiveSchannelSessionCacheEntries;
        
        private string m_Caption;
        
        private string m_Description;
        
        private uint m_DigestAuthentications;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_KDCASRequests;
        
        private uint m_KDCTGSRequests;
        
        private uint m_KerberosAuthentications;
        
        private string m_Name;
        
        private uint m_NTLMAuthentications;
        
        private uint m_SchannelSessionCacheEntries;
        
        private uint m_SSLClientSideFullHandshakes;
        
        private uint m_SSLClientSideReconnectHandshakes;
        
        private uint m_SSLServerSideFullHandshakes;
        
        private uint m_SSLServerSideReconnectHandshakes;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_Lsa_SecuritySystemWideStatistics()
        {
        }
        
        public uint ActiveSchannelSessionCacheEntries
        {
            get
            {
                return this.m_ActiveSchannelSessionCacheEntries;
            }
            set
            {
                this.m_ActiveSchannelSessionCacheEntries = value;
            }
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
        
        public uint DigestAuthentications
        {
            get
            {
                return this.m_DigestAuthentications;
            }
            set
            {
                this.m_DigestAuthentications = value;
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
        
        public uint KDCASRequests
        {
            get
            {
                return this.m_KDCASRequests;
            }
            set
            {
                this.m_KDCASRequests = value;
            }
        }
        
        public uint KDCTGSRequests
        {
            get
            {
                return this.m_KDCTGSRequests;
            }
            set
            {
                this.m_KDCTGSRequests = value;
            }
        }
        
        public uint KerberosAuthentications
        {
            get
            {
                return this.m_KerberosAuthentications;
            }
            set
            {
                this.m_KerberosAuthentications = value;
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
        
        public uint NTLMAuthentications
        {
            get
            {
                return this.m_NTLMAuthentications;
            }
            set
            {
                this.m_NTLMAuthentications = value;
            }
        }
        
        public uint SchannelSessionCacheEntries
        {
            get
            {
                return this.m_SchannelSessionCacheEntries;
            }
            set
            {
                this.m_SchannelSessionCacheEntries = value;
            }
        }
        
        public uint SSLClientSideFullHandshakes
        {
            get
            {
                return this.m_SSLClientSideFullHandshakes;
            }
            set
            {
                this.m_SSLClientSideFullHandshakes = value;
            }
        }
        
        public uint SSLClientSideReconnectHandshakes
        {
            get
            {
                return this.m_SSLClientSideReconnectHandshakes;
            }
            set
            {
                this.m_SSLClientSideReconnectHandshakes = value;
            }
        }
        
        public uint SSLServerSideFullHandshakes
        {
            get
            {
                return this.m_SSLServerSideFullHandshakes;
            }
            set
            {
                this.m_SSLServerSideFullHandshakes = value;
            }
        }
        
        public uint SSLServerSideReconnectHandshakes
        {
            get
            {
                return this.m_SSLServerSideReconnectHandshakes;
            }
            set
            {
                this.m_SSLServerSideReconnectHandshakes = value;
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
