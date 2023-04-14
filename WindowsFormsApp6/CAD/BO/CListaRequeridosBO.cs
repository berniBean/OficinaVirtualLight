using System;
using System.ComponentModel;

namespace WindowsFormsApp6.CAD.BO
{
    public class CListaRequeridosBO : INotifyPropertyChanged , IEquatable<CListaRequeridosBO>
    {

        public string _idMultaRif { get; set; }
        public string _tipoMulta { get; set; }

        public int _numMulta { get; set; }

        

        private string _ejecucion;

        public string Ejecucion
        {
            get { return _ejecucion; }
            set 
            {
                _ejecucion = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Ejecucion"));
            } 
        
        }
        private int _numReq;
        public int NumReq
        {
            get { return _numReq; }
            set {
                _numReq = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Nombre"));
            }
        }

        private string _RFC;
        public string Rfc {
            get { return _RFC; }
            set {
                _RFC = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Rfc"));
            }
        }

        private string _numCtrl;
        public string NumCtrl
        {
            get { return _numCtrl; }
            set
            {
                _numCtrl = value;
                OnPropertyChanged(new PropertyChangedEventArgs("NumCtrl"));
            }
        }

        public string _detalleEmision { get; set; }

        private string _razonSocial;
        public string RazonSocial
        {
            get { return _razonSocial; }
            set
            {
                _razonSocial = value;
                OnPropertyChanged(new PropertyChangedEventArgs("RazonSocial"));
            }
        }

        private string _localidad;
        public string Localidad
        {
            get { return _localidad; }
            set
            {
                _localidad = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Localidad"));
            }
        }


        private string _diligencia;
        public string Diligencia
        {
            get { return _diligencia; }
            set
            {
                _diligencia = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Diligencia"));
            }
        }

        private DateTime _fechaNotificacion;
        public DateTime FechaNotificacion
        {
            get { return _fechaNotificacion; }
            set
            {
                _fechaNotificacion = value;
                OnPropertyChanged(new PropertyChangedEventArgs("FechaNotificacion"));
            }
        }

        private DateTime _fechaPago;
        public DateTime FechaPago
        {
            get { return _fechaPago; }
            set {
                    _fechaPago = value;

                OnPropertyChanged(new PropertyChangedEventArgs("FechaPago")); 
                }
        }



        private Double _importe;

        public Double Importe 
        {
            get { return _importe; }
            set {
                     _importe = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Importe")); 
                }
        }

        private Double _honorarios;

        public Double Honorarios
        {
            get { return _honorarios; }
            set 
            {
                _honorarios = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Honorarios"));
            }
        }


        private bool _cumplioAntes;

        public bool CumplioAntes
        {
            get { return _cumplioAntes; }
            set {
                    _cumplioAntes = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("CumplioAntes")); 
                }
        }



        public DateTime _fechaVencimiento { get; set; }
        private DateTime __fechaCitatorio;
        public DateTime FechaCitatorio
        {
            get { return __fechaCitatorio; }
            set
            {
                __fechaCitatorio = value;
                OnPropertyChanged(new PropertyChangedEventArgs("FechaCitatorio"));
            }
        }
        private string _oficioSEFIPLAN;
        public string OficioSEFIPLAN
        {
            get { return _oficioSEFIPLAN; }
            set
            {
                _oficioSEFIPLAN = value;
                OnPropertyChanged(new PropertyChangedEventArgs("OficioSEFIPLAN"));
            }
        }

        private DateTime _fechaEnvioSefiplan;
        public DateTime FechaEnvioSefiplan
        {
            get { return _fechaEnvioSefiplan; }
            set
            {
                _fechaEnvioSefiplan = value;
                OnPropertyChanged(new PropertyChangedEventArgs("FechaEntregaNotificador"));
            }
        }

