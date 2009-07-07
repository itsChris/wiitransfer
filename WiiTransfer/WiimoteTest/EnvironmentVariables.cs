using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WiimoteTest
{
    public class EnvironmentVariables: INotifyPropertyChanged
    {

        public EnvironmentVariables()
        {
            SignalAdjustment = 6;
            EpsilonMaxim = 5;
            ScaleAdjustment = 1;
            Running = true;
            TimeZoom = 50;
            SignalZoom = 1;
        }

        int _signalAdjustment;
        public int SignalAdjustment
        {
            get
            {
                return _signalAdjustment;
            }
            set
            {
                _signalAdjustment = value;
                RaisePropertyChanged("SignalAdjustment");
            }
        }
        int _epsilonMax;
        public int EpsilonMaxim {
            get
            {
                return _epsilonMax;
            }
            set
            {
                _epsilonMax = value;
                RaisePropertyChanged("EpsilonMaxim");
            }
        }
        double _scaleAdjustment;
        public double ScaleAdjustment
        {
            get
            {
                return _scaleAdjustment;
            }
            set
            {
                _scaleAdjustment = value;
                RaisePropertyChanged("ScaleAdjustment");
            }
        }

        bool _running;
        public bool Running
        {
            get
            {
                return _running;
            }
            set
            {
                _running = value;
                RaisePropertyChanged("Running");
            }
        }

        double _timeZoom;
        public double TimeZoom
        {
            get
            {
                return _timeZoom;
            }
            set
            {
                _timeZoom = value;
                RaisePropertyChanged("TimeZoom");
            }
        }

        double _signalZoom;
        public double SignalZoom
        {
            get
            {
                return _signalZoom;
            }
            set
            {
                _signalZoom = value;
                RaisePropertyChanged("SignalZoom");
            }
        }

        string _connectionStatus;
        public string ConnectionStatus
        {
            get
            {
                return _connectionStatus;
            }
            set
            {
                _connectionStatus = value;
                RaisePropertyChanged("ConnectionStatus");
            }
        }

        string _currentIP;
        public string CurrentIP
        {
            get
            {
                return _currentIP;
            }
            set
            {
                _currentIP = value;
                RaisePropertyChanged("CurrentIP");
            }
        }

        string _codeStatus;
        public string CodeStatus
        {
            get
            {
                return _codeStatus;
            }
            set
            {
                _codeStatus = value;
                RaisePropertyChanged("CodeStatus");
            }
        }

        string _code;
        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
                RaisePropertyChanged("Code");
            }
        }

        string _lastPassword;
        public string LastAcceptedPassword
        {
            get
            {
                return _lastPassword;
            }
            set
            {
                _lastPassword = value;
                RaisePropertyChanged("LastAcceptedPassword");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        #endregion
    }
}
