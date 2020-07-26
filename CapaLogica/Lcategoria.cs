using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace GelateriaNonnos.CapaLogica
{
    class Lcategoria
    {
        //Método Insertar que llama al método Insertar de la clase DCategoría de la CapaDatos
        public static string Insertar(string nombre, string descripcion)
        {
            Dcategoria Obj = new Dcategoria();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DCategoría de la CapaDatos
        public static string Editar(int idcategoria, string nombre, string descripcion)
        {
            Dcategoria Obj = new Dcategoria();
            Obj.Idcategoria = idcategoria;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DCategoría de la CapaDatos
        public static string Eliminar(int idcategoria)
        {
            Dcategoria Obj = new Dcategoria();
            Obj.Idcategoria = idcategoria;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DCategoría de la CapaDatos
        public static DataTable Mostrar()
        {
            return new Dcategoria().Mostrar();
        }

        //Método BuscarNombre que llama al método BuscarNombre de la clase DCategoría de la CapaDatos

        public static DataTable BuscarNombre(string textobuscar)
        {
            Dcategoria Obj = new Dcategoria();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
