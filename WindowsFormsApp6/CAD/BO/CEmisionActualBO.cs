using System;
using System.ComponentModel;

namespace WindowsFormsApp6.CAD.BO
{
    public class CEmisionActualBO: INotifyPropertyChanged
    {
        
        private int _periodo;
        public int Periodo {
            get{ return _periodo; }
            set {
                _periodo = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Periodo"));
            }
        }

        private string _nomEmision;
        public string NomEmision
        {
            get { return _nomEmision; }
            set { _nomEmision = value;
                OnPropertyChanged(new PropertyChangedEventArgs("NomEmision"));
            }
        }

        public DateTime _fechaImpresion { get; set; }

        public CEmisionActualBO() { }
        public CEmisionActualBO(int periodoAct) {
            _periodo = periodoAct;
        }

        public CEmisionActualBO(int periodoAct, string nomEmision, DateTime fechaImpresion)
        {
            _periodo = periodoAct;
            _nomEmision = nomEmision;
            _fechaImpresion = fechaImpresion;
        }

        private bool _modificado;
        public bool Modificado {
            get { return _modificado; }
            set { _modificado = value; }
  
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if(PropertyChanged != null) {
                _modificado = true;
                PropertyChanged(this, e);
            }
        }
    }
}
