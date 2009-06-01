using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_UGTHRSVC_SearchGatherer : WMIBase
    {
        
        private uint m_ActiveQueueLength;
        
        private uint m_AdminClients;
        
        private uint m_AllNotificationsReceived;
        
        private string m_Caption;
        
        private uint m_DelayedDocuments;
        
        private string m_Description;
        
        private uint m_DocumentEntries;
        
        private uint m_DocumentsDelayedRetry;
        
        private uint m_DocumentsFiltered;
        
        private uint m_DocumentsFilteredRate;
        
        private uint m_DocumentsSuccessfullyFiltered;
        
        private uint m_DocumentsSuccessfullyFilteredRate;
        
        private uint m_ExtNotificationsRate;
        
        private uint m_ExtNotificationsReceived;
        
        private uint m_FilteringThreads;
        
        private uint m_FilterObjects;
        
        private uint m_FilterProcessCreated;
        
        private uint m_FilterProcesses;
        
        private uint m_FilterProcessesMax;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_Heartbeats;
        
        private uint m_HeartbeatsRate;
        
        private uint m_IdleThreads;
        
        private string m_Name;
        
        private uint m_NotificationSources;
        
        private uint m_NotificationsRate;
        
        private uint m_PerformanceLevel;
        
        private uint m_Reasontobackoff;
        
        private uint m_ServerObjects;
        
        private uint m_ServerObjectsCreated;
        
        private uint m_ServersCurrentlyUnavailable;
        
        private uint m_ServersUnavailable;
        
        private uint m_StemmersCached;
        
        private uint m_SystemIOtrafficrate;
        
        private uint m_ThreadsAccessingNetwork;
        
        private uint m_Threadsblockedduetobackoff;
        
        private uint m_ThreadsInPlugins;
        
        private uint m_TimeOuts;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_WordBreakersCached;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_UGTHRSVC_SearchGatherer()
        {
        }
        
        public uint ActiveQueueLength
        {
            get
            {
                return this.m_ActiveQueueLength;
            }
            set
            {
                this.m_ActiveQueueLength = value;
            }
        }
        
        public uint AdminClients
        {
            get
            {
                return this.m_AdminClients;
            }
            set
            {
                this.m_AdminClients = value;
            }
        }
        
        public uint AllNotificationsReceived
        {
            get
            {
                return this.m_AllNotificationsReceived;
            }
            set
            {
                this.m_AllNotificationsReceived = value;
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
        
        public uint DelayedDocuments
        {
            get
            {
                return this.m_DelayedDocuments;
            }
            set
            {
                this.m_DelayedDocuments = value;
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
        
        public uint DocumentEntries
        {
            get
            {
                return this.m_DocumentEntries;
            }
            set
            {
                this.m_DocumentEntries = value;
            }
        }
        
        public uint DocumentsDelayedRetry
        {
            get
            {
                return this.m_DocumentsDelayedRetry;
            }
            set
            {
                this.m_DocumentsDelayedRetry = value;
            }
        }
        
        public uint DocumentsFiltered
        {
            get
            {
                return this.m_DocumentsFiltered;
            }
            set
            {
                this.m_DocumentsFiltered = value;
            }
        }
        
        public uint DocumentsFilteredRate
        {
            get
            {
                return this.m_DocumentsFilteredRate;
            }
            set
            {
                this.m_DocumentsFilteredRate = value;
            }
        }
        
        public uint DocumentsSuccessfullyFiltered
        {
            get
            {
                return this.m_DocumentsSuccessfullyFiltered;
            }
            set
            {
                this.m_DocumentsSuccessfullyFiltered = value;
            }
        }
        
        public uint DocumentsSuccessfullyFilteredRate
        {
            get
            {
                return this.m_DocumentsSuccessfullyFilteredRate;
            }
            set
            {
                this.m_DocumentsSuccessfullyFilteredRate = value;
            }
        }
        
        public uint ExtNotificationsRate
        {
            get
            {
                return this.m_ExtNotificationsRate;
            }
            set
            {
                this.m_ExtNotificationsRate = value;
            }
        }
        
        public uint ExtNotificationsReceived
        {
            get
            {
                return this.m_ExtNotificationsReceived;
            }
            set
            {
                this.m_ExtNotificationsReceived = value;
            }
        }
        
        public uint FilteringThreads
        {
            get
            {
                return this.m_FilteringThreads;
            }
            set
            {
                this.m_FilteringThreads = value;
            }
        }
        
        public uint FilterObjects
        {
            get
            {
                return this.m_FilterObjects;
            }
            set
            {
                this.m_FilterObjects = value;
            }
        }
        
        public uint FilterProcessCreated
        {
            get
            {
                return this.m_FilterProcessCreated;
            }
            set
            {
                this.m_FilterProcessCreated = value;
            }
        }
        
        public uint FilterProcesses
        {
            get
            {
                return this.m_FilterProcesses;
            }
            set
            {
                this.m_FilterProcesses = value;
            }
        }
        
        public uint FilterProcessesMax
        {
            get
            {
                return this.m_FilterProcessesMax;
            }
            set
            {
                this.m_FilterProcessesMax = value;
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
        
        public uint Heartbeats
        {
            get
            {
                return this.m_Heartbeats;
            }
            set
            {
                this.m_Heartbeats = value;
            }
        }
        
        public uint HeartbeatsRate
        {
            get
            {
                return this.m_HeartbeatsRate;
            }
            set
            {
                this.m_HeartbeatsRate = value;
            }
        }
        
        public uint IdleThreads
        {
            get
            {
                return this.m_IdleThreads;
            }
            set
            {
                this.m_IdleThreads = value;
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
        
        public uint NotificationSources
        {
            get
            {
                return this.m_NotificationSources;
            }
            set
            {
                this.m_NotificationSources = value;
            }
        }
        
        public uint NotificationsRate
        {
            get
            {
                return this.m_NotificationsRate;
            }
            set
            {
                this.m_NotificationsRate = value;
            }
        }
        
        public uint PerformanceLevel
        {
            get
            {
                return this.m_PerformanceLevel;
            }
            set
            {
                this.m_PerformanceLevel = value;
            }
        }
        
        public uint Reasontobackoff
        {
            get
            {
                return this.m_Reasontobackoff;
            }
            set
            {
                this.m_Reasontobackoff = value;
            }
        }
        
        public uint ServerObjects
        {
            get
            {
                return this.m_ServerObjects;
            }
            set
            {
                this.m_ServerObjects = value;
            }
        }
        
        public uint ServerObjectsCreated
        {
            get
            {
                return this.m_ServerObjectsCreated;
            }
            set
            {
                this.m_ServerObjectsCreated = value;
            }
        }
        
        public uint ServersCurrentlyUnavailable
        {
            get
            {
                return this.m_ServersCurrentlyUnavailable;
            }
            set
            {
                this.m_ServersCurrentlyUnavailable = value;
            }
        }
        
        public uint ServersUnavailable
        {
            get
            {
                return this.m_ServersUnavailable;
            }
            set
            {
                this.m_ServersUnavailable = value;
            }
        }
        
        public uint StemmersCached
        {
            get
            {
                return this.m_StemmersCached;
            }
            set
            {
                this.m_StemmersCached = value;
            }
        }
        
        public uint SystemIOtrafficrate
        {
            get
            {
                return this.m_SystemIOtrafficrate;
            }
            set
            {
                this.m_SystemIOtrafficrate = value;
            }
        }
        
        public uint ThreadsAccessingNetwork
        {
            get
            {
                return this.m_ThreadsAccessingNetwork;
            }
            set
            {
                this.m_ThreadsAccessingNetwork = value;
            }
        }
        
        public uint Threadsblockedduetobackoff
        {
            get
            {
                return this.m_Threadsblockedduetobackoff;
            }
            set
            {
                this.m_Threadsblockedduetobackoff = value;
            }
        }
        
        public uint ThreadsInPlugins
        {
            get
            {
                return this.m_ThreadsInPlugins;
            }
            set
            {
                this.m_ThreadsInPlugins = value;
            }
        }
        
        public uint TimeOuts
        {
            get
            {
                return this.m_TimeOuts;
            }
            set
            {
                this.m_TimeOuts = value;
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
        
        public uint WordBreakersCached
        {
            get
            {
                return this.m_WordBreakersCached;
            }
            set
            {
                this.m_WordBreakersCached = value;
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
