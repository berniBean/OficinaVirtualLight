using CleanArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    public class DirectorioBO : IDirectorio, IDirectorioConnections, INotifyPropertyChanged
    {
        public int IdClaveOHE { get; set; }
        
        private string _genero;
        public string Genero 
        { 
            get { return _genero; } 
            set {
                _genero = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Genero"));
            } 
        }
        private string _jefe;
        public string Jefe 
        { 
            get { return _jefe; }
            set
            {
                _jefe = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Jefe"));
            } 
        
        }
        private string _domicilio;
        public string Domicilio
        {
            get { return _domicilio; }
            set
            {
                _domicilio = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Domicilio"));
            }
        }
        private string _cp;
        public string Cp 
        {
            get { return _cp; } 
            set 
            {
                _cp = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Cp"));
            } 
        }
        public ICollection<IOficinaHacienda> Oficinas { get; set; } = new List<IOficinaHacienda>();
        public ICollection<IDirCelular> DirCelularsAncla { get; set; } = new List<IDirCelular>();
        public ICollection<IDirCorreo> DirCorreosAncla { get; set;} = new List<IDirCorreo>();
        public ICollection<IDirTelefono> DirTelefonosAncla { get; set;} = new List<IDirTelefono>();
        public List<IDirectorio> Directorios { get; set; } = new List<IDirectorio>();

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                _modificado = true;
                PropertyChanged(this, e);
            }
        }
        private bool _modificado;
        public bool Modificado
        {
            get { return _modificado; }
            set { _modificado = value; }

        }
        public void LimpiarDirectorio()
        {
            Directorios.Clear();
        }

        public void LimpiarCelular()
        {
            DirCelularsAncla.Clear();
        }
        public void LimpiarCorreos()
        {
            DirCorreosAncla.Clear();
        }
        public void LimpiarTelefonos()
        {
            DirTelefonosAncla.Clear();
        }

    }
}
