using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConversionMonedas
{
    public partial class Form2 : Form
    {
        public List<string> seleccionados { get; private set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void btnCancelar_click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnAceptar_click(object sender, EventArgs e)
        {
            seleccionados = new List<string>();
            foreach (string s in checkedListBox1.CheckedItems)
            {
                seleccionados.Add(s);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
