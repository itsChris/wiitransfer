using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_NetworkLoginProfile : WMIBase
    {
        
        private string m_AccountExpires;
        
        private uint m_AuthorizationFlags;
        
        private uint m_BadPasswordCount;
        
        private string m_Caption;
        
        private uint m_CodePage;
        
        private string m_Comment;
        
        private uint m_CountryCode;
        
        private string m_Description;
        
        private uint m_Flags;
        
        private string m_FullName;
        
        private string m_HomeDirectory;
        
        private string m_HomeDirectoryDrive;
        
        private string m_LastLogoff;
        
        private string m_LastLogon;
        
        private string m_LogonHours;
        
        private string m_LogonServer;
        
        private ulong m_MaximumStorage;
        
        private string m_Name;
        
        private uint m_NumberOfLogons;
        
        private string m_Parameters;
        
        private string m_PasswordAge;
        
        private string m_PasswordExpires;
        
        private uint m_PrimaryGroupId;
        
        private uint m_Privileges;
        
        private string m_Profile;
        
        private string m_ScriptPath;
        
        private string m_SettingID;
        
        private uint m_UnitsPerWeek;
        
        private string m_UserComment;
        
        private uint m_UserId;
        
        private string m_UserType;
        
        private string m_Workstations;
        
        private string m_MyPath;
        
        public Win32_NetworkLoginProfile()
        {
        }
        
        public string AccountExpires
        {
            get
            {
                return this.m_AccountExpires;
            }
            set
            {
                this.m_AccountExpires = value;
            }
        }
        
        public uint AuthorizationFlags
        {
            get
            {
                return this.m_AuthorizationFlags;
            }
            set
            {
                this.m_AuthorizationFlags = value;
            }
        }
        
        public uint BadPasswordCount
        {
            get
            {
                return this.m_BadPasswordCount;
            }
            set
            {
                this.m_BadPasswordCount = value;
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
        
        public uint CodePage
        {
            get
            {
                return this.m_CodePage;
            }
            set
            {
                this.m_CodePage = value;
            }
        }
        
        public string Comment
        {
            get
            {
                return this.m_Comment;
            }
            set
            {
                this.m_Comment = value;
            }
        }
        
        public uint CountryCode
        {
            get
            {
                return this.m_CountryCode;
            }
            set
            {
                this.m_CountryCode = value;
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
        
        public uint Flags
        {
            get
            {
                return this.m_Flags;
            }
            set
            {
                this.m_Flags = value;
            }
        }
        
        public string FullName
        {
            get
            {
                return this.m_FullName;
            }
            set
            {
                this.m_FullName = value;
            }
        }
        
        public string HomeDirectory
        {
            get
            {
                return this.m_HomeDirectory;
            }
            set
            {
                this.m_HomeDirectory = value;
            }
        }
        
        public string HomeDirectoryDrive
        {
            get
            {
                return this.m_HomeDirectoryDrive;
            }
            set
            {
                this.m_HomeDirectoryDrive = value;
            }
        }
        
        public string LastLogoff
        {
            get
            {
                return this.m_LastLogoff;
            }
            set
            {
                this.m_LastLogoff = value;
            }
        }
        
        public string LastLogon
        {
            get
            {
                return this.m_LastLogon;
            }
            set
            {
                this.m_LastLogon = value;
            }
        }
        
        public string LogonHours
        {
            get
            {
                return this.m_LogonHours;
            }
            set
            {
                this.m_LogonHours = value;
            }
        }
        
        public string LogonServer
        {
            get
            {
                return this.m_LogonServer;
            }
            set
            {
                this.m_LogonServer = value;
            }
        }
        
        public ulong MaximumStorage
        {
            get
            {
                return this.m_MaximumStorage;
            }
            set
            {
                this.m_MaximumStorage = value;
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
        
        public uint NumberOfLogons
        {
            get
            {
                return this.m_NumberOfLogons;
            }
            set
            {
                this.m_NumberOfLogons = value;
            }
        }
        
        public string Parameters
        {
            get
            {
                return this.m_Parameters;
            }
            set
            {
                this.m_Parameters = value;
            }
        }
        
        public string PasswordAge
        {
            get
            {
                return this.m_PasswordAge;
            }
            set
            {
                this.m_PasswordAge = value;
            }
        }
        
        public string PasswordExpires
        {
            get
            {
                return this.m_PasswordExpires;
            }
            set
            {
                this.m_PasswordExpires = value;
            }
        }
        
        public uint PrimaryGroupId
        {
            get
            {
                return this.m_PrimaryGroupId;
            }
            set
            {
                this.m_PrimaryGroupId = value;
            }
        }
        
        public uint Privileges
        {
            get
            {
                return this.m_Privileges;
            }
            set
            {
                this.m_Privileges = value;
            }
        }
        
        public string Profile
        {
            get
            {
                return this.m_Profile;
            }
            set
            {
                this.m_Profile = value;
            }
        }
        
        public string ScriptPath
        {
            get
            {
                return this.m_ScriptPath;
            }
            set
            {
                this.m_ScriptPath = value;
            }
        }
        
        public string SettingID
        {
            get
            {
                return this.m_SettingID;
            }
            set
            {
                this.m_SettingID = value;
            }
        }
        
        public uint UnitsPerWeek
        {
            get
            {
                return this.m_UnitsPerWeek;
            }
            set
            {
                this.m_UnitsPerWeek = value;
            }
        }
        
        public string UserComment
        {
            get
            {
                return this.m_UserComment;
            }
            set
            {
                this.m_UserComment = value;
            }
        }
        
        public uint UserId
        {
            get
            {
                return this.m_UserId;
            }
            set
            {
                this.m_UserId = value;
            }
        }
        
        public string UserType
        {
            get
            {
                return this.m_UserType;
            }
            set
            {
                this.m_UserType = value;
            }
        }
        
        public string Workstations
        {
            get
            {
                return this.m_Workstations;
            }
            set
            {
                this.m_Workstations = value;
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