        private DateTime _fechaEntregaNotificador;
        public DateTime FechaEntregaNotificador
        {
            get { return _fechaEntregaNotificador; }
            set
            {
                _fechaEntregaNotificador = value;
                OnPropertyChanged(new PropertyChangedEventArgs("FechaEntregaNotificador"));
            }
        }

        private DateTime _fechaRecepcion;
        public DateTime FechaRecepcion
        {
            get { return _fechaRecepcion; }
            set
            {
                _fechaRecepcion = value;
                OnPropertyChanged(new PropertyChangedEventArgs("FechaRecepcion"));
            }
        }

        private string _nombreNotificador;
        public string NombreNotificador
        {
            get { return _nombreNotificador; }
            set
            {
                _nombreNotificador = value;
                OnPropertyChanged(new PropertyChangedEventArgs("NombreNotificador"));
            }
        }
        private string _estatus;
        public string Estatus
        {
            get { return _estatus; }
            set
            {
                _estatus = value;
            }
        }

        private string _observaciones;
        public string NotasObservaciones { get; set; }
        public string Observaciones
        {
            get { return _observaciones; }
            set
            {
                _observaciones = value;
                OnPropertyChangedObservacion(new PropertyChangedEventArgs("Observaciones"));
            }
        }
        private bool _malCapturado;
        public bool MalCapturado
        {
            get { return _malCapturado; }
            set
            {
                _malCapturado = value;
                OnPropertyChangedMalCaputurado(new PropertyChangedEventArgs("MalCapturado"));
            }
        }

        private bool _actaNotificacion;
        public bool ActaNotificacion
        {
            get { return _actaNotificacion; }
            set
            {
                _actaNotificacion = value;
                OnPropertyChangedMalCaputurado(new PropertyChangedEventArgs("ActaNotificacion"));
            }
        }
        private bool _actaCitatorio;
        public bool ActaCitatorio
        {
            get { return _actaCitatorio; }
            set
            {
                _actaCitatorio = value;
                OnPropertyChangedMalCaputurado(new PropertyChangedEventArgs("ActaCitatorio"));
            }
        }
        private bool _notificacionCitatorio;
        public bool NotificacionCitatorio
        {
            get { return _notificacionCitatorio; }
            set
            {
                _notificacionCitatorio = value;
                OnPropertyChangedMalCaputurado(new PropertyChangedEventArgs("NotificacionCitatorio"));
            }
        }



        private bool _modificado;
        public bool Modificado
        {
            get { return _modificado; }
            set { _modificado = value; }
        }

        private bool _modificadoMalCapturado;
        public bool ModificaMalCapturado
        {
            get { return _modificadoMalCapturado; }
            set { _modificadoMalCapturado = value; }
        }

        private bool _modificaActaNotificacion;
        public bool ModificaActaNotificacion
        {
            get { return _modificaActaNotificacion; }
            set { _modificaActaNotificacion = value; }
        }

        private bool _modificaCitatorio;
        public bool ModificaCitatorio
        {
            get { return _modificaCitatorio; }
            set { _modificaCitatorio = value; }
        }

        private bool _modificaNotificacionCitatorio;
        public bool ModificaNotificacionCitatorio
        {
            get { return _modificaNotificacionCitatorio; }
            set { _modificaNotificacionCitatorio = value; }
        }

        private bool _modificaObservacion;
        public bool ModificaObservacion
        {
            get { return _modificaObservacion; }
            set { _modificaObservacion = value; }
        }

        private bool _modificaEjecucion;
        public bool ModificaEjecicion
        {
            get { return _modificaEjecucion; }
            set { _modificaEjecucion = value; }
        }

        private bool _modificaFechaPago;
        public bool ModificaFechaPago
        {
            get { return _modificaFechaPago; }
            set { _modificaFechaPago = value; }
        }
        

        public string _zona { get; set; }
        public string _OHE { get; set; }
        public string _estatusPDF { get; set; }
        public string _tipoc { get; set; }
        public CListaRequeridosBO() { }

