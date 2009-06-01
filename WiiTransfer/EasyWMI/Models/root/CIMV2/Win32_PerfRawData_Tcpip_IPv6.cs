using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_Tcpip_IPv6 : WMIBase
    {
        
        private string m_Caption;
        
        private uint m_DatagramsForwardedPersec;
        
        private uint m_DatagramsOutboundDiscarded;
        
        private uint m_DatagramsOutboundNoRoute;
        
        private uint m_DatagramsPersec;
        
        private uint m_DatagramsReceivedAddressErrors;
        
        private uint m_DatagramsReceivedDeliveredPersec;
        
        private uint m_DatagramsReceivedDiscarded;
        
        private uint m_DatagramsReceivedHeaderErrors;
        
        private uint m_DatagramsReceivedPersec;
        
        private uint m_DatagramsReceivedUnknownProtocol;
        
        private uint m_DatagramsSentPersec;
        
        private string m_Description;
        
        private uint m_FragmentationFailures;
        
        private uint m_FragmentedDatagramsPersec;
        
        private uint m_FragmentReassemblyFailures;
        
        private uint m_FragmentsCreatedPersec;
        
        private uint m_FragmentsReassembledPersec;
        
        private uint m_FragmentsReceivedPersec;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_Tcpip_IPv6()
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
        
        public uint DatagramsForwardedPersec
        {
            get
            {
                return this.m_DatagramsForwardedPersec;
            }
            set
            {
                this.m_DatagramsForwardedPersec = value;
            }
        }
        
        public uint DatagramsOutboundDiscarded
        {
            get
            {
                return this.m_DatagramsOutboundDiscarded;
            }
            set
            {
                this.m_DatagramsOutboundDiscarded = value;
            }
        }
        
        public uint DatagramsOutboundNoRoute
        {
            get
            {
                return this.m_DatagramsOutboundNoRoute;
            }
            set
            {
                this.m_DatagramsOutboundNoRoute = value;
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
        
        public uint DatagramsReceivedAddressErrors
        {
            get
            {
                return this.m_DatagramsReceivedAddressErrors;
            }
            set
            {
                this.m_DatagramsReceivedAddressErrors = value;
            }
        }
        
        public uint DatagramsReceivedDeliveredPersec
        {
            get
            {
                return this.m_DatagramsReceivedDeliveredPersec;
            }
            set
            {
                this.m_DatagramsReceivedDeliveredPersec = value;
            }
        }
        
        public uint DatagramsReceivedDiscarded
        {
            get
            {
                return this.m_DatagramsReceivedDiscarded;
            }
            set
            {
                this.m_DatagramsReceivedDiscarded = value;
            }
        }
        
        public uint DatagramsReceivedHeaderErrors
        {
            get
            {
                return this.m_DatagramsReceivedHeaderErrors;
            }
            set
            {
                this.m_DatagramsReceivedHeaderErrors = value;
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
        
        public uint DatagramsReceivedUnknownProtocol
        {
            get
            {
                return this.m_DatagramsReceivedUnknownProtocol;
            }
            set
            {
                this.m_DatagramsReceivedUnknownProtocol = value;
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
        
        public uint FragmentationFailures
        {
            get
            {
                return this.m_FragmentationFailures;
            }
            set
            {
                this.m_FragmentationFailures = value;
            }
        }
        
        public uint FragmentedDatagramsPersec
        {
            get
            {
                return this.m_FragmentedDatagramsPersec;
            }
            set
            {
                this.m_FragmentedDatagramsPersec = value;
            }
        }
        
        public uint FragmentReassemblyFailures
        {
            get
            {
                return this.m_FragmentReassemblyFailures;
            }
            set
            {
                this.m_FragmentReassemblyFailures = value;
            }
        }
        
        public uint FragmentsCreatedPersec
        {
            get
            {
                return this.m_FragmentsCreatedPersec;
            }
            set
            {
                this.m_FragmentsCreatedPersec = value;
            }
        }
        
        public uint FragmentsReassembledPersec
        {
            get
            {
                return this.m_FragmentsReassembledPersec;
            }
            set
            {
                this.m_FragmentsReassembledPersec = value;
            }
        }
        
        public uint FragmentsReceivedPersec
        {
            get
            {
                return this.m_FragmentsReceivedPersec;
            }
            set
            {
                this.m_FragmentsReceivedPersec = value;
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
