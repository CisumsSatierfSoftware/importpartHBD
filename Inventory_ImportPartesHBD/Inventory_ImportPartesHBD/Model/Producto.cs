using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory_ImportPartesHBD.Model
{
    public class Producto
    {
        private String codigo;
        private String descripcion;
        private String ubicacion;
        private Double cantidad;
        private Double precio;

        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public String Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }

        public Double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string boton;
    }
}
