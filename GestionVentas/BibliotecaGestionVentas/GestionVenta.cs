using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaGestionVentas
{
    public class GestionVenta
    {
        private List<Venta> _ventas;

        public List<Venta> Ventas
        {
            get { return _ventas; }
            set { _ventas = value; }
        }

        public GestionVenta()
        {
            this.Init();
        }

        private void Init()
        {
            _ventas=new List<Venta>();
        }

        public void AgregarVenta(Venta ven)
        {
            Ventas.Add(ven);
        }


    }
}
