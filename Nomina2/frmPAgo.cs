using Newtonsoft.Json;
using Nomina.Recursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina2
{
    public partial class frmPAgo : Form
    {
        public string rutaJson = Path.Combine("datos.json");

        public frmPAgo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                datosJsonn datos = new datosJsonn(Convert.ToDouble(txtHorasRegulares.Text), Convert.ToDouble(txtHorasExtra.Text), Convert.ToDouble(txtDobleTurno.Text));
                guardarJson(datos);

                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecarga_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guardarJson(datosJsonn dato)
        {
            var registrosJson = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };

            string json = JsonConvert.SerializeObject(dato, registrosJson);
            File.WriteAllText(rutaJson, json);
        }
    }
}
