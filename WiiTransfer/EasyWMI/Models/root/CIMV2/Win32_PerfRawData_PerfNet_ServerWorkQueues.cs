using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_PerfNet_ServerWorkQueues : WMIBase
    {
        
        private uint m_ActiveThreads;
        
        private uint m_AvailableThreads;
        
        private uint m_AvailableWorkItems;
        
        private uint m_BorrowedWorkItems;
        
        private ulong m_BytesReceivedPersec;
        
        private ulong m_BytesSentPersec;
        
        private ulong m_BytesTransferredPersec;
        
        private string m_Caption;
        
        private uint m_ContextBlocksQueuedPersec;
        
        private uint m_CurrentClients;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private uint m_QueueLength;
        
        private ulong m_ReadBytesPersec;
        
        private ulong m_ReadOperationsPersec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private ulong m_TotalBytesPersec;
        
        private ulong m_TotalOperationsPersec;
        
        private uint m_WorkItemShortages;
        
        private ulong m_WriteBytesPersec;
        
        private ulong m_WriteOperationsPersec;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_PerfNet_ServerWorkQueues()
        {
        }
        
        public uint ActiveThreads
        {
            get
            {
                return this.m_ActiveThreads;
            }
            set
            {
                this.m_ActiveThreads = value;
            }
        }
        
        public uint AvailableThreads
        {
            get
            {
                return this.m_AvailableThreads;
            }
            set
            {
                this.m_AvailableThreads = value;
            }
        }
        
        public uint AvailableWorkItems
        {
            get
            {
                return this.m_AvailableWorkItems;
            }
            set
            {
                this.m_AvailableWorkItems = value;
            }
        }
        
        public uint BorrowedWorkItems
        {
            get
            {
                return this.m_BorrowedWorkItems;
            }
            set
            {
                this.m_BorrowedWorkItems = value;
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
        
        public ulong BytesSentPersec
        {
            get
            {
                return this.m_BytesSentPersec;
            }
            set
            {
                this.m_BytesSentPersec = value;
            }
        }
        
        public ulong BytesTransferredPersec
        {
            get
            {
                return this.m_BytesTransferredPersec;
            }
            set
            {
                this.m_BytesTransferredPersec = value;
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
        
        public uint CurrentClients
        {
            get
            {
                return this.m_CurrentClients;
            }
            set
            {
                this.m_CurrentClients = value;
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
        
        public uint QueueLength
        {
            get
            {
                return this.m_QueueLength;
            }
            set
            {
                this.m_QueueLength = value;
            }
        }
        
        public ulong ReadBytesPersec
        {
            get
            {
                return this.m_ReadBytesPersec;
            }
            set
            {
                this.m_ReadBytesPersec = value;
            }
        }
        
        public ulong ReadOperationsPersec
        {
            get
            {
                return this.m_ReadOperationsPersec;
            }
            set
            {
                this.m_ReadOperationsPersec = value;
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
        
        public ulong TotalBytesPersec
        {
            get
            {
                return this.m_TotalBytesPersec;
            }
            set
            {
                this.m_TotalBytesPersec = value;
            }
        }
        
        public ulong TotalOperationsPersec
        {
            get
            {
                return this.m_TotalOperationsPersec;
            }
            set
            {
                this.m_TotalOperationsPersec = value;
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
        
        public ulong WriteBytesPersec
        {
            get
            {
                return this.m_WriteBytesPersec;
            }
            set
            {
                this.m_WriteBytesPersec = value;
            }
        }
        
        public ulong WriteOperationsPersec
        {
            get
            {
                return this.m_WriteOperationsPersec;
            }
            set
            {
                this.m_WriteOperationsPersec = value;
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
