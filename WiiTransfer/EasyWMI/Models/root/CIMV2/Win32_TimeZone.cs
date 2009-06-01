using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_TimeZone : WMIBase
    {
        
        private int m_Bias;
        
        private string m_Caption;
        
        private int m_DaylightBias;
        
        private uint m_DaylightDay;
        
        private ushort m_DaylightDayOfWeek;
        
        private uint m_DaylightHour;
        
        private uint m_DaylightMillisecond;
        
        private uint m_DaylightMinute;
        
        private uint m_DaylightMonth;
        
        private string m_DaylightName;
        
        private uint m_DaylightSecond;
        
        private uint m_DaylightYear;
        
        private string m_Description;
        
        private string m_SettingID;
        
        private uint m_StandardBias;
        
        private uint m_StandardDay;
        
        private ushort m_StandardDayOfWeek;
        
        private uint m_StandardHour;
        
        private uint m_StandardMillisecond;
        
        private uint m_StandardMinute;
        
        private uint m_StandardMonth;
        
        private string m_StandardName;
        
        private uint m_StandardSecond;
        
        private uint m_StandardYear;
        
        private string m_MyPath;
        
        public Win32_TimeZone()
        {
        }
        
        public int Bias
        {
            get
            {
                return this.m_Bias;
            }
            set
            {
                this.m_Bias = value;
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
        
        public int DaylightBias
        {
            get
            {
                return this.m_DaylightBias;
            }
            set
            {
                this.m_DaylightBias = value;
            }
        }
        
        public uint DaylightDay
        {
            get
            {
                return this.m_DaylightDay;
            }
            set
            {
                this.m_DaylightDay = value;
            }
        }
        
        public ushort DaylightDayOfWeek
        {
            get
            {
                return this.m_DaylightDayOfWeek;
            }
            set
            {
                this.m_DaylightDayOfWeek = value;
            }
        }
        
        public uint DaylightHour
        {
            get
            {
                return this.m_DaylightHour;
            }
            set
            {
                this.m_DaylightHour = value;
            }
        }
        
        public uint DaylightMillisecond
        {
            get
            {
                return this.m_DaylightMillisecond;
            }
            set
            {
                this.m_DaylightMillisecond = value;
            }
        }
        
        public uint DaylightMinute
        {
            get
            {
                return this.m_DaylightMinute;
            }
            set
            {
                this.m_DaylightMinute = value;
            }
        }
        
        public uint DaylightMonth
        {
            get
            {
                return this.m_DaylightMonth;
            }
            set
            {
                this.m_DaylightMonth = value;
            }
        }
        
        public string DaylightName
        {
            get
            {
                return this.m_DaylightName;
            }
            set
            {
                this.m_DaylightName = value;
            }
        }
        
        public uint DaylightSecond
        {
            get
            {
                return this.m_DaylightSecond;
            }
            set
            {
                this.m_DaylightSecond = value;
            }
        }
        
        public uint DaylightYear
        {
            get
            {
                return this.m_DaylightYear;
            }
            set
            {
                this.m_DaylightYear = value;
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
        
        public uint StandardBias
        {
            get
            {
                return this.m_StandardBias;
            }
            set
            {
                this.m_StandardBias = value;
            }
        }
        
        public uint StandardDay
        {
            get
            {
                return this.m_StandardDay;
            }
            set
            {
                this.m_StandardDay = value;
            }
        }
        
        public ushort StandardDayOfWeek
        {
            get
            {
                return this.m_StandardDayOfWeek;
            }
            set
            {
                this.m_StandardDayOfWeek = value;
            }
        }
        
        public uint StandardHour
        {
            get
            {
                return this.m_StandardHour;
            }
            set
            {
                this.m_StandardHour = value;
            }
        }
        
        public uint StandardMillisecond
        {
            get
            {
                return this.m_StandardMillisecond;
            }
            set
            {
                this.m_StandardMillisecond = value;
            }
        }
        
        public uint StandardMinute
        {
            get
            {
                return this.m_StandardMinute;
            }
            set
            {
                this.m_StandardMinute = value;
            }
        }
        
        public uint StandardMonth
        {
            get
            {
                return this.m_StandardMonth;
            }
            set
            {
                this.m_StandardMonth = value;
            }
        }
        
        public string StandardName
        {
            get
            {
                return this.m_StandardName;
            }
            set
            {
                this.m_StandardName = value;
            }
        }
        
        public uint StandardSecond
        {
            get
            {
                return this.m_StandardSecond;
            }
            set
            {
                this.m_StandardSecond = value;
            }
        }
        
        public uint StandardYear
        {
            get
            {
                return this.m_StandardYear;
            }
            set
            {
                this.m_StandardYear = value;
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
