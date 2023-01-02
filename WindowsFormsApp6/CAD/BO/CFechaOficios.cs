using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    class CFechaOficios : INotifyPropertyChanged
    {

        public bool ModificadoOficio { get; set; }
        public bool ModificadoRetro { get; set; }
        public string _idEmision { get; set; }
        
        private DateTime _fechaOficio;        
        public DateTime FechaOficio
        {
            get { return _fechaOficio; }
            set
            {
                _fechaOficio = value;
                OnPropertyChangedOficio(new PropertyChangedEventArgs("FechaOficio"));
            }

        }

        private void OnPropertyChangedOficio(PropertyChangedEventArgs e)
        {
            if(PropertyChanged != null)
            {
                ModificadoOficio = true;
                PropertyChanged(this, e);
            }
        }

        private DateTime _fechaRetro;
        public DateTime FechaRetro
        {
            get { return _fechaRetro; }

            set
            {
                _fechaRetro = value;
                OnPropertyChangedRetro(new PropertyChangedEventArgs("FechaRetro"));
            }
        }

        private void OnPropertyChangedRetro(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                ModificadoRetro = true;
                PropertyChanged(this, e);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
