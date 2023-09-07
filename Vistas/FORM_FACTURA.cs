using FACTURA.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FACTURA.Vistas
{
    public partial class FORM_FACTURA : Form
    {
        public FORM_FACTURA()
        {
            InitializeComponent();

            LABEL_NUM_FACTURA.Text = "FACT Nº " + FORM_PRINCIPAL.ctl_fact.num_factura();

            LABEL_FECHA.Text = DateTime.Now.ToString();
        }



        private void FORM_FACTURA_Load(object sender, EventArgs e)
        {

        }

        private void TXT_BUSCAR_CEDULA_TextChanged(object sender, EventArgs e)
        {
            if(TXT_BUSCAR_CEDULA.Text.Length == 10)
            {
                Cliente cli = FORM_PRINCIPAL.ctl_cli.Buscar_cedula(TXT_BUSCAR_CEDULA.Text);

                if(cli != null)
                {
                    LABEL_CLIENTE.Text = cli.Nombre + " " + cli.Apellido;
                }
                else
                {
                    LABEL_CLIENTE.Text = "-";
                }
            }
            else
            {
                LABEL_CLIENTE.Text = "-";
            }
        }
    }
}
