using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.BO
{
   public class CanhoFiscalBO : INotifyPropertyChanged
    {
        private int _anho;
        public int Anho {
            get { return _anho; }
            set {
                _anho = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Nombre"));
            }
        }

        public CanhoFiscalBO() { }
        public CanhoFiscalBO(int anhoF) {
            _anho = anhoF;
        }

        private bool _modificado;
        public bool Modificado {
            get { return _modificado; }
            set { _modificado = value; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null) {
                _modificado = true;
                PropertyChanged(this, e);
            }
        }

        
    }
}
