using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_PerfNet_Server : WMIBase
    {
        
        private uint m_BlockingRequestsRejected;
        
        private ulong m_BytesReceivedPersec;
        
        private ulong m_BytesTotalPersec;
        
        private ulong m_BytesTransmittedPersec;
        
        private string m_Caption;
        
        private uint m_ContextBlocksQueuedPersec;
        
        private string m_Description;
        
        private uint m_ErrorsAccessPermissions;
        
        private uint m_ErrorsGrantedAccess;
        
        private uint m_ErrorsLogon;
        
        private uint m_ErrorsSystem;
        
        private uint m_FileDirectorySearches;
        
        private uint m_FilesOpen;
        
        private uint m_FilesOpenedTotal;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_LogonPersec;
        
        private uint m_LogonTotal;
        
        private string m_Name;
        
        private uint m_PoolNonpagedBytes;
        
        private uint m_PoolNonpagedFailures;
        
        private uint m_PoolNonpagedPeak;
        
        private uint m_PoolPagedBytes;
        
        private uint m_PoolPagedFailures;
        
        private uint m_PoolPagedPeak;
        
        private uint m_ServerSessions;
        
        private uint m_SessionsErroredOut;
        
        private uint m_SessionsForcedOff;
        
        private uint m_SessionsLoggedOff;
        
        private uint m_SessionsTimedOut;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_WorkItemShortages;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_PerfNet_Server()
        {
        }
        
        public uint BlockingRequestsRejected
        {
            get
            {
                return this.m_BlockingRequestsRejected;
            }
            set
            {
                this.m_BlockingRequestsRejected = value;
            }
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
        
        public uint ContextBlocksQueuedPersec
        {
            get
            {
                return this.m_ContextBlocksQueuedPersec;
            }
            set
            {
                this.m_ContextBlocksQueuedPersec = value;
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
        
        public uint ErrorsAccessPermissions
        {
            get
            {
                return this.m_ErrorsAccessPermissions;
            }
            set
            {
                this.m_ErrorsAccessPermissions = value;
            }
        }
        
        public uint ErrorsGrantedAccess
        {
            get
            {
                return this.m_ErrorsGrantedAccess;
            }
            set
            {
                this.m_ErrorsGrantedAccess = value;
            }
        }
        
        public uint ErrorsLogon
        {
            get
            {
                return this.m_ErrorsLogon;
            }
            set
            {
                this.m_ErrorsLogon = value;
            }
        }
        
        public uint ErrorsSystem
        {
            get
            {
                return this.m_ErrorsSystem;
            }
            set
            {
                this.m_ErrorsSystem = value;
            }
        }
        
        public uint FileDirectorySearches
        {
            get
            {
                return this.m_FileDirectorySearches;
            }
            set
            {
                this.m_FileDirectorySearches = value;
            }
        }
        
        public uint FilesOpen
        {
            get
            {
                return this.m_FilesOpen;
            }
            set
            {
                this.m_FilesOpen = value;
            }
        }
        
        public uint FilesOpenedTotal
        {
            get
            {
                return this.m_FilesOpenedTotal;
            }
            set
            {
                this.m_FilesOpenedTotal = value;
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
        
        public uint LogonPersec
        {
            get
            {
                return this.m_LogonPersec;
            }
            set
            {
                this.m_LogonPersec = value;
            }
        }
        
        public uint LogonTotal
        {
            get
            {
                return this.m_LogonTotal;
            }
            set
            {
                this.m_LogonTotal = value;
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
        
        public uint PoolNonpagedBytes
        {
            get
            {
                return this.m_PoolNonpagedBytes;
            }
            set
            {
                this.m_PoolNonpagedBytes = value;
            }
        }
        
        public uint PoolNonpagedFailures
        {
            get
            {
                return this.m_PoolNonpagedFailures;
            }
            set
            {
                this.m_PoolNonpagedFailures = value;
            }
        }
        
        public uint PoolNonpagedPeak
        {
            get
            {
                return this.m_PoolNonpagedPeak;
            }
            set
            {
                this.m_PoolNonpagedPeak = value;
            }
        }
        
        public uint PoolPagedBytes
        {
            get
            {
                return this.m_PoolPagedBytes;
            }
            set
            {
                this.m_PoolPagedBytes = value;
            }
        }
        
        public uint PoolPagedFailures
        {
            get
            {
                return this.m_PoolPagedFailures;
            }
            set
            {
                this.m_PoolPagedFailures = value;
            }
        }
        
        public uint PoolPagedPeak
        {
            get
            {
                return this.m_PoolPagedPeak;
            }
            set
            {
                this.m_PoolPagedPeak = value;
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
        
        public uint SessionsErroredOut
        {
            get
            {
                return this.m_SessionsErroredOut;
            }
            set
            {
                this.m_SessionsErroredOut = value;
            }
        }
        
        public uint SessionsForcedOff
        {
            get
            {
                return this.m_SessionsForcedOff;
            }
            set
            {
                this.m_SessionsForcedOff = value;
            }
        }
        
        public uint SessionsLoggedOff
        {
            get
            {
                return this.m_SessionsLoggedOff;
            }
            set
            {
                this.m_SessionsLoggedOff = value;
            }
        }
        
        public uint SessionsTimedOut
        {
            get
            {
                return this.m_SessionsTimedOut;
            }
            set
            {
                this.m_SessionsTimedOut = value;
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
        
        public uint WorkItemShortages
        {
            get
            {
                return this.m_WorkItemShortages;
            }
            set
            {
                this.m_WorkItemShortages = value;
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
