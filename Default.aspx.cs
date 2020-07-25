using Evaluacion3.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluacion3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!this.IsPostBack)
            //{
            //    DataTable dt = new DataTable();
            //    dt.Columns.AddRange(new DataColumn[11] { 
            //        new DataColumn("rut", typeof(string)),
            //        new DataColumn("nomnbre", typeof(string)),
            //        new DataColumn("apellidoP",typeof(string)),
            //        new DataColumn("apellidoM",typeof(string)),
            //        new DataColumn("fdenac",typeof(string)),
            //        new DataColumn("tel",typeof(string)),
            //        new DataColumn("prev",typeof(string)),
            //        new DataColumn("calle",typeof(string)),
            //        new DataColumn("numCalle",typeof(int)),
            //        new DataColumn("actividad",typeof(string)),
            //        new DataColumn("deporte",typeof(string)),
            //    });
            //    dt.Rows.Add("17.435.701-3", "Paulina", "Bordones", "Collado", "22-09-1989", "912345678", "Fonasa", "Granaderos", 1234, "Estudiante", "N/A");

            //    GridView1.DataSource = dt;
            //    GridView1.DataBind();
            //}
        }

        
        public void Agregar()
        {
            List<Paciente> lista = new List<Paciente>();

            Paciente paciente = new Paciente(rut.Text, nombre.Text, apellidoP.Text, apellidoM.Text, fdenac.Text, tel.Text, prev.Text, calle.Text, int.Parse(numCalle.Text), act.Text, dep.Text);
            lista.Add(paciente);

            GridView1.DataSource = lista;
            GridView1.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Agregar();
        }

    }
}