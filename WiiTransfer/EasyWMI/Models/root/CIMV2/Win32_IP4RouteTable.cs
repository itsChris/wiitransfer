using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_IP4RouteTable : WMIBase
    {
        
        private uint m_Age;
        
        private string m_Caption;
        
        private string m_Description;
        
        private string m_Destination;
        
        private string m_Information;
        
        private string m_InstallDate;
        
        private int m_InterfaceIndex;
        
        private string m_Mask;
        
        private int m_Metric1;
        
        private int m_Metric2;
        
        private int m_Metric3;
        
        private int m_Metric4;
        
        private int m_Metric5;
        
        private string m_Name;
        
        private string m_NextHop;
        
        private uint m_Protocol;
        
        private string m_Status;
        
        private uint m_Type;
        
        private string m_MyPath;
        
        public Win32_IP4RouteTable()
        {
        }
        
        public uint Age
        {
            get
            {
                return this.m_Age;
            }
            set
            {
                this.m_Age = value;
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
        
        public string Destination
        {
            get
            {
                return this.m_Destination;
            }
            set
            {
                this.m_Destination = value;
            }
        }
        
        public string Information
        {
            get
            {
                return this.m_Information;
            }
            set
            {
                this.m_Information = value;
            }
        }
        
        public string InstallDate
        {
            get
            {
                return this.m_InstallDate;
            }
            set
            {
                this.m_InstallDate = value;
            }
        }
        
        public int InterfaceIndex
        {
            get
            {
                return this.m_InterfaceIndex;
            }
            set
            {
                this.m_InterfaceIndex = value;
            }
        }
        
        public string Mask
        {
            get
            {
                return this.m_Mask;
            }
            set
            {
                this.m_Mask = value;
            }
        }
        
        public int Metric1
        {
            get
            {
                return this.m_Metric1;
            }
            set
            {
                this.m_Metric1 = value;
            }
        }
        
        public int Metric2
        {
            get
            {
                return this.m_Metric2;
            }
            set
            {
                this.m_Metric2 = value;
            }
        }
        
        public int Metric3
        {
            get
            {
                return this.m_Metric3;
            }
            set
            {
                this.m_Metric3 = value;
            }
        }
        
        public int Metric4
        {
            get
            {
                return this.m_Metric4;
            }
            set
            {
                this.m_Metric4 = value;
            }
        }
        
        public int Metric5
        {
            get
            {
                return this.m_Metric5;
            }
            set
            {
                this.m_Metric5 = value;
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
        
        public string NextHop
        {
            get
            {
                return this.m_NextHop;
            }
            set
            {
                this.m_NextHop = value;
            }
        }
        
        public uint Protocol
        {
            get
            {
                return this.m_Protocol;
            }
            set
            {
                this.m_Protocol = value;
            }
        }
        
        public string Status
        {
            get
            {
                return this.m_Status;
            }
            set
            {
                this.m_Status = value;
            }
        }
        
        public uint Type
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
