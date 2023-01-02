using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wpfCreaExcel
{
    class TaskInfo
    {
        
        private int _hilo;
        public int hilo
        {
            get { return _hilo; }
            set
            {
                if (_hilo != value)
                {
                    _hilo = value;
                }
            }
        }

        private int _max;
        public int max
        {
            get { return _max; }
            set
            {
                if (_max != value)
                {
                    _max = value;
                }
            }
        }

        private int _mal;
        public int mal
        {
            get { return _mal; }
            set
            {
                if (_mal != value)
                {
                    _mal = value;
                }
            }
        }

        private string _mensaje;
        public string mensaje
        {
            get { return _mensaje; }
            set
            {
                if (_mensaje != value)
                {
                    _mensaje = value;
                }
            }
        }

        private string _cmbOHE;
        public string cmbOHE
        {
            get { return _cmbOHE; }

            set
            {
                if (_cmbOHE != value)
                {
                    _cmbOHE = value;
                }
            }
        }

        private string _cmbEmision;
        public string CmbEmision
        {
            get { return _cmbEmision; }

            set
            {
                if (_cmbEmision != value)
                {
                    _cmbEmision = value;
                }
            }

        }

        private DataGridView _datosRif;
        public DataGridView DatosRif
        {
            get { return _datosRif; }

            set
            {
                if (_datosRif != value)
                {
                    _datosRif = value;
                }
            }
        }

        private Button _guardar;
        public Button Guardar {
            get { return _guardar; }

            set
            {
                if (_guardar != value)
                {
                    _guardar = value;
                }
            }
        }

        public string tipoMulta { get; set; }
    }
}
