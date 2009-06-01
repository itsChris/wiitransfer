using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_MSDTC_DistributedTransactionCoordinator : WMIBase
    {
        
        private uint m_AbortedTransactions;
        
        private uint m_AbortedTransactionsPersec;
        
        private uint m_ActiveTransactions;
        
        private uint m_ActiveTransactionsMaximum;
        
        private string m_Caption;
        
        private uint m_CommittedTransactions;
        
        private uint m_CommittedTransactionsPersec;
        
        private string m_Description;
        
        private uint m_ForceAbortedTransactions;
        
        private uint m_ForceCommittedTransactions;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_InDoubtTransactions;
        
        private string m_Name;
        
        private uint m_ResponseTimeAverage;
        
        private uint m_ResponseTimeMaximum;
        
        private uint m_ResponseTimeMinimum;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_TransactionsPersec;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_MSDTC_DistributedTransactionCoordinator()
        {
        }
        
        public uint AbortedTransactions
        {
            get
            {
                return this.m_AbortedTransactions;
            }
            set
            {
                this.m_AbortedTransactions = value;
            }
        }
        
        public uint AbortedTransactionsPersec
        {
            get
            {
                return this.m_AbortedTransactionsPersec;
            }
            set
            {
                this.m_AbortedTransactionsPersec = value;
            }
        }
        
        public uint ActiveTransactions
        {
            get
            {
                return this.m_ActiveTransactions;
            }
            set
            {
                this.m_ActiveTransactions = value;
            }
        }
        
        public uint ActiveTransactionsMaximum
        {
            get
            {
                return this.m_ActiveTransactionsMaximum;
            }
            set
            {
                this.m_ActiveTransactionsMaximum = value;
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
        
        public uint CommittedTransactions
        {
            get
            {
                return this.m_CommittedTransactions;
            }
            set
            {
                this.m_CommittedTransactions = value;
            }
        }
        
        public uint CommittedTransactionsPersec
        {
            get
            {
                return this.m_CommittedTransactionsPersec;
            }
            set
            {
                this.m_CommittedTransactionsPersec = value;
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
        
        public uint ForceAbortedTransactions
        {
            get
            {
                return this.m_ForceAbortedTransactions;
            }
            set
            {
                this.m_ForceAbortedTransactions = value;
            }
        }
        
        public uint ForceCommittedTransactions
        {
            get
            {
                return this.m_ForceCommittedTransactions;
            }
            set
            {
                this.m_ForceCommittedTransactions = value;
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
        
        public uint InDoubtTransactions
        {
            get
            {
                return this.m_InDoubtTransactions;
            }
            set
            {
                this.m_InDoubtTransactions = value;
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
        
        public uint ResponseTimeAverage
        {
            get
            {
                return this.m_ResponseTimeAverage;
            }
            set
            {
                this.m_ResponseTimeAverage = value;
            }
        }
        
        public uint ResponseTimeMaximum
        {
            get
            {
                return this.m_ResponseTimeMaximum;
            }
            set
            {
                this.m_ResponseTimeMaximum = value;
            }
        }
        
        public uint ResponseTimeMinimum
        {
            get
            {
                return this.m_ResponseTimeMinimum;
            }
            set
            {
                this.m_ResponseTimeMinimum = value;
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
        
        public uint TransactionsPersec
        {
            get
            {
                return this.m_TransactionsPersec;
            }
            set
            {
                this.m_TransactionsPersec = value;
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
