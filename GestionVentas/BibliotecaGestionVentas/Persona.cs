using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaGestionVentas
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private string _id;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
       
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Persona()
        {
            this.Init();
        }

        private void Init()
        {
            
        }

        public Persona(string nom, string ape, string id)
        {
            nom = Nombre;
            ape = Apellido;
            id = Id;
        }




    }
}
