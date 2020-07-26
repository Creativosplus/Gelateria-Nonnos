using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace GelateriaNonnos.CapaLogica
{
    class Ltrabajador
    {
        //Métodos para comunicarnos con la capa datos
        //Método Insertar que llama al método Insertar de la clase Drabajador
        //de la CapaDatos
        public static string Insertar(string nombre, string apellidos, string sexo,
            DateTime fecha_nacimiento, string num_cedula,
            string direccion, string telefono, string email, string acceso,
            string usuario, string pass)
        {
            Dtrabajador Obj = new Dtrabajador();
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Num_Documento = num_cedula;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Password = pass;

            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DTrabajador
        //de la CapaDatos
        public static string Editar(int idtrabajador, string nombre, string apellidos,
            string sexo,
            DateTime fecha_nacimiento, string num_cedula,
            string direccion, string telefono, string email, string acceso, string usuario,
            string pass)
        {
            Dtrabajador Obj = new Dtrabajador();
            Obj.Idtrabajador = idtrabajador;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Num_Documento = num_cedula;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Password = pass;
            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DTrabajador
        //de la CapaDatos
        public static string Eliminar(int idtrabajador)
        {
            Dtrabajador Obj = new Dtrabajador();
            Obj.Idtrabajador = idtrabajador;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DTrabajador
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new Dtrabajador().Mostrar();
        }

        //Método BuscarApellidos que llama al método BuscarApellidos
        //de la clase DTrabajador de la CapaDatos

        public static DataTable BuscarApellidos(string textobuscar)
        {
            Dtrabajador Obj = new Dtrabajador();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarApellidos(Obj);
        }

        //Método BuscarNum_Documento que llama al método BuscarNum_Documento
        //de la clase DTRabajador de la CapaDatos

        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            Dtrabajador Obj = new Dtrabajador();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }

        public static DataTable Login(string usuario, string password)
        {
            Dtrabajador Obj = new Dtrabajador();
            Obj.Usuario = usuario;
            Obj.Password = pass;
            return Obj.Login(Obj);
        }
    }
}
