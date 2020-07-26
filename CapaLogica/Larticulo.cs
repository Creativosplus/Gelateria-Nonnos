using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GelaterinaNonnos.CapaDatos;
using System.Data;




namespace GelateriaNonnos.CapaLogica
{
    class Larticulo
    {
        //Método Insertar que llama al método Insertar de la clase Darticulo de la CapaDatos
        public static string Insertar(string codigo, string nombre, string descripcion, byte[] imagen, int idcategoria, int idpresentacion)
        {
            Larticulo Obj = new Larticulo();
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Imagen = imagen;
            Obj.Idcategoria = idcategoria;
            Obj.Idpresentacion = idpresentacion;

            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase Darticulo de la CapaDatos
        public static string Editar(int idarticulo, string codigo, string nombre, string descripcion, byte[] imagen, int idcategoria, int idpresentacion)
        {
            Larticulo Obj = new Larticulo();
            Obj.Idarticulo = idarticulo;
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Imagen = imagen;
            Obj.Idcategoria = idcategoria;
            Obj.Idpresentacion = idpresentacion;
            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase Darticulo de la CapaDatos
        public static string Eliminar(int idarticulo)
        {
            Larticulo Obj = new Larticulo();
            Obj.Idarticulo = idarticulo;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase Darticulo de la CapaDatos
        public static DataTable Mostrar()
        {
            return new Larticulo().Mostrar();
        }

        //Método BuscarNombre que llama al método BuscarNombre de la clase Darticulo de la CapaDatos

        public static DataTable BuscarNombre(string textobuscar)
        {
            Larticulo Obj = new Larticulo();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
        public static DataTable Stock_Articulos()
        {
            return new Larticulo().Stock_Articulos();
        }
    }
}
