using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_PerfNet_Browser : WMIBase
    {
        
        private ulong m_AnnouncementsDomainPersec;
        
        private ulong m_AnnouncementsServerPersec;
        
        private ulong m_AnnouncementsTotalPersec;
        
        private string m_Caption;
        
        private string m_Description;
        
        private uint m_DuplicateMasterAnnouncements;
        
        private uint m_ElectionPacketsPersec;
        
        private uint m_EnumerationsDomainPersec;
        
        private uint m_EnumerationsOtherPersec;
        
        private uint m_EnumerationsServerPersec;
        
        private uint m_EnumerationsTotalPersec;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private ulong m_IllegalDatagramsPersec;
        
        private uint m_MailslotAllocationsFailed;
        
        private uint m_MailslotOpensFailedPersec;
        
        private uint m_MailslotReceivesFailed;
        
        private uint m_MailslotWritesFailed;
        
        private uint m_MailslotWritesPersec;
        
        private uint m_MissedMailslotDatagrams;
        
        private uint m_MissedServerAnnouncements;
        
        private uint m_MissedServerListRequests;
        
        private string m_Name;
        
        private uint m_ServerAnnounceAllocationsFailedPersec;
        
        private uint m_ServerListRequestsPersec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_PerfNet_Browser()
        {
        }
        
        public ulong AnnouncementsDomainPersec
        {
            get
            {
                return this.m_AnnouncementsDomainPersec;
            }
            set
            {
                this.m_AnnouncementsDomainPersec = value;
            }
        }
        
        public ulong AnnouncementsServerPersec
        {
            get
            {
                return this.m_AnnouncementsServerPersec;
            }
            set
            {
                this.m_AnnouncementsServerPersec = value;
            }
        }
        
        public ulong AnnouncementsTotalPersec
        {
            get
            {
                return this.m_AnnouncementsTotalPersec;
            }
            set
            {
                this.m_AnnouncementsTotalPersec = value;
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
        
        public uint DuplicateMasterAnnouncements
        {
            get
            {
                return this.m_DuplicateMasterAnnouncements;
            }
            set
            {
                this.m_DuplicateMasterAnnouncements = value;
            }
        }
        
        public uint ElectionPacketsPersec
        {
            get
            {
                return this.m_ElectionPacketsPersec;
            }
            set
            {
                this.m_ElectionPacketsPersec = value;
            }
        }
        
        public uint EnumerationsDomainPersec
        {
            get
            {
                return this.m_EnumerationsDomainPersec;
            }
            set
            {
                this.m_EnumerationsDomainPersec = value;
            }
        }
        
        public uint EnumerationsOtherPersec
        {
            get
            {
                return this.m_EnumerationsOtherPersec;
            }
            set
            {
                this.m_EnumerationsOtherPersec = value;
            }
        }
        
        public uint EnumerationsServerPersec
        {
            get
            {
                return this.m_EnumerationsServerPersec;
            }
            set
            {
                this.m_EnumerationsServerPersec = value;
            }
        }
        
        public uint EnumerationsTotalPersec
        {
            get
            {
                return this.m_EnumerationsTotalPersec;
            }
            set
            {
                this.m_EnumerationsTotalPersec = value;
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
        
        public ulong IllegalDatagramsPersec
        {
            get
            {
                return this.m_IllegalDatagramsPersec;
            }
            set
            {
                this.m_IllegalDatagramsPersec = value;
            }
        }
        
        public uint MailslotAllocationsFailed
        {
            get
            {
                return this.m_MailslotAllocationsFailed;
            }
            set
            {
                this.m_MailslotAllocationsFailed = value;
            }
        }
        
        public uint MailslotOpensFailedPersec
        {
            get
            {
                return this.m_MailslotOpensFailedPersec;
            }
            set
            {
                this.m_MailslotOpensFailedPersec = value;
            }
        }
        
        public uint MailslotReceivesFailed
        {
            get
            {
                return this.m_MailslotReceivesFailed;
            }
            set
            {
                this.m_MailslotReceivesFailed = value;
            }
        }
        
        public uint MailslotWritesFailed
        {
            get
            {
                return this.m_MailslotWritesFailed;
            }
            set
            {
                this.m_MailslotWritesFailed = value;
            }
        }
        
        public uint MailslotWritesPersec
        {
            get
            {
                return this.m_MailslotWritesPersec;
            }
            set
            {
                this.m_MailslotWritesPersec = value;
            }
        }
        
        public uint MissedMailslotDatagrams
        {
            get
            {
                return this.m_MissedMailslotDatagrams;
            }
            set
            {
                this.m_MissedMailslotDatagrams = value;
            }
        }
        
        public uint MissedServerAnnouncements
        {
            get
            {
                return this.m_MissedServerAnnouncements;
            }
            set
            {
                this.m_MissedServerAnnouncements = value;
            }
        }
        
        public uint MissedServerListRequests
        {
            get
            {
                return this.m_MissedServerListRequests;
            }
            set
            {
                this.m_MissedServerListRequests = value;
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
        
        public uint ServerAnnounceAllocationsFailedPersec
        {
            get
            {
                return this.m_ServerAnnounceAllocationsFailedPersec;
            }
            set
            {
                this.m_ServerAnnounceAllocationsFailedPersec = value;
            }
        }
        
        public uint ServerListRequestsPersec
        {
            get
            {
                return this.m_ServerListRequestsPersec;
            }
            set
            {
                this.m_ServerListRequestsPersec = value;
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
