using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer15__Control_de_Inventario
{
    class Inventario
    {
        private int _numeroProductos;
        public int numeroProductos { get { return _numeroProductos; } }
        private Producto[] inventario;

        public Inventario() {
            _numeroProductos = 0;
            inventario = new Producto[15];
        }

        public void agregarProducto(Producto producto) {
            _numeroProductos++;
            inventario[numeroProductos-1] = producto;
        }

        public Producto buscarProducto(int codigo) {
            int contador = 0;
            bool productoEncontrado = false;
            while (contador < numeroProductos && productoEncontrado == false) {
                if (inventario[contador].codigo == codigo)
                    productoEncontrado = true;
                else 
                    contador++;
            }
            if (productoEncontrado == true)
                return inventario[contador];
            else
                return null;
        }

        public void eliminarProducto(int codigo) {
            int contador = 0;
            bool productoEncontrado = false;
            while (contador < numeroProductos && productoEncontrado == false ) {
                if (inventario[contador].codigo == codigo) {
                    for (int i = contador; i < (numeroProductos - 1); i++)
                        inventario[i] = inventario[i + 1];
                    _numeroProductos--;
                    inventario[numeroProductos + 1] = null;
                    productoEncontrado = true;
                }   
                else
                    contador++;
            }
        }

        public string reporte() {
            string texto = "";
            for (int i = 0; i < numeroProductos; i++)
                texto += inventario[i].ToString() + Environment.NewLine;
            return texto;
        }

        public void insertarProducto(Producto producto, int posicion) {
            _numeroProductos++;
            for (int contador = (numeroProductos-1); contador > posicion; contador--)
                inventario[contador] = inventario[contador - 1];
            inventario[posicion] = producto;
        }
    }
}
