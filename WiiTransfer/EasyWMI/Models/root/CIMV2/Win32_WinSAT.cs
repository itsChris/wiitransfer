using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_WinSAT : WMIBase
    {
        
        private double m_CPUScore;
        
        private double m_D3DScore;
        
        private double m_DiskScore;
        
        private double m_GraphicsScore;
        
        private double m_MemoryScore;
        
        private string m_TimeTaken;
        
        private uint m_WinSATAssessmentState;
        
        private double m_WinSPRLevel;
        
        private string m_MyPath;
        
        public Win32_WinSAT()
        {
        }
        
        public double CPUScore
        {
            get
            {
                return this.m_CPUScore;
            }
            set
            {
                this.m_CPUScore = value;
            }
        }
        
        public double D3DScore
        {
            get
            {
                return this.m_D3DScore;
            }
            set
            {
                this.m_D3DScore = value;
            }
        }
        
        public double DiskScore
        {
            get
            {
                return this.m_DiskScore;
            }
            set
            {
                this.m_DiskScore = value;
            }
        }
        
        public double GraphicsScore
        {
            get
            {
                return this.m_GraphicsScore;
            }
            set
            {
                this.m_GraphicsScore = value;
            }
        }
        
        public double MemoryScore
        {
            get
            {
                return this.m_MemoryScore;
            }
            set
            {
                this.m_MemoryScore = value;
            }
        }
        
        public string TimeTaken
        {
            get
            {
                return this.m_TimeTaken;
            }
            set
            {
                this.m_TimeTaken = value;
            }
        }
        
        public uint WinSATAssessmentState
        {
            get
            {
                return this.m_WinSATAssessmentState;
            }
            set
            {
                this.m_WinSATAssessmentState = value;
            }
        }
        
        public double WinSPRLevel
        {
            get
            {
                return this.m_WinSPRLevel;
            }
            set
            {
                this.m_WinSPRLevel = value;
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
