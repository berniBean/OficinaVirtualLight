using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    public class CNombreBimestreBO : INotifyPropertyChanged
    {
        private string _ohe;

        public string OHE
        {
            get { return _ohe; }
            set
            {
                _ohe = value;
                OnPropertyChanged(new PropertyChangedEventArgs("OHE"));
            }
        }

        private string _nombreEmision;
        public string NombreEmision
        {
            get { return _nombreEmision; }
            set { _nombreEmision = value; }
        }

        private string _refNum;
        public string RefNum
        {
            get { return _refNum; }
            set { _refNum = value; }

        }

        private DateTime _fechaEmision;
        public DateTime FechaEmision
        {
            get { return _fechaEmision; }
            set { _fechaEmision = value; }
        }

        private int _total;
        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }

        private bool _modificado;
        public bool Modificado
        {
            get { return _modificado; }
            set { _modificado = value; }

        }

        public CNombreBimestreBO() { }

        public CNombreBimestreBO(string NombreEmision, string OHEActivo, DateTime FechaEmision, int Total)
        {
            _nombreEmision = NombreEmision;
            _ohe = OHEActivo;
            _fechaEmision = FechaEmision;
            _total = Total;
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
