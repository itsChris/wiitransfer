using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_Counters_IPsecDriver : WMIBase
    {
        
        private uint m_ActiveSecurityAssociations;
        
        private uint m_BytesReceivedinTransportModePersec;
        
        private uint m_BytesReceivedinTunnelModePersec;
        
        private uint m_BytesSentinTransportModePersec;
        
        private uint m_BytesSentinTunnelModePersec;
        
        private string m_Caption;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_IncorrectSPIPackets;
        
        private string m_Name;
        
        private uint m_OffloadedBytesReceivedPersec;
        
        private uint m_OffloadedBytesSentPersec;
        
        private uint m_OffloadedSecurityAssociations;
        
        private uint m_PacketsNotAuthenticated;
        
        private uint m_PacketsNotDecrypted;
        
        private uint m_PacketsReceivedOverWrongSA;
        
        private uint m_PacketsThatFailedESPValidation;
        
        private uint m_PacketsThatFailedReplayDetection;
        
        private uint m_PacketsThatFailedUDPESPValidation;
        
        private uint m_PendingSecurityAssociations;
        
        private uint m_PlaintextPacketsReceived;
        
        private uint m_SARekeys;
        
        private uint m_SecurityAssociationsAdded;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_Counters_IPsecDriver()
        {
        }
        
        public uint ActiveSecurityAssociations
        {
            get
            {
                return this.m_ActiveSecurityAssociations;
            }
            set
            {
                this.m_ActiveSecurityAssociations = value;
            }
        }
        
        public uint BytesReceivedinTransportModePersec
        {
            get
            {
                return this.m_BytesReceivedinTransportModePersec;
            }
            set
            {
                this.m_BytesReceivedinTransportModePersec = value;
            }
        }
        
        public uint BytesReceivedinTunnelModePersec
        {
            get
            {
                return this.m_BytesReceivedinTunnelModePersec;
            }
            set
            {
                this.m_BytesReceivedinTunnelModePersec = value;
            }
        }
        
        public uint BytesSentinTransportModePersec
        {
            get
            {
                return this.m_BytesSentinTransportModePersec;
            }
            set
            {
                this.m_BytesSentinTransportModePersec = value;
            }
        }
        
        public uint BytesSentinTunnelModePersec
        {
            get
            {
                return this.m_BytesSentinTunnelModePersec;
            }
            set
            {
                this.m_BytesSentinTunnelModePersec = value;
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
        
        public uint IncorrectSPIPackets
        {
            get
            {
                return this.m_IncorrectSPIPackets;
            }
            set
            {
                this.m_IncorrectSPIPackets = value;
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
        
        public uint OffloadedBytesReceivedPersec
        {
            get
            {
                return this.m_OffloadedBytesReceivedPersec;
            }
            set
            {
                this.m_OffloadedBytesReceivedPersec = value;
            }
        }
        
        public uint OffloadedBytesSentPersec
        {
            get
            {
                return this.m_OffloadedBytesSentPersec;
            }
            set
            {
                this.m_OffloadedBytesSentPersec = value;
            }
        }
        
        public uint OffloadedSecurityAssociations
        {
            get
            {
                return this.m_OffloadedSecurityAssociations;
            }
            set
            {
                this.m_OffloadedSecurityAssociations = value;
            }
        }
        
        public uint PacketsNotAuthenticated
        {
            get
            {
                return this.m_PacketsNotAuthenticated;
            }
            set
            {
                this.m_PacketsNotAuthenticated = value;
            }
        }
        
        public uint PacketsNotDecrypted
        {
            get
            {
                return this.m_PacketsNotDecrypted;
            }
            set
            {
                this.m_PacketsNotDecrypted = value;
            }
        }
        
        public uint PacketsReceivedOverWrongSA
        {
            get
            {
                return this.m_PacketsReceivedOverWrongSA;
            }
            set
            {
                this.m_PacketsReceivedOverWrongSA = value;
            }
        }
        
        public uint PacketsThatFailedESPValidation
        {
            get
            {
                return this.m_PacketsThatFailedESPValidation;
            }
            set
            {
                this.m_PacketsThatFailedESPValidation = value;
            }
        }
        
        public uint PacketsThatFailedReplayDetection
        {
            get
            {
                return this.m_PacketsThatFailedReplayDetection;
            }
            set
            {
                this.m_PacketsThatFailedReplayDetection = value;
            }
        }
        
        public uint PacketsThatFailedUDPESPValidation
        {
            get
            {
                return this.m_PacketsThatFailedUDPESPValidation;
            }
            set
            {
                this.m_PacketsThatFailedUDPESPValidation = value;
            }
        }
        
        public uint PendingSecurityAssociations
        {
            get
            {
                return this.m_PendingSecurityAssociations;
            }
            set
            {
                this.m_PendingSecurityAssociations = value;
            }
        }
        
        public uint PlaintextPacketsReceived
        {
            get
            {
                return this.m_PlaintextPacketsReceived;
            }
            set
            {
                this.m_PlaintextPacketsReceived = value;
            }
        }
        
        public uint SARekeys
        {
            get
            {
                return this.m_SARekeys;
            }
            set
            {
                this.m_SARekeys = value;
            }
        }
        
        public uint SecurityAssociationsAdded
        {
            get
            {
                return this.m_SecurityAssociationsAdded;
            }
            set
            {
                this.m_SecurityAssociationsAdded = value;
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
