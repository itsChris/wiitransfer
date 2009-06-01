using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_NETCLRNetworking_NETCLRNetworking : WMIBase
    {
        
        private ulong m_BytesReceived;
        
        private ulong m_BytesSent;
        
        private string m_Caption;
        
        private uint m_ConnectionsEstablished;
        
        private uint m_DatagramsReceived;
        
        private uint m_DatagramsSent;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_NETCLRNetworking_NETCLRNetworking()
        {
        }
        
        public ulong BytesReceived
        {
            get
            {
                return this.m_BytesReceived;
            }
            set
            {
                this.m_BytesReceived = value;
            }
        }
        
        public ulong BytesSent
        {
            get
            {
                return this.m_BytesSent;
            }
            set
            {
                this.m_BytesSent = value;
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
        
        public uint ConnectionsEstablished
        {
            get
            {
                return this.m_ConnectionsEstablished;
            }
            set
            {
                this.m_ConnectionsEstablished = value;
            }
        }
        
        public uint DatagramsReceived
        {
            get
            {
                return this.m_DatagramsReceived;
            }
            set
            {
                this.m_DatagramsReceived = value;
            }
        }
        
        public uint DatagramsSent
        {
            get
            {
                return this.m_DatagramsSent;
            }
            set
            {
                this.m_DatagramsSent = value;
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
