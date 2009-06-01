using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_NTLogEvent : WMIBase
    {
        
        private ushort m_Category;
        
        private string m_CategoryString;
        
        private string m_ComputerName;
        
        private ushort [] m_Data;
        
        private ushort m_EventCode;
        
        private uint m_EventIdentifier;
        
        private ushort m_EventType;
        
        private string [] m_InsertionStrings;
        
        private string m_Logfile;
        
        private string m_Message;
        
        private uint m_RecordNumber;
        
        private string m_SourceName;
        
        private string m_TimeGenerated;
        
        private string m_TimeWritten;
        
        private string m_Type;
        
        private string m_User;
        
        private string m_MyPath;
        
        public Win32_NTLogEvent()
        {
        }
        
        public ushort Category
        {
            get
            {
                return this.m_Category;
            }
            set
            {
                this.m_Category = value;
            }
        }
        
        public string CategoryString
        {
            get
            {
                return this.m_CategoryString;
            }
            set
            {
                this.m_CategoryString = value;
            }
        }
        
        public string ComputerName
        {
            get
            {
                return this.m_ComputerName;
            }
            set
            {
                this.m_ComputerName = value;
            }
        }
        
        public ushort [] Data
        {
            get
            {
                return this.m_Data;
            }
            set
            {
                this.m_Data = value;
            }
        }
        
        public ushort EventCode
        {
            get
            {
                return this.m_EventCode;
            }
            set
            {
                this.m_EventCode = value;
            }
        }
        
        public uint EventIdentifier
        {
            get
            {
                return this.m_EventIdentifier;
            }
            set
            {
                this.m_EventIdentifier = value;
            }
        }
        
        public ushort EventType
        {
            get
            {
                return this.m_EventType;
            }
            set
            {
                this.m_EventType = value;
            }
        }
        
        public string [] InsertionStrings
        {
            get
            {
                return this.m_InsertionStrings;
            }
            set
            {
                this.m_InsertionStrings = value;
            }
        }
        
        public string Logfile
        {
            get
            {
                return this.m_Logfile;
            }
            set
            {
                this.m_Logfile = value;
            }
        }
        
        public string Message
        {
            get
            {
                return this.m_Message;
            }
            set
            {
                this.m_Message = value;
            }
        }
        
        public uint RecordNumber
        {
            get
            {
                return this.m_RecordNumber;
            }
            set
            {
                this.m_RecordNumber = value;
            }
        }
        
        public string SourceName
        {
            get
            {
                return this.m_SourceName;
            }
            set
            {
                this.m_SourceName = value;
            }
        }
        
        public string TimeGenerated
        {
            get
            {
                return this.m_TimeGenerated;
            }
            set
            {
                this.m_TimeGenerated = value;
            }
        }
        
        public string TimeWritten
        {
            get
            {
                return this.m_TimeWritten;
            }
            set
            {
                this.m_TimeWritten = value;
            }
        }
        
        public string Type
        {
            get
            {
                return this.m_Type;
            }
            set
            {
                this.m_Type = value;
            }
        }
        
        public string User
        {
            get
            {
                return this.m_User;
            }
            set
            {
                this.m_User = value;
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
