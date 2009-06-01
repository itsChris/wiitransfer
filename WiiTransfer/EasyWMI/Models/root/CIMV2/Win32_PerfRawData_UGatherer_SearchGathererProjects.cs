using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_UGatherer_SearchGathererProjects : WMIBase
    {
        
        private uint m_AccessedFileRate;
        
        private uint m_AccessedFiles;
        
        private uint m_AdaptiveCrawlErrors;
        
        private string m_Caption;
        
        private uint m_ChangedDocuments;
        
        private uint m_Crawlsinprogress;
        
        private uint m_DelayedDocuments;
        
        private string m_Description;
        
        private uint m_DocumentAdditions;
        
        private uint m_DocumentAddRate;
        
        private uint m_DocumentDeleteRate;
        
        private uint m_DocumentDeletes;
        
        private uint m_DocumentModifies;
        
        private uint m_DocumentModifiesRate;
        
        private uint m_DocumentMoveandRenameRate;
        
        private uint m_DocumentMovesPerRenames;
        
        private uint m_DocumentsInProgress;
        
        private uint m_DocumentsOnHold;
        
        private uint m_ErrorRate;
        
        private uint m_FileErrors;
        
        private uint m_FileErrorsRate;
        
        private uint m_FilteredOffice;
        
        private uint m_FilteredOfficeRate;
        
        private uint m_FilteredText;
        
        private uint m_FilteredTextRate;
        
        private uint m_FilteringDocuments;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_GathererPausedFlag;
        
        private uint m_HistoryRecoveryProgress;
        
        private uint m_IncrementalCrawls;
        
        private uint m_IteratingHistoryInProgressFlag;
        
        private string m_Name;
        
        private uint m_NotModified;
        
        private uint m_ProcessedDocuments;
        
        private uint m_ProcessedDocumentsRate;
        
        private uint m_RecoveryInProgressFlag;
        
        private uint m_Retries;
        
        private uint m_RetriesRate;
        
        private uint m_StartedDocuments;
        
        private uint m_StatusError;
        
        private uint m_StatusSuccess;
        
        private uint m_SuccessRate;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_UniqueDocuments;
        
        private uint m_URLsinHistory;
        
        private uint m_WaitingDocuments;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_UGatherer_SearchGathererProjects()
        {
        }
        
        public uint AccessedFileRate
        {
            get
            {
                return this.m_AccessedFileRate;
            }
            set
            {
                this.m_AccessedFileRate = value;
            }
        }
        
        public uint AccessedFiles
        {
            get
            {
                return this.m_AccessedFiles;
            }
            set
            {
                this.m_AccessedFiles = value;
            }
        }
        
        public uint AdaptiveCrawlErrors
        {
            get
            {
                return this.m_AdaptiveCrawlErrors;
            }
            set
            {
                this.m_AdaptiveCrawlErrors = value;
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
        
        public uint ChangedDocuments
        {
            get
            {
                return this.m_ChangedDocuments;
            }
            set
            {
                this.m_ChangedDocuments = value;
            }
        }
        
        public uint Crawlsinprogress
        {
            get
            {
                return this.m_Crawlsinprogress;
            }
            set
            {
                this.m_Crawlsinprogress = value;
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
        
        public uint DocumentAdditions
        {
            get
            {
                return this.m_DocumentAdditions;
            }
            set
            {
                this.m_DocumentAdditions = value;
            }
        }
        
        public uint DocumentAddRate
        {
            get
            {
                return this.m_DocumentAddRate;
            }
            set
            {
                this.m_DocumentAddRate = value;
            }
        }
        
        public uint DocumentDeleteRate
        {
            get
            {
                return this.m_DocumentDeleteRate;
            }
            set
            {
                this.m_DocumentDeleteRate = value;
            }
        }
        
        public uint DocumentDeletes
        {
            get
            {
                return this.m_DocumentDeletes;
            }
            set
            {
                this.m_DocumentDeletes = value;
            }
        }
        
        public uint DocumentModifies
        {
            get
            {
                return this.m_DocumentModifies;
            }
            set
            {
                this.m_DocumentModifies = value;
            }
        }
        
        public uint DocumentModifiesRate
        {
            get
            {
                return this.m_DocumentModifiesRate;
            }
            set
            {
                this.m_DocumentModifiesRate = value;
            }
        }
        
        public uint DocumentMoveandRenameRate
        {
            get
            {
                return this.m_DocumentMoveandRenameRate;
            }
            set
            {
                this.m_DocumentMoveandRenameRate = value;
            }
        }
        
        public uint DocumentMovesPerRenames
        {
            get
            {
                return this.m_DocumentMovesPerRenames;
            }
            set
            {
                this.m_DocumentMovesPerRenames = value;
            }
        }
        
        public uint DocumentsInProgress
        {
            get
            {
                return this.m_DocumentsInProgress;
            }
            set
            {
                this.m_DocumentsInProgress = value;
            }
        }
        
        public uint DocumentsOnHold
        {
            get
            {
                return this.m_DocumentsOnHold;
            }
            set
            {
                this.m_DocumentsOnHold = value;
            }
        }
        
        public uint ErrorRate
        {
            get
            {
                return this.m_ErrorRate;
            }
            set
            {
                this.m_ErrorRate = value;
            }
        }
        
        public uint FileErrors
        {
            get
            {
                return this.m_FileErrors;
            }
            set
            {
                this.m_FileErrors = value;
            }
        }
        
        public uint FileErrorsRate
        {
            get
            {
                return this.m_FileErrorsRate;
            }
            set
            {
                this.m_FileErrorsRate = value;
            }
        }
        
        public uint FilteredOffice
        {
            get
            {
                return this.m_FilteredOffice;
            }
            set
            {
                this.m_FilteredOffice = value;
            }
        }
        
        public uint FilteredOfficeRate
        {
            get
            {
                return this.m_FilteredOfficeRate;
            }
            set
            {
                this.m_FilteredOfficeRate = value;
            }
        }
        
        public uint FilteredText
        {
            get
            {
                return this.m_FilteredText;
            }
            set
            {
                this.m_FilteredText = value;
            }
        }
        
        public uint FilteredTextRate
        {
            get
            {
                return this.m_FilteredTextRate;
            }
            set
            {
                this.m_FilteredTextRate = value;
            }
        }
        
        public uint FilteringDocuments
        {
            get
            {
                return this.m_FilteringDocuments;
            }
            set
            {
                this.m_FilteringDocuments = value;
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
        
        public uint GathererPausedFlag
        {
            get
            {
                return this.m_GathererPausedFlag;
            }
            set
            {
                this.m_GathererPausedFlag = value;
            }
        }
        
        public uint HistoryRecoveryProgress
        {
            get
            {
                return this.m_HistoryRecoveryProgress;
            }
            set
            {
                this.m_HistoryRecoveryProgress = value;
            }
        }
        
        public uint IncrementalCrawls
        {
            get
            {
                return this.m_IncrementalCrawls;
            }
            set
            {
                this.m_IncrementalCrawls = value;
            }
        }
        
        public uint IteratingHistoryInProgressFlag
        {
            get
            {
                return this.m_IteratingHistoryInProgressFlag;
            }
            set
            {
                this.m_IteratingHistoryInProgressFlag = value;
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
        
        public uint NotModified
        {
            get
            {
                return this.m_NotModified;
            }
            set
            {
                this.m_NotModified = value;
            }
        }
        
        public uint ProcessedDocuments
        {
            get
            {
                return this.m_ProcessedDocuments;
            }
            set
            {
                this.m_ProcessedDocuments = value;
            }
        }
        
        public uint ProcessedDocumentsRate
        {
            get
            {
                return this.m_ProcessedDocumentsRate;
            }
            set
            {
                this.m_ProcessedDocumentsRate = value;
            }
        }
        
        public uint RecoveryInProgressFlag
        {
            get
            {
                return this.m_RecoveryInProgressFlag;
            }
            set
            {
                this.m_RecoveryInProgressFlag = value;
            }
        }
        
        public uint Retries
        {
            get
            {
                return this.m_Retries;
            }
            set
            {
                this.m_Retries = value;
            }
        }
        
        public uint RetriesRate
        {
            get
            {
                return this.m_RetriesRate;
            }
            set
            {
                this.m_RetriesRate = value;
            }
        }
        
        public uint StartedDocuments
        {
            get
            {
                return this.m_StartedDocuments;
            }
            set
            {
                this.m_StartedDocuments = value;
            }
        }
        
        public uint StatusError
        {
            get
            {
                return this.m_StatusError;
            }
            set
            {
                this.m_StatusError = value;
            }
        }
        
        public uint StatusSuccess
        {
            get
            {
                return this.m_StatusSuccess;
            }
            set
            {
                this.m_StatusSuccess = value;
            }
        }
        
        public uint SuccessRate
        {
            get
            {
                return this.m_SuccessRate;
            }
            set
            {
                this.m_SuccessRate = value;
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
        
        public uint UniqueDocuments
        {
            get
            {
                return this.m_UniqueDocuments;
            }
            set
            {
                this.m_UniqueDocuments = value;
            }
        }
        
        public uint URLsinHistory
        {
            get
            {
                return this.m_URLsinHistory;
            }
            set
            {
                this.m_URLsinHistory = value;
            }
        }
        
        public uint WaitingDocuments
        {
            get
            {
                return this.m_WaitingDocuments;
            }
            set
            {
                this.m_WaitingDocuments = value;
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
