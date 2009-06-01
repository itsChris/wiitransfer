using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_Tcpip_UDPv4 : WMIBase
    {
        
        private string m_Caption;
        
        private uint m_DatagramsNoPortPersec;
        
        private uint m_DatagramsPersec;
        
        private uint m_DatagramsReceivedErrors;
        
        private uint m_DatagramsReceivedPersec;
        
        private uint m_DatagramsSentPersec;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_Tcpip_UDPv4()
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
        
        public uint DatagramsNoPortPersec
        {
            get
            {
                return this.m_DatagramsNoPortPersec;
            }
            set
            {
                this.m_DatagramsNoPortPersec = value;
            }
        }
        
        public uint DatagramsPersec
        {
            get
            {
                return this.m_DatagramsPersec;
            }
            set
            {
                this.m_DatagramsPersec = value;
            }
        }
        
        public uint DatagramsReceivedErrors
        {
            get
            {
                return this.m_DatagramsReceivedErrors;
            }
            set
            {
                this.m_DatagramsReceivedErrors = value;
            }
        }
        
        public uint DatagramsReceivedPersec
        {
            get
            {
                return this.m_DatagramsReceivedPersec;
            }
            set
            {
                this.m_DatagramsReceivedPersec = value;
            }
        }
        
        public uint DatagramsSentPersec
        {
            get
            {
                return this.m_DatagramsSentPersec;
            }
            set
            {
                this.m_DatagramsSentPersec = value;
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
