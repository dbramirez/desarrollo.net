using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaGestionVentas
{
    public class Producto
    {
        private string _codigo;
        private string _nombreProducto;
        private int _stock;

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string NombreProducto
        {
            get { return _nombreProducto; }
            set { _nombreProducto = value; }
        }

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public Producto()
        {
            this.Init();
        }

        private void Init()
        {
            
        }

        public Producto(string cod, string nomP, int stk)
        {
            cod = Codigo;
            nomP = NombreProducto;
            stk = Stock;
        }
    }
}
