using System.Runtime.CompilerServices;

namespace ConversionMonedas
{
    public partial class Form1 : Form
    {
        private bool NuevoCalculo = true;
        Label lblUSD;
        Label lblMXN;
        Label lblCAD;
        Label lblEUR;
        Label lblJPY;
        TextBox txtUSD;
        TextBox txtMXN;
        TextBox txtCAD;
        TextBox txtEUR;
        TextBox txtJPY;

        public Form1()
        {
            InitializeComponent();
            InicializarComponentes();
        }
        public void InicializarComponentes()
        {
            lblUSD = new Label();
            lblUSD.Text = "USD - Dólar";
            lblUSD.AutoSize = true;
            this.Controls.Add(lblUSD);
            lblUSD.Visible = false;

            lblMXN = new Label();
            lblMXN.Text = "MXN - Peso";
            lblMXN.AutoSize = true;
            this.Controls.Add(lblMXN);
            lblMXN.Visible = false;

            lblEUR = new Label();
            lblEUR.Text = "EUR - Euro";
            lblEUR.AutoSize = true;
            this.Controls.Add(lblEUR);
            lblEUR.Visible = false;

            lblCAD = new Label();
            lblCAD.Text = "CAD - Dolar";
            lblCAD.AutoSize = true;
            this.Controls.Add(lblCAD);
            lblCAD.Visible = false;

            lblJPY = new Label();
            lblJPY.Text = "JPY - Yen japonés";
            lblJPY.AutoSize = true;
            this.Controls.Add(lblJPY);
            lblJPY.Visible = false;

            txtUSD = new TextBox();
            txtUSD.Visible = false;
            txtUSD.Size = new Size(160,25);
            this.Controls.Add(txtUSD);

            txtMXN = new TextBox();
            txtMXN.Visible = false;
            txtMXN.Size = new Size(160,25);
            this.Controls.Add(txtMXN);

            txtCAD = new TextBox();
            txtCAD.Visible = false;
            txtCAD.Size = new Size(160, 25);
            this.Controls.Add(txtCAD);

            txtEUR = new TextBox();
            txtEUR.Visible = false;
            txtEUR.Size = new Size(160, 25);
            this.Controls.Add(txtEUR);

            txtJPY = new TextBox();
            txtJPY.Size = new Size(160, 25);
            txtJPY.Visible = false;
            this.Controls.Add(txtJPY);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnCalcular_click(object sender, EventArgs e)
        {
            if (NuevoCalculo)
            {
                if (boxMoneda.SelectedItem != null && InputHelper.LeerEntero(txtMonto.Text))
                {
                    Form2 nuevo = new Form2();
                    List<string> monedas = new List<string>();
                    monedas.Add(" USD - Dólar estadounidense");
                    monedas.Add("MXN - Peso mexicano");
                    monedas.Add("CAD - Dólar canadiense");
                    monedas.Add(" EUR - Euro");
                    monedas.Add("JPY - Yen Japonés");

                    monedas.Remove(boxMoneda.SelectedItem.ToString());

                    foreach (string monedasitem in monedas)
                    {
                        nuevo.checkedListBox1.Items.Add(monedasitem);
                    }

                    if (nuevo.ShowDialog() == DialogResult.OK)
                    {
                        List<string> conversiones = nuevo.seleccionados;

                        int posY = 175;

                        foreach (string conversion in conversiones)
                        {
                            switch (conversion)
                            {
                                case " USD - Dólar estadounidense":
                                    txtUSD.Text = "$ " + Conversion(boxMoneda.SelectedItem.ToString(), "USD", double.Parse(txtMonto.Text)).ToString("0.00");
                                    lblUSD.Location = new Point(37, posY);
                                    txtUSD.Location = new Point(278, posY);
                                    lblUSD.Visible = true;
                                    txtUSD.Visible = true;
                                    posY += 30;
                                    break;
                                case "MXN - Peso mexicano":
                                    txtMXN.Text = "$ " + Conversion(boxMoneda.SelectedItem.ToString(), "MXN", double.Parse(txtMonto.Text)).ToString("0.00");
                                    lblMXN.Location = new Point(37, posY);
                                    txtMXN.Location = new Point(278, posY);
                                    lblMXN.Visible = true;
                                    txtMXN.Visible = true;
                                    posY += 30;
                                    break;
                                case "CAD - Dólar canadiense":
                                    txtCAD.Text = "$ " + Conversion(boxMoneda.SelectedItem.ToString(), "CAD", double.Parse(txtMonto.Text)).ToString("0.00");
                                    lblCAD.Location = new Point(37, posY);
                                    txtCAD.Location = new Point(278, posY);
                                    lblCAD.Visible = true;
                                    txtCAD.Visible = true;
                                    posY += 30;
                                    break;
                                case " EUR - Euro":
                                    txtEUR.Text = "€ " + Conversion(boxMoneda.SelectedItem.ToString(), "EUR", double.Parse(txtMonto.Text)).ToString("0.00");
                                    lblEUR.Location = new Point(37, posY);
                                    txtEUR.Location = new Point(278, posY);
                                    lblEUR.Visible = true;
                                    txtEUR.Visible = true;
                                    posY += 30;
                                    break;
                                case "JPY - Yen Japonés":
                                    txtJPY.Text = "¥ " + Conversion(boxMoneda.SelectedItem.ToString(), "JPY", double.Parse(txtMonto.Text)).ToString("0.00");
                                    lblJPY.Location = new Point(37, posY);
                                    txtJPY.Location = new Point(278, posY);
                                    lblJPY.Visible = true;
                                    txtJPY.Visible = true;
                                    posY += 30;
                                    break;
                            }
                        }
                        NuevoCalculo = false;
                        pictureBox1.SendToBack();
                    }
                }
            }
            else
            {
                boxMoneda.Text = "";
                txtMonto.Text = "";

                lblUSD.Visible = false;
                lblMXN.Visible = false;
                lblCAD.Visible = false;
                lblEUR.Visible = false;
                lblJPY.Visible = false;

                txtUSD.Visible = false;
                txtMXN.Visible = false;
                txtCAD.Visible = false;
                txtEUR.Visible = false;
                txtJPY.Visible = false;

                NuevoCalculo = true;
            }
        }
        private double Conversion(string origen, string destino, double valor)
        {
            double resultado = 0;
            switch (origen)
            {
                case " USD - Dólar estadounidense":
                    resultado = Conversion_USD(valor, destino);
                    break;
                case "MXN - Peso mexicano":
                    resultado = Conversion_MXN(valor, destino);
                    break;
                case "CAD - Dólar canadiense":
                    resultado = Conversion_CAD(valor, destino);
                    break;
                case " EUR - Euro":
                    resultado = Conversion_EUR(valor, destino);
                    break;
                case "JPY - Yen Japonés":
                    resultado = Conversion_JPY(valor, destino);
                    break;
            }
            return resultado;
        }
        private double Conversion_USD(double USD, string opcion)
        {
            double conversion = 0;
            switch (opcion)
            {
                case "MXN":
                    conversion = USD * 17.38;
                    break;
                case "CAD":
                    conversion = USD * 1.36;
                    break;
                case "EUR":
                    conversion = USD * 0.86;
                    break;
                case "JPY":
                    conversion = USD * 157.92;
                    break;

                default:
                    break;
            }
            return conversion;
        }
        private double Conversion_MXN(double MXN, string opcion)
        {
            double conversion = 0;
            switch (opcion)
            {
                case "USD":
                    conversion = MXN * 0.06;
                    break;
                case "CAD":
                    conversion = MXN * 0.08;
                    break;
                case "EUR":
                    conversion = MXN * 0.05;
                    break;
                case "JPY":
                    conversion = MXN * 9.09;
                    break;

                default:
                    break;
            }
            return conversion;
        }
        private double Conversion_CAD(double CAD, string opcion)
        {
            double conversion = 0;
            switch (opcion)
            {
                case "USD":
                    conversion = CAD * 0.73;
                    break;
                case "MXN":
                    conversion = CAD * 12.76;
                    break;
                case "EUR":
                    conversion = CAD * 0.63;
                    break;
                case "JPY":
                    conversion = CAD * 115.88;
                    break;

                default:
                    break;
            }
            return conversion;
        }
        private double Conversion_EUR(double EUR, string opcion)
        {
            double conversion = 0;
            switch (opcion)
            {
                case "USD":
                    conversion = EUR * 1.17;
                    break;
                case "MXN":
                    conversion = EUR * 20.32;
                    break;
                case "CAD":
                    conversion = EUR * 1.59;
                    break;
                case "JPY":
                    conversion = EUR * 184.66;
                    break;

                default:
                    break;
            }
            return conversion;
        }
        private double Conversion_JPY(double JPY, string opcion)
        {
            double conversion = 0;
            switch (opcion)
            {
                case "USD":
                    conversion = JPY * 0.0063;
                    break;
                case "MXN":
                    conversion = JPY * 0.1101;
                    break;
                case "CAD":
                    conversion = JPY * 0.0086;
                    break;
                case "EUR":
                    conversion = JPY * 0.0054;
                    break;

                default:
                    break;
            }
            return conversion;
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
