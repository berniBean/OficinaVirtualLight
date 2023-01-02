using CleanArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Concretas
{
    public class fechaOficios : INotifyPropertyChanged, IFechaOficios
    {
        private string _idEmision;
        private DateTime _fechaRetro;
        private DateTime _fechaOficio;

        public fechaOficios()
        {

        }
        public fechaOficios(string idEmision, DateTime fechaRetro, DateTime fechaOficio)
        {
            _idEmision = idEmision;
            _fechaRetro = fechaRetro;
            _fechaOficio = fechaOficio;
        }

        public string IdEmision { get; set; }
        public DateTime FechaRetro 
        {
            get { return _fechaRetro; }

            set 
            { 
                _fechaRetro = value;
                OnPropertyChangedRetro(new PropertyChangedEventArgs("FechaRetro"));
            }
        }
        public DateTime FechaOficios 
        {
            get { return _fechaOficio; }
            set
            {
                _fechaOficio = value;
                OnPropertyChangedOficio(new PropertyChangedEventArgs("FechaOficio"));
            }
        }

        public DateTime FormantFechas(string fecha)
        {
            
            return Convert.ToDateTime(fecha is "  /  /" ? null : fecha);
        }

        public DateTime FormantFechasNull(string fecha)
        {

            return Convert.ToDateTime(fecha is "0001/01/01" ? "  /  /" : fecha);
        }

        public bool ModificadoOficio { get; set; }
        public bool ModificadoRetro { get; set; }

        private void OnPropertyChangedRetro(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                ModificadoRetro = true;
                PropertyChanged(this, e);
            }
        }

        private void OnPropertyChangedOficio(PropertyChangedEventArgs e)
    {
            if (PropertyChanged != null)
            {
                ModificadoOficio = true;
                PropertyChanged(this, e);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


    }
}