        public CListaRequeridosBO(int numReq, string RFC, string numCtrl, string razonSocial, string localidad)
        {
            _numReq = numReq;
            _RFC = RFC;
            _numCtrl = numCtrl;
            _razonSocial = razonSocial;
            _localidad = localidad;
        }

        
        //constructor para requerimientos
        public CListaRequeridosBO(
            int numReq, 
            string RFC, 
            string numCtrl, 
            string razonSocial, 
            string localidad,
            string diligencia, 
            DateTime fechaNotificacion, 
            DateTime fechaCitatorio, 
            string oficioSEFIPLAN,
            DateTime fechaEnvioSefiplan, 
            DateTime fechaEntregaNotificador, 
            DateTime fechaRecepcion, 
            string estatus,
            bool malCapturado,
            bool actaNotificacion, 
            bool actaCitatorio, 
            bool notificacionCitatorio,
            string observaciones, 
            string nombreNotificador) {
            _numReq = numReq;
            _RFC = RFC;
            _numCtrl = numCtrl;
            _razonSocial = razonSocial;
            _localidad = localidad;
            _diligencia = diligencia;
            _fechaNotificacion = fechaNotificacion;
            __fechaCitatorio = fechaCitatorio;
            _oficioSEFIPLAN = oficioSEFIPLAN;
            _fechaEntregaNotificador = fechaEntregaNotificador;
            _fechaRecepcion = fechaRecepcion;
            _fechaEnvioSefiplan = fechaEnvioSefiplan;
            
            _malCapturado = malCapturado;
            _actaNotificacion = actaNotificacion;
            _actaCitatorio = actaCitatorio;
            _notificacionCitatorio = notificacionCitatorio;           
            _estatus = estatus;

            _nombreNotificador = nombreNotificador;
            _observaciones =observaciones;
        }
        //constructor para multas
        public CListaRequeridosBO(
            string IdMultaRif,
            string TipoMulta, 
            int NumMulta, 
            string RFC, 
            string NumCtrl, 
            string RazonSocial, 
            string DetalleEmision,
            int NumReq,                     
            string diligencia,
            DateTime FechaCitatorio, 
            DateTime FechaNotificacion, 
            DateTime FechaPago, 
            Double importe, 
            Double Honararios,
            bool Cumplido,
            DateTime FechaVencimiento, 
            string Observaciones, 
            string Ejecucion,
            string Estatus) 
        {
            _idMultaRif = IdMultaRif;
            _tipoMulta = TipoMulta;
            _numMulta = NumMulta;
            _RFC = RFC;            
            _numCtrl = NumCtrl;
            _razonSocial = RazonSocial;
            _detalleEmision = DetalleEmision;
            _numReq = NumReq;
            _diligencia = diligencia;
            __fechaCitatorio = FechaCitatorio;
            _fechaNotificacion = FechaNotificacion;
            _fechaPago = FechaPago;
            _importe = importe;
            _honorarios = Honararios;
            _cumplioAntes = Cumplido;
            _fechaVencimiento = FechaVencimiento;
            _observaciones = Observaciones;
            _ejecucion = Ejecucion;
            _estatus = Estatus;
            

        }

