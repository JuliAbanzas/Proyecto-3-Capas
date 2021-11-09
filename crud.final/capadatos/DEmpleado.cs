using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace capadatos
{
    public class DEmpleado
    {

        private int _idempleado;
        private string _name;
        private string _lastname;
        private string _cuilt;
        private string _telefono;
        private string _legajo;
        private string _email;
        private string _tipodocumento;
        private string _documento;
        private string _direccion;
        private string _textobuscar;

        public int Idempleado { get => _idempleado; set => _idempleado = value; }
        public string Name { get => _name; set => _name = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }

        public string Cuilt { get => _cuilt; set => _cuilt = value; }

        public string Telefono { get => _telefono; set => _telefono = value; }

        public string Legajo { get => _legajo; set => _legajo = value; }

        public string Email { get => _email; set => _email = value; }

        public string Tipodocumento { get => _tipodocumento; set => _tipodocumento = value; }
        public string Documento { get => _documento; set => _documento = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        public DEmpleado()
        {
        }

        public DEmpleado(int idempleado, string name, string lastname, string cuilt,string telefono,string legajo,string email, string tipodocumento, string documento,string direccion, string textobuscar)
        {
            Idempleado = idempleado;
            Name = name;
            Lastname= lastname;
            Cuilt = cuilt;
            Telefono = telefono;
            Legajo = legajo;
            Email = email;
            Tipodocumento = tipodocumento; //dni 
            Documento = documento;      //numero de documento
            Direccion = direccion;
            Textobuscar = textobuscar;
        }


        public string insertarempleado(DEmpleado empleado)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@idempleado";
                ParIdempleado.SqlDbType =SqlDbType.Int ;
                ParIdempleado.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdempleado);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@name";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = empleado.Name;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParLastname = new SqlParameter();
                ParLastname.ParameterName = "@lastname";
                ParLastname.SqlDbType = SqlDbType.VarChar;
                ParLastname.Size = 80;
                ParLastname.Value = empleado.Lastname;
                SqlCmd.Parameters.Add(ParLastname);

                SqlParameter ParCuilt = new SqlParameter();
                ParCuilt.ParameterName = "@cuilt";
                ParCuilt.SqlDbType = SqlDbType.VarChar;
                ParCuilt.Size = 11;
                ParCuilt.Value = empleado.Cuilt;
                SqlCmd.Parameters.Add(ParCuilt);

                
                SqlParameter Partipodocumento = new SqlParameter();
                Partipodocumento.ParameterName = "@tipodocumento";
                Partipodocumento.SqlDbType = SqlDbType.VarChar;
                Partipodocumento.Size = 12;
                Partipodocumento.Value = empleado.Tipodocumento;
                SqlCmd.Parameters.Add(Partipodocumento);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 11;
                ParDocumento.Value = empleado.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 250;
                ParDireccion.Value = empleado.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 12;
                ParTelefono.Value = empleado.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParLegajo = new SqlParameter();
                ParLegajo.ParameterName = "@legajo";
                ParLegajo.SqlDbType = SqlDbType.VarChar;
                ParLegajo.Size = 12;
                ParLegajo.Value = empleado.Tipodocumento;
                SqlCmd.Parameters.Add(ParLegajo);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 30;
                ParEmail.Value = empleado.Tipodocumento;
                SqlCmd.Parameters.Add(ParEmail);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se actualizo el registro";


                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


            return rpta;

        }


        public string editarempleado(DEmpleado empleado)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdempleado);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@name";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = empleado.Name;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParLastname = new SqlParameter();
                ParLastname.ParameterName = "@lastname";
                ParLastname.SqlDbType = SqlDbType.VarChar;
                ParLastname.Size = 80;
                ParLastname.Value = empleado.Lastname;
                SqlCmd.Parameters.Add(ParLastname);

                SqlParameter ParCuilt = new SqlParameter();
                ParCuilt.ParameterName = "@cuilt";
                ParCuilt.SqlDbType = SqlDbType.VarChar;
                ParCuilt.Size = 11;
                ParCuilt.Value = empleado.Cuilt;
                SqlCmd.Parameters.Add(ParCuilt);


                SqlParameter Partipodocumento = new SqlParameter();
                Partipodocumento.ParameterName = "@tipodocumento";
                Partipodocumento.SqlDbType = SqlDbType.VarChar;
                Partipodocumento.Size = 12;
                Partipodocumento.Value = empleado.Tipodocumento;
                SqlCmd.Parameters.Add(Partipodocumento);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 11;
                ParDocumento.Value = empleado.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 250;
                ParDireccion.Value = empleado.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 12;
                ParTelefono.Value = empleado.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParLegajo = new SqlParameter();
                ParLegajo.ParameterName = "@legajo";
                ParLegajo.SqlDbType = SqlDbType.VarChar;
                ParLegajo.Size = 12;
                ParLegajo.Value = empleado.Tipodocumento;
                SqlCmd.Parameters.Add(ParLegajo);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 30;
                ParEmail.Value = empleado.Tipodocumento;
                SqlCmd.Parameters.Add(ParEmail);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se actualizo el registro";


                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


            return rpta;
        }


        public string eliminarempleado(DEmpleado empleado)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdempleado);



                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se elimino el registro";


                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


            return rpta;
        }


        public DataTable mostrarempleados()
        {
            DataTable dtresultado = new DataTable("empleado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_empleados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);



            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


            return dtresultado;

        }

        public DataTable buscarempleadonombre(DEmpleado empleado)
        {
            DataTable dtresultado = new DataTable("empleado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_empleado_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter Partextobuscar = new SqlParameter();
                Partextobuscar.ParameterName = "@textobuscar";
                Partextobuscar.SqlDbType = SqlDbType.VarChar;
                Partextobuscar.Size = 100;
                Partextobuscar.Value = empleado.Textobuscar;
                SqlCmd.Parameters.Add(Partextobuscar);

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);



            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


            return dtresultado;

        }

        public DataTable buscarempleadosapellidos(DEmpleado empleado)
        {
            DataTable dtresultado = new DataTable("empleado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_empleados_apellidos";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter Partextobuscar = new SqlParameter();
                Partextobuscar.ParameterName = "@textobuscar";
                Partextobuscar.SqlDbType = SqlDbType.VarChar;
                Partextobuscar.Size = 100;
                Partextobuscar.Value = empleado.Textobuscar;
                SqlCmd.Parameters.Add(Partextobuscar);

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);



            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


            return dtresultado;

        }

    }
}
