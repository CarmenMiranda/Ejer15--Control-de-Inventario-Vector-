using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer15__Control_de_Inventario
{
    class Producto
    {
        private int _codigo;
        public int codigo { get { return _codigo; }}

        private string _nombre;
        public string nombre { get { return _nombre; }}

        private float _precio;
        public float precio { get { return _precio; }}

        private int _cantidad;
        public int cantidad{ get { return _cantidad; }}

        public Producto(int codigo, string nombre,float precio, int cantidad) {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
            _cantidad = cantidad;
        }

        public override string ToString(){
            string texto = "Producto"+Environment.NewLine;
            texto += "Código: " + codigo + Environment.NewLine + "Nombre: " + nombre + Environment.NewLine;
            texto += "Precio: $" + precio + Environment.NewLine + "Cantidad: " + cantidad + Environment.NewLine;
            return texto;
        }
    }
}
