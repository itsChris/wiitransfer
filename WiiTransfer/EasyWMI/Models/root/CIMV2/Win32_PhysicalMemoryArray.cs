using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PhysicalMemoryArray : WMIBase
    {
        
        private string m_Caption;
        
        private string m_CreationClassName;
        
        private double m_Depth;
        
        private string m_Description;
        
        private double m_Height;
        
        private bool m_HotSwappable;
        
        private string m_InstallDate;
        
        private ushort m_Location;
        
        private string m_Manufacturer;
        
        private uint m_MaxCapacity;
        
        private ushort m_MemoryDevices;
        
        private ushort m_MemoryErrorCorrection;
        
        private string m_Model;
        
        private string m_Name;
        
        private string m_OtherIdentifyingInfo;
        
        private string m_PartNumber;
        
        private bool m_PoweredOn;
        
        private bool m_Removable;
        
        private bool m_Replaceable;
        
        private string m_SerialNumber;
        
        private string m_SKU;
        
        private string m_Status;
        
        private string m_Tag;
        
        private ushort m_Use;
        
        private string m_Version;
        
        private double m_Weight;
        
        private double m_Width;
        
        private string m_MyPath;
        
        public Win32_PhysicalMemoryArray()
        {
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
        
        public string CreationClassName
        {
            get
            {
                return this.m_CreationClassName;
            }
            set
            {
                this.m_CreationClassName = value;
            }
        }
        
        public double Depth
        {
            get
            {
                return this.m_Depth;
            }
            set
            {
                this.m_Depth = value;
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
        
        public double Height
        {
            get
            {
                return this.m_Height;
            }
            set
            {
                this.m_Height = value;
            }
        }
        
        public bool HotSwappable
        {
            get
            {
                return this.m_HotSwappable;
            }
            set
            {
                this.m_HotSwappable = value;
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
        
        public ushort Location
        {
            get
            {
                return this.m_Location;
            }
            set
            {
                this.m_Location = value;
            }
        }
        
        public string Manufacturer
        {
            get
            {
                return this.m_Manufacturer;
            }
            set
            {
                this.m_Manufacturer = value;
            }
        }
        
        public uint MaxCapacity
        {
            get
            {
                return this.m_MaxCapacity;
            }
            set
            {
                this.m_MaxCapacity = value;
            }
        }
        
        public ushort MemoryDevices
        {
            get
            {
                return this.m_MemoryDevices;
            }
            set
            {
                this.m_MemoryDevices = value;
            }
        }
        
        public ushort MemoryErrorCorrection
        {
            get
            {
                return this.m_MemoryErrorCorrection;
            }
            set
            {
                this.m_MemoryErrorCorrection = value;
            }
        }
        
        public string Model
        {
            get
            {
                return this.m_Model;
            }
            set
            {
                this.m_Model = value;
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
        
        public string OtherIdentifyingInfo
        {
            get
            {
                return this.m_OtherIdentifyingInfo;
            }
            set
            {
                this.m_OtherIdentifyingInfo = value;
            }
        }
        
        public string PartNumber
        {
            get
            {
                return this.m_PartNumber;
            }
            set
            {
                this.m_PartNumber = value;
            }
        }
        
        public bool PoweredOn
        {
            get
            {
                return this.m_PoweredOn;
            }
            set
            {
                this.m_PoweredOn = value;
            }
        }
        
        public bool Removable
        {
            get
            {
                return this.m_Removable;
            }
            set
            {
                this.m_Removable = value;
            }
        }
        
        public bool Replaceable
        {
            get
            {
                return this.m_Replaceable;
            }
            set
            {
                this.m_Replaceable = value;
            }
        }
        
        public string SerialNumber
        {
            get
            {
                return this.m_SerialNumber;
            }
            set
            {
                this.m_SerialNumber = value;
            }
        }
        
        public string SKU
        {
            get
            {
                return this.m_SKU;
            }
            set
            {
                this.m_SKU = value;
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
        
        public string Tag
        {
            get
            {
                return this.m_Tag;
            }
            set
            {
                this.m_Tag = value;
            }
        }
        
        public ushort Use
        {
            get
            {
                return this.m_Use;
            }
            set
            {
                this.m_Use = value;
            }
        }
        
        public string Version
        {
            get
            {
                return this.m_Version;
            }
            set
            {
                this.m_Version = value;
            }
        }
        
        public double Weight
        {
            get
            {
                return this.m_Weight;
            }
            set
            {
                this.m_Weight = value;
            }
        }
        
        public double Width
        {
            get
            {
                return this.m_Width;
            }
            set
            {
                this.m_Width = value;
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
        
        public Int32 IsCompatible(string ElementToCheck)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_PhysicalMemoryArray");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("IsCompatible");
InParams["ElementToCheck"] = ElementToCheck;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "IsCompatible", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}
