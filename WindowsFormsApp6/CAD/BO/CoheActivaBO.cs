using System;
using System.ComponentModel;

namespace WindowsFormsApp6.CAD.BO
{
    public class CoheActivaBO : INotifyPropertyChanged
    {
        private string _ohe;

        public string OHE {
            get { return _ohe; }
            set { _ohe = value;
                OnPropertyChanged(new PropertyChangedEventArgs("OHE"));
            }
        }

        public CoheActivaBO() { }

        public CoheActivaBO(string OHEActivo ) {
            _ohe = OHEActivo;
        }


        private string _nombreEmision;
        public string NombreEmision
        {
            get { return _nombreEmision; }
            set { _nombreEmision = value; }
        }

        private bool _modificado;
        public bool Modificado
        {
            get { return _modificado; }
            set { _modificado = value; }

        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                _modificado = true;
                PropertyChanged(this, e);
            }
        }
    }
}
