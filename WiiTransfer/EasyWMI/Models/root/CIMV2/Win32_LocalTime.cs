using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_LocalTime : WMIBase
    {
        
        private uint m_Day;
        
        private uint m_DayOfWeek;
        
        private uint m_Hour;
        
        private uint m_Milliseconds;
        
        private uint m_Minute;
        
        private uint m_Month;
        
        private uint m_Quarter;
        
        private uint m_Second;
        
        private uint m_WeekInMonth;
        
        private uint m_Year;
        
        private string m_MyPath;
        
        public Win32_LocalTime()
        {
        }
        
        public uint Day
        {
            get
            {
                return this.m_Day;
            }
            set
            {
                this.m_Day = value;
            }
        }
        
        public uint DayOfWeek
        {
            get
            {
                return this.m_DayOfWeek;
            }
            set
            {
                this.m_DayOfWeek = value;
            }
        }
        
        public uint Hour
        {
            get
            {
                return this.m_Hour;
            }
            set
            {
                this.m_Hour = value;
            }
        }
        
        public uint Milliseconds
        {
            get
            {
                return this.m_Milliseconds;
            }
            set
            {
                this.m_Milliseconds = value;
            }
        }
        
        public uint Minute
        {
            get
            {
                return this.m_Minute;
            }
            set
            {
                this.m_Minute = value;
            }
        }
        
        public uint Month
        {
            get
            {
                return this.m_Month;
            }
            set
            {
                this.m_Month = value;
            }
        }
        
        public uint Quarter
        {
            get
            {
                return this.m_Quarter;
            }
            set
            {
                this.m_Quarter = value;
            }
        }
        
        public uint Second
        {
            get
            {
                return this.m_Second;
            }
            set
            {
                this.m_Second = value;
            }
        }
        
        public uint WeekInMonth
        {
            get
            {
                return this.m_WeekInMonth;
            }
            set
            {
                this.m_WeekInMonth = value;
            }
        }
        
        public uint Year
        {
            get
            {
                return this.m_Year;
            }
            set
            {
                this.m_Year = value;
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
