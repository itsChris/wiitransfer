using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WiimoteTest
{
    class EnvironmentVariables: INotifyPropertyChanged
    {

        public EnvironmentVariables()
        {
            SignalAdjustment = 6;
            EpsilonMaxim = 5;
            ScaleAdjustment = 1;
            Running = true;
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

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        #endregion
    }
}
