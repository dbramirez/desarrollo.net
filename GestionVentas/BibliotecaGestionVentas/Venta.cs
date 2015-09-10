using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaGestionVentas
{
    public class Venta
    {
        private Vendedor _vendedor;
        private Cliente _cliente;
        private Producto _producto;
        private string _codigoVenta;

        public Vendedor Vendedor
        {
            get { return _vendedor; }
            set { _vendedor = value; }
        }
        
        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public Producto Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        public string CodigoVenta
        {
            get { return _codigoVenta; }
            set { _codigoVenta = value; }
        }

        public Venta()
        {
            this.Init();
        }

        private void Init()
        {
            
        }

        public Venta(Vendedor vend, Cliente clie, Producto pro, string codVe)
        {
            vend = Vendedor;
            clie = Cliente;
            pro = Producto;
            codVe = CodigoVenta;
        }


        
    }
}
