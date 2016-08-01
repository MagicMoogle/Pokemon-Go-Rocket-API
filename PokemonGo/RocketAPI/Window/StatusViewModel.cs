using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo.RocketAPI.Window
{
    public class StatusViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Status _status;
        private string _statusDetail;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Status Status
        {
            get { return _status; }
            set {
                if (_status != value)
                {
                    _status = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string StatusDetail
        {
            get { return _statusDetail; }
            set
            {
                if (_statusDetail != value)
                {
                    _statusDetail = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