        public CListaRequeridosBO(
            string zona,
            string ohe,
            string IdMultaRif,
            string TipoMulta,
            int NumMulta,
            string RFC,
            string Tipoc,
            string NumCtrl,
            string RazonSocial,
            string DetalleEmision,
            int NumReq,
            string diligencia,
            DateTime FechaCitatorio,
            DateTime FechaNotificacion,
            DateTime FechaPago,
            Double importe,
            Double Honararios,
            bool Cumplido,
            DateTime FechaVencimiento,
            string Observaciones,
            string Ejecucion,
            string Estatus,
            string EstatusPDF)
        {
            _zona = zona;
            _OHE = ohe;
            _idMultaRif = IdMultaRif;
            _tipoMulta = TipoMulta;
            _numMulta = NumMulta;
            _RFC = RFC;
            _tipoc = Tipoc;
            _numCtrl = NumCtrl;
            _razonSocial = RazonSocial;
            _detalleEmision = DetalleEmision;
            _numReq = NumReq;
            _diligencia = diligencia;
            __fechaCitatorio = FechaCitatorio;
            _fechaNotificacion = FechaNotificacion;
            _fechaPago = FechaPago;
            _importe = importe;
            _honorarios = Honararios;
            _cumplioAntes = Cumplido;
            _fechaVencimiento = FechaVencimiento;
            _observaciones = Observaciones;
            _ejecucion = Ejecucion;
            _estatus = Estatus;
            _estatusPDF = EstatusPDF;

        }
        //RIF
        public CListaRequeridosBO(
            string zona,
            string ohe,
            string IdMultaRif,
            string TipoMulta,
            int NumMulta,
            string RFC,
            string NumCtrl,
            string RazonSocial,
            string DetalleEmision,
            int NumReq,
            string diligencia,
            DateTime FechaCitatorio,
            DateTime FechaNotificacion,
            DateTime FechaPago,
            Double importe,
            Double Honararios,
            bool Cumplido,
            DateTime FechaVencimiento,
            string Observaciones,
            string Ejecucion,
            string Estatus,
            string EstatusPDF)
        {
            _zona = zona;
            _OHE = ohe;
            _idMultaRif = IdMultaRif;
            _tipoMulta = TipoMulta;
            _numMulta = NumMulta;
            _RFC = RFC;            
            _numCtrl = NumCtrl;
            _razonSocial = RazonSocial;
            _detalleEmision = DetalleEmision;
            _numReq = NumReq;
            _diligencia = diligencia;
            __fechaCitatorio = FechaCitatorio;
            _fechaNotificacion = FechaNotificacion;
            _fechaPago = FechaPago;
            _importe = importe;
            _honorarios = Honararios;
            _cumplioAntes = Cumplido;
            _fechaVencimiento = FechaVencimiento;
            _observaciones = Observaciones;
            _ejecucion = Ejecucion;
            _estatus = Estatus;
            _estatusPDF = EstatusPDF;

        }


        public CListaRequeridosBO(int numReq, string observaciones, bool malCapturado) {
            _numReq = numReq;
            _observaciones = observaciones;
            _malCapturado = malCapturado;
        }
        public CListaRequeridosBO(int numReq, string observaciones)
        {
            _numReq = numReq;
            _observaciones = observaciones;

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

        private void OnPropertyChangedMalCaputurado(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                _modificadoMalCapturado = true;
                PropertyChanged(this, e);
            }

        }

        private void OnPropertyChangedActaNotificacion(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                _modificaActaNotificacion = true;
                PropertyChanged(this, e);
            }
        }
        private void OnPropertyChangedActaCitatorio(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                _modificaCitatorio = true;
                PropertyChanged(this, e);
            }
        }

        private void OnPropertyChangedNotificacionCitatorio(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                _modificaNotificacionCitatorio = true;
                PropertyChanged(this, e);
            }
        }

        private void OnPropertyChangedObservacion(PropertyChangedEventArgs e)
        {
           if(PropertyChanged != null)
            {
                _modificaObservacion = true;
                PropertyChanged(this, e);
            }
        }

        private void OnPropertyChangedEjecucion(PropertyChangedEventArgs e)
        {
            if(PropertyChanged != null)
            {
                _modificaEjecucion = true;
                PropertyChanged(this, e);
            }
        }

        private void OnPropertyChangedFechaPago(PropertyChangedEventArgs e)
        {
           if(PropertyChanged != null)
            {
                _modificaFechaPago = true;
                PropertyChanged(this, e);

            }
        }

        public bool Equals(CListaRequeridosBO other)
        {
            if (this.NumCtrl == other.NumCtrl)
                return true;
            else
                return false;
        }
    }
}
