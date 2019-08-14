using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTtechapp
{
    public partial class FormVisualizadorIngresos : Form
    {
        public FormVisualizadorIngresos()
        {
            InitializeComponent();
        }

        private void FormVisualizadorIngresos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mtDataSet1.ViewMensualidades' Puede moverla o quitarla según sea necesario.
            //CargaOtros();
            reportViewer1.LocalReport.DataSources.Clear();
            CargaFichas();
            CargaSocios();
            CargaGastos();
            CargaOtros();
            CargaMensualidades();
            this.reportViewer1.RefreshReport();
        }
        conexion cnn = new conexion();
        private DataTable GetFichas()
        {
            DataTable Retornar = new DataTable();
            try
            {
                cnn.Conectar();
                SqlCommand cmd = new SqlCommand("Select * from getFichas('"+ dtpfecha.Value.ToShortDateString() + "')", cnn.conn);
                //cmd.Parameters.AddWithValue("@fecha",SqlDbType.DateTime).SqlValue = dtpfecha.Value.ToShortDateString();
                SqlDataReader dr = cmd.ExecuteReader();
                Retornar.Load(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }
            return Retornar;
        }
        private DataTable GetSocios()
        {
            DataTable Retornar = new DataTable();
            try
            {
                cnn.Conectar();
                SqlCommand cmd = new SqlCommand("Select * from getSocios('" + dtpfecha.Value.ToShortDateString() + "')", cnn.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                Retornar.Load(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }
            return Retornar;
        }
        private DataTable GetOtros()
        {
            DataTable Retornar = new DataTable();
            try
            {
                cnn.Conectar();
                SqlCommand cmd = new SqlCommand("Select * from getOtros('" + dtpfecha.Value.ToShortDateString() + "')", cnn.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                Retornar.Load(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en otros" + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }
            return Retornar;
        }
        private DataTable GetGastos()
        {
            DataTable Retornar = new DataTable();
            try
            {
                cnn.Conectar();
                SqlCommand cmd = new SqlCommand("Select * from getGastos('" + dtpfecha.Value.ToShortDateString() + "')", cnn.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                Retornar.Load(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }
            return Retornar;
        }
        private DataTable GetMensualidades()
        {
            DataTable Retornar = new DataTable();
            try
            {
                cnn.Conectar();
                SqlCommand cmd = new SqlCommand("Select * from getMensualidades('" + dtpfecha.Value.ToShortDateString() + "')", cnn.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                Retornar.Load(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en mensualidades" + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }
            return Retornar;
        }
        public void CargaFichas()
        {
            try
            {
                List<ClassCorte> cortes = new List<ClassCorte>();
                foreach (DataRow item in GetFichas().Rows)
                {
                    ClassCorte cl = new ClassCorte();
                    cl.IdIngreso = Convert.ToInt32(item[0].ToString());
                    cl.Tipo = item[1].ToString();
                    cl.Descripcion = item[2].ToString();
                    cl.Lugar = item[8].ToString();
                    cl.Monto = Convert.ToInt32(item[4].ToString());
                    cl.Fecha = Convert.ToDateTime(item[5]);
                    cl.Estado = Convert.ToBoolean(item[6].ToString());
                    cortes.Add(cl);
                }
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("fichas", cortes));
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ;_; " + ex.Message);
            }

        }
        public void CargaSocios()
        {
            try
            {
                List<ClassCorte> cortes = new List<ClassCorte>();
                foreach (DataRow item in GetSocios().Rows)
                {
                    ClassCorte cl = new ClassCorte();
                    cl.IdIngreso = Convert.ToInt32(item[0].ToString());
                    cl.Tipo = item[1].ToString();
                    cl.Descripcion = item[2].ToString();
                    cl.Lugar = item[3].ToString();
                    cl.Monto = Convert.ToInt32(item[4].ToString());
                    cl.Fecha = Convert.ToDateTime(item[5]);
                    cl.Estado = Convert.ToBoolean(item[6].ToString());
                    cortes.Add(cl);
                }
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("socios", cortes));
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error ;_; " + ex.Message);
            }

        }            
        public void CargaOtros()
        {
            try
            {
                List<ClassCorte> cortes = new List<ClassCorte>();
                foreach (DataRow item in GetOtros().Rows)
                {
                    ClassCorte cl = new ClassCorte
                    {
                        IdIngreso = Convert.ToInt32(item[0].ToString()),
                        Tipo = item[1].ToString(),
                        Descripcion = item[2].ToString(),
                        Lugar = item[3].ToString(),
                        Monto = Convert.ToInt32(item[4].ToString()),
                        Fecha = Convert.ToDateTime(item[5]),
                        Estado = Convert.ToBoolean(item[6].ToString())
                    };
                    cortes.Add(cl);
                }
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("otros", cortes));
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error ;_; " + ex.Message);
            }

        }      
        public void CargaGastos()
        {
            try
            {
                List<ClassCorte> cortes = new List<ClassCorte>();
                foreach (DataRow item in GetGastos().Rows)
                {
                    ClassCorte cl = new ClassCorte();
                    cl.IdIngreso = Convert.ToInt32(item[0].ToString());
                    cl.Tipo = item[1].ToString();
                    cl.Descripcion = item[2].ToString();
                    cl.Lugar = item[8].ToString();
                    cl.Monto = Convert.ToInt32(item[4].ToString());
                    cl.Fecha = Convert.ToDateTime(item[5]);
                    cl.Estado = Convert.ToBoolean(item[6].ToString());
                    cortes.Add(cl);
                }
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("gastos", cortes));
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error ;_; " + ex.Message);
            }

        }
        public void CargaMensualidades()
        {
            try
            {
                List<ClassCorte> cortes = new List<ClassCorte>();
                foreach (DataRow item in GetMensualidades().Rows)
                {
                    ClassCorte cl = new ClassCorte
                    {
                        IdIngreso = Convert.ToInt32(item[9].ToString()),
                        Tipo = item[1].ToString(),
                        Descripcion = item[1].ToString(),
                        Lugar = item[6].ToString(),
                        Monto = Convert.ToInt32(item[11].ToString()),
                        Fecha = Convert.ToDateTime(item[13])
                    };
                    cortes.Add(cl);
                }
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("mensualidades", cortes));
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error ;_; " + ex.Message);
            }

        }
        private void dtpfecha_CloseUp(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            CargaFichas();
            CargaSocios();
            CargaGastos();
            CargaMensualidades();
            CargaOtros();
            this.reportViewer1.RefreshReport();

        }
        private DataTable GetMeses()
        {
            DataTable Retornar = new DataTable();
            try
            {
                cnn.Conectar();
                SqlCommand cmd = new SqlCommand("Select * from getbyDate('" + dtpfecha.Value + "','"+ dtpentrefecha.Value  +"')", cnn.conn);
                //cmd.Parameters.AddWithValue("@fecha",SqlDbType.DateTime).SqlValue = dtpfecha.Value.ToShortDateString();
                SqlDataReader dr = cmd.ExecuteReader();
                Retornar.Load(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }
            return Retornar;
        }
        public void CargaMeses()
        {
            try
            {
                List<ClassCorte> cortes = new List<ClassCorte>();
                foreach (DataRow item in GetMeses().Rows)
                {
                    ClassCorte cl = new ClassCorte
                    {
                        IdIngreso = Convert.ToInt32(item[9].ToString()),
                        Tipo = item[1].ToString(),
                        Descripcion = item[1].ToString(),
                        Lugar = item[6].ToString(),
                        Monto = Convert.ToInt32(item[11].ToString()),
                        Fecha = Convert.ToDateTime(item[12])
                    };
                    cortes.Add(cl);
                }
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("mensualidades", cortes));
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error ;_; " + ex.Message);
            }

        }
        private void btnRevisar_Click(object sender, EventArgs e)
        {
            CargaMeses();
            CargaMensualidades();
        }

    }
}