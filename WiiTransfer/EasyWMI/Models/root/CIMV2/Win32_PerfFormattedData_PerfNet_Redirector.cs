using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_PerfNet_Redirector : WMIBase
    {
        
        private ulong m_BytesReceivedPersec;
        
        private ulong m_BytesTotalPersec;
        
        private ulong m_BytesTransmittedPersec;
        
        private string m_Caption;
        
        private uint m_ConnectsCore;
        
        private uint m_ConnectsLanManager20;
        
        private uint m_ConnectsLanManager21;
        
        private uint m_ConnectsWindowsNT;
        
        private uint m_CurrentCommands;
        
        private string m_Description;
        
        private uint m_FileDataOperationsPersec;
        
        private uint m_FileReadOperationsPersec;
        
        private uint m_FileWriteOperationsPersec;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private uint m_NetworkErrorsPersec;
        
        private ulong m_PacketsPersec;
        
        private ulong m_PacketsReceivedPersec;
        
        private ulong m_PacketsTransmittedPersec;
        
        private ulong m_ReadBytesCachePersec;
        
        private ulong m_ReadBytesNetworkPersec;
        
        private ulong m_ReadBytesNonPagingPersec;
        
        private ulong m_ReadBytesPagingPersec;
        
        private uint m_ReadOperationsRandomPersec;
        
        private uint m_ReadPacketsPersec;
        
        private uint m_ReadPacketsSmallPersec;
        
        private uint m_ReadsDeniedPersec;
        
        private uint m_ReadsLargePersec;
        
        private uint m_ServerDisconnects;
        
        private uint m_ServerReconnects;
        
        private uint m_ServerSessions;
        
        private uint m_ServerSessionsHung;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private ulong m_WriteBytesCachePersec;
        
        private ulong m_WriteBytesNetworkPersec;
        
        private ulong m_WriteBytesNonPagingPersec;
        
        private ulong m_WriteBytesPagingPersec;
        
        private uint m_WriteOperationsRandomPersec;
        
        private uint m_WritePacketsPersec;
        
        private uint m_WritePacketsSmallPersec;
        
        private uint m_WritesDeniedPersec;
        
        private uint m_WritesLargePersec;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_PerfNet_Redirector()
        {
        }
        
        public ulong BytesReceivedPersec
        {
            get
            {
                return this.m_BytesReceivedPersec;
            }
            set
            {
                this.m_BytesReceivedPersec = value;
            }
        }
        
        public ulong BytesTotalPersec
        {
            get
            {
                return this.m_BytesTotalPersec;
            }
            set
            {
                this.m_BytesTotalPersec = value;
            }
        }
        
        public ulong BytesTransmittedPersec
        {
            get
            {
                return this.m_BytesTransmittedPersec;
            }
            set
            {
                this.m_BytesTransmittedPersec = value;
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
        
        public uint ConnectsCore
        {
            get
            {
                return this.m_ConnectsCore;
            }
            set
            {
                this.m_ConnectsCore = value;
            }
        }
        
        public uint ConnectsLanManager20
        {
            get
            {
                return this.m_ConnectsLanManager20;
            }
            set
            {
                this.m_ConnectsLanManager20 = value;
            }
        }
        
        public uint ConnectsLanManager21
        {
            get
            {
                return this.m_ConnectsLanManager21;
            }
            set
            {
                this.m_ConnectsLanManager21 = value;
            }
        }
        
        public uint ConnectsWindowsNT
        {
            get
            {
                return this.m_ConnectsWindowsNT;
            }
            set
            {
                this.m_ConnectsWindowsNT = value;
            }
        }
        
        public uint CurrentCommands
        {
            get
            {
                return this.m_CurrentCommands;
            }
            set
            {
                this.m_CurrentCommands = value;
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
        
        public uint FileDataOperationsPersec
        {
            get
            {
                return this.m_FileDataOperationsPersec;
            }
            set
            {
                this.m_FileDataOperationsPersec = value;
            }
        }
        
        public uint FileReadOperationsPersec
        {
            get
            {
                return this.m_FileReadOperationsPersec;
            }
            set
            {
                this.m_FileReadOperationsPersec = value;
            }
        }
        
        public uint FileWriteOperationsPersec
        {
            get
            {
                return this.m_FileWriteOperationsPersec;
            }
            set
            {
                this.m_FileWriteOperationsPersec = value;
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
        
        public uint NetworkErrorsPersec
        {
            get
            {
                return this.m_NetworkErrorsPersec;
            }
            set
            {
                this.m_NetworkErrorsPersec = value;
            }
        }
        
        public ulong PacketsPersec
        {
            get
            {
                return this.m_PacketsPersec;
            }
            set
            {
                this.m_PacketsPersec = value;
            }
        }
        
        public ulong PacketsReceivedPersec
        {
            get
            {
                return this.m_PacketsReceivedPersec;
            }
            set
            {
                this.m_PacketsReceivedPersec = value;
            }
        }
        
        public ulong PacketsTransmittedPersec
        {
            get
            {
                return this.m_PacketsTransmittedPersec;
            }
            set
            {
                this.m_PacketsTransmittedPersec = value;
            }
        }
        
        public ulong ReadBytesCachePersec
        {
            get
            {
                return this.m_ReadBytesCachePersec;
            }
            set
            {
                this.m_ReadBytesCachePersec = value;
            }
        }
        
        public ulong ReadBytesNetworkPersec
        {
            get
            {
                return this.m_ReadBytesNetworkPersec;
            }
            set
            {
                this.m_ReadBytesNetworkPersec = value;
            }
        }
        
        public ulong ReadBytesNonPagingPersec
        {
            get
            {
                return this.m_ReadBytesNonPagingPersec;
            }
            set
            {
                this.m_ReadBytesNonPagingPersec = value;
            }
        }
        
        public ulong ReadBytesPagingPersec
        {
            get
            {
                return this.m_ReadBytesPagingPersec;
            }
            set
            {
                this.m_ReadBytesPagingPersec = value;
            }
        }
        
        public uint ReadOperationsRandomPersec
        {
            get
            {
                return this.m_ReadOperationsRandomPersec;
            }
            set
            {
                this.m_ReadOperationsRandomPersec = value;
            }
        }
        
        public uint ReadPacketsPersec
        {
            get
            {
                return this.m_ReadPacketsPersec;
            }
            set
            {
                this.m_ReadPacketsPersec = value;
            }
        }
        
        public uint ReadPacketsSmallPersec
        {
            get
            {
                return this.m_ReadPacketsSmallPersec;
            }
            set
            {
                this.m_ReadPacketsSmallPersec = value;
            }
        }
        
        public uint ReadsDeniedPersec
        {
            get
            {
                return this.m_ReadsDeniedPersec;
            }
            set
            {
                this.m_ReadsDeniedPersec = value;
            }
        }
        
        public uint ReadsLargePersec
        {
            get
            {
                return this.m_ReadsLargePersec;
            }
            set
            {
                this.m_ReadsLargePersec = value;
            }
        }
        
        public uint ServerDisconnects
        {
            get
            {
                return this.m_ServerDisconnects;
            }
            set
            {
                this.m_ServerDisconnects = value;
            }
        }
        
        public uint ServerReconnects
        {
            get
            {
                return this.m_ServerReconnects;
            }
            set
            {
                this.m_ServerReconnects = value;
            }
        }
        
        public uint ServerSessions
        {
            get
            {
                return this.m_ServerSessions;
            }
            set
            {
                this.m_ServerSessions = value;
            }
        }
        
        public uint ServerSessionsHung
        {
            get
            {
                return this.m_ServerSessionsHung;
            }
            set
            {
                this.m_ServerSessionsHung = value;
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
        
        public ulong WriteBytesCachePersec
        {
            get
            {
                return this.m_WriteBytesCachePersec;
            }
            set
            {
                this.m_WriteBytesCachePersec = value;
            }
        }
        
        public ulong WriteBytesNetworkPersec
        {
            get
            {
                return this.m_WriteBytesNetworkPersec;
            }
            set
            {
                this.m_WriteBytesNetworkPersec = value;
            }
        }
        
        public ulong WriteBytesNonPagingPersec
        {
            get
            {
                return this.m_WriteBytesNonPagingPersec;
            }
            set
            {
                this.m_WriteBytesNonPagingPersec = value;
            }
        }
        
        public ulong WriteBytesPagingPersec
        {
            get
            {
                return this.m_WriteBytesPagingPersec;
            }
            set
            {
                this.m_WriteBytesPagingPersec = value;
            }
        }
        
        public uint WriteOperationsRandomPersec
        {
            get
            {
                return this.m_WriteOperationsRandomPersec;
            }
            set
            {
                this.m_WriteOperationsRandomPersec = value;
            }
        }
        
        public uint WritePacketsPersec
        {
            get
            {
                return this.m_WritePacketsPersec;
            }
            set
            {
                this.m_WritePacketsPersec = value;
            }
        }
        
        public uint WritePacketsSmallPersec
        {
            get
            {
                return this.m_WritePacketsSmallPersec;
            }
            set
            {
                this.m_WritePacketsSmallPersec = value;
            }
        }
        
        public uint WritesDeniedPersec
        {
            get
            {
                return this.m_WritesDeniedPersec;
            }
            set
            {
                this.m_WritesDeniedPersec = value;
            }
        }
        
        public uint WritesLargePersec
        {
            get
            {
                return this.m_WritesLargePersec;
            }
            set
            {
                this.m_WritesLargePersec = value;
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
