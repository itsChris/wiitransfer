using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_Desktop : WMIBase
    {
        
        private uint m_BorderWidth;
        
        private string m_Caption;
        
        private bool m_CoolSwitch;
        
        private uint m_CursorBlinkRate;
        
        private string m_Description;
        
        private bool m_DragFullWindows;
        
        private uint m_GridGranularity;
        
        private uint m_IconSpacing;
        
        private string m_IconTitleFaceName;
        
        private uint m_IconTitleSize;
        
        private bool m_IconTitleWrap;
        
        private string m_Name;
        
        private string m_Pattern;
        
        private bool m_ScreenSaverActive;
        
        private string m_ScreenSaverExecutable;
        
        private bool m_ScreenSaverSecure;
        
        private uint m_ScreenSaverTimeout;
        
        private string m_SettingID;
        
        private string m_Wallpaper;
        
        private bool m_WallpaperStretched;
        
        private bool m_WallpaperTiled;
        
        private string m_MyPath;
        
        public Win32_Desktop()
        {
        }
        
        public uint BorderWidth
        {
            get
            {
                return this.m_BorderWidth;
            }
            set
            {
                this.m_BorderWidth = value;
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
        
        public bool CoolSwitch
        {
            get
            {
                return this.m_CoolSwitch;
            }
            set
            {
                this.m_CoolSwitch = value;
            }
        }
        
        public uint CursorBlinkRate
        {
            get
            {
                return this.m_CursorBlinkRate;
            }
            set
            {
                this.m_CursorBlinkRate = value;
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
        
        public bool DragFullWindows
        {
            get
            {
                return this.m_DragFullWindows;
            }
            set
            {
                this.m_DragFullWindows = value;
            }
        }
        
        public uint GridGranularity
        {
            get
            {
                return this.m_GridGranularity;
            }
            set
            {
                this.m_GridGranularity = value;
            }
        }
        
        public uint IconSpacing
        {
            get
            {
                return this.m_IconSpacing;
            }
            set
            {
                this.m_IconSpacing = value;
            }
        }
        
        public string IconTitleFaceName
        {
            get
            {
                return this.m_IconTitleFaceName;
            }
            set
            {
                this.m_IconTitleFaceName = value;
            }
        }
        
        public uint IconTitleSize
        {
            get
            {
                return this.m_IconTitleSize;
            }
            set
            {
                this.m_IconTitleSize = value;
            }
        }
        
        public bool IconTitleWrap
        {
            get
            {
                return this.m_IconTitleWrap;
            }
            set
            {
                this.m_IconTitleWrap = value;
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
        
        public string Pattern
        {
            get
            {
                return this.m_Pattern;
            }
            set
            {
                this.m_Pattern = value;
            }
        }
        
        public bool ScreenSaverActive
        {
            get
            {
                return this.m_ScreenSaverActive;
            }
            set
            {
                this.m_ScreenSaverActive = value;
            }
        }
        
        public string ScreenSaverExecutable
        {
            get
            {
                return this.m_ScreenSaverExecutable;
            }
            set
            {
                this.m_ScreenSaverExecutable = value;
            }
        }
        
        public bool ScreenSaverSecure
        {
            get
            {
                return this.m_ScreenSaverSecure;
            }
            set
            {
                this.m_ScreenSaverSecure = value;
            }
        }
        
        public uint ScreenSaverTimeout
        {
            get
            {
                return this.m_ScreenSaverTimeout;
            }
            set
            {
                this.m_ScreenSaverTimeout = value;
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
        
        public string Wallpaper
        {
            get
            {
                return this.m_Wallpaper;
            }
            set
            {
                this.m_Wallpaper = value;
            }
        }
        
        public bool WallpaperStretched
        {
            get
            {
                return this.m_WallpaperStretched;
            }
            set
            {
                this.m_WallpaperStretched = value;
            }
        }
        
        public bool WallpaperTiled
        {
            get
            {
                return this.m_WallpaperTiled;
            }
            set
            {
                this.m_WallpaperTiled = value;
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
