using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteReniecWeb
{
    public partial class frmReniec : System.Web.UI.Page
    {

        srReniec.wsDniSoapClient servicio = new srReniec.wsDniSoapClient();

        private void Listar()
        {
            gvDni.DataSource = servicio.Listar().Tables[0];
            gvDni.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
           
            }
           
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            string description = txtdni.Text.Trim();
            gvDni.DataSource = servicio.Buscar(description).Tables[0];
            gvDni.DataBind();
        }
    }
}