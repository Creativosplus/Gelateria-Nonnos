using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace GelateriaNonnos.CapaLogica
{
    class Lventa
    {

        public static string Insertar(int idcliente, int idtrabajador, DateTime fecha,
            string tipo_comprobante, string serie, string correlativo, decimal impuesto,
            DataTable dtDetalles)
        {
            Dventa Obj = new Dventa();
            Obj.Idcliente = idcliente;
            Obj.Idtrabajador = idtrabajador;
            Obj.Fecha = fecha;
            Obj.Tipo_Comprobante = tipo_comprobante;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.Impuesto = impuesto;
            List<Ddetalle_venta> detalles = new List<Ddetalle_venta>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                Ddetalle_venta detalle = new Ddetalle_venta();
                detalle.Iddetalle_ingreso = Convert.ToInt32(row["iddetalle_ingreso"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["cantidad"].ToString());
                detalle.Precio_Venta = Convert.ToDecimal(row["precio_venta"].ToString());
                detalle.Descuento = Convert.ToDecimal(row["descuento"].ToString());
                detalles.Add(detalle);
            }
            return Obj.Insertar(Obj, detalles);
        }
        public static string Eliminar(int idventa)
        {
            Dventa Obj = new Dventa();
            Obj.Idventa = idventa;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DVenta
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new Dventa().Mostrar();
        }

        //Método BuscarFecha que llama al método BuscarFecha
        //de la clase DVenta de la CapaDatos

        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            Dventa Obj = new Dventa();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }

        public static DataTable MostrarDetalle(string textobuscar)
        {
            Dventa Obj = new Dventa();
            return Obj.MostrarDetalle(textobuscar);
        }
        public static DataTable MostrarArticulo_Venta_Nombre(string textobuscar)
        {
            Dventa Obj = new Dventa();
            return Obj.MostrarArticulo_Venta_Nombre(textobuscar);
        }
        public static DataTable MostrarArticulo_Venta_Codigo(string textobuscar)
        {
            Dventa Obj = new Dventa();
            return Obj.MostrarArticulo_Venta_codigo(textobuscar);
        }
    }
}
