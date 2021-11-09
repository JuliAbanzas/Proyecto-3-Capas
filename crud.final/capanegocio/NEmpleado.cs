using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capanegocio;
using System.Data;
using capadatos;

namespace capanegocio
{
    public class NEmpleado
    {

        public static string insertarempleado(string name, string lastname,string cuilt,string telefono,string legajo,string email,
            string tipodocumento,string documento,string direccion
            )
        {
            DEmpleado objeto = new DEmpleado();
            objeto.Name = name;
            objeto.Lastname = lastname;
            objeto.Cuilt = cuilt;
            objeto.Telefono = telefono;
            objeto.Legajo = legajo;
            objeto.Email = email;
            objeto.Tipodocumento = tipodocumento;
            objeto.Documento = documento;
            objeto.Direccion = direccion;

            return objeto.insertarempleado(objeto);
        }
       

        public static string editarempleado(int idempleado,string name, string lastname, string cuilt, string telefono,string legajo,string email,
    string tipodocumento, string documento, string direccion
    )
        {
            DEmpleado objeto = new DEmpleado();
            objeto.Idempleado = idempleado;
            objeto.Name = name;
            objeto.Lastname = lastname;
            objeto.Cuilt = cuilt;
            objeto.Telefono = telefono;
            objeto.Legajo = legajo;
            objeto.Email = email;
            objeto.Tipodocumento = tipodocumento;
            objeto.Documento = documento;
            objeto.Direccion = direccion;

            return objeto.editarempleado(objeto);
        }

        public static string eliminarempleado(int idempleado
   )
        {
            DEmpleado objeto = new DEmpleado();
            objeto.Idempleado = idempleado;
       

            return objeto.eliminarempleado(objeto);
        }

        public static DataTable mostrarempleado(
  )
        {
            DEmpleado objeto = new DEmpleado();
            return objeto.mostrarempleados();
        }

        public static DataTable buscarempleadosnombre(string textobuscar
  )
        {
            DEmpleado objeto = new DEmpleado();
            objeto.Textobuscar = textobuscar;
            return objeto.buscarempleadonombre(objeto);
        }

        public static DataTable buscarempleadoapellidos(string textobuscar
  )
        {
            DEmpleado objeto = new DEmpleado();
            objeto.Textobuscar = textobuscar;
            return objeto.buscarempleadosapellidos(objeto);
        }

        public static string insertarempleado(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8)
        {
            throw new NotImplementedException();
        }

        public static string editarempleado(int v1, string v2, string v3, string v4, string v5)
        {
            throw new NotImplementedException();
        }
    }
}
