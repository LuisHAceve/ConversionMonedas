namespace ConversionMonedas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMoneda = new Label();
            lblMonto = new Label();
            txtMonto = new TextBox();
            boxMoneda = new ComboBox();
            btnCalcular = new Button();
            lblConversiones = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblMoneda
            // 
            lblMoneda.AutoSize = true;
            lblMoneda.Location = new Point(12, 6);
            lblMoneda.Name = "lblMoneda";
            lblMoneda.Size = new Size(78, 25);
            lblMoneda.TabIndex = 0;
            lblMoneda.Text = "Moneda";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(278, 5);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(66, 25);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.BorderStyle = BorderStyle.FixedSingle;
            txtMonto.Location = new Point(278, 33);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(159, 31);
            txtMonto.TabIndex = 1;
            txtMonto.TextChanged += txtMonto_TextChanged;
            // 
            // boxMoneda
            // 
            boxMoneda.FormattingEnabled = true;
            boxMoneda.Items.AddRange(new object[] { " USD - Dólar estadounidense", "MXN - Peso mexicano", "CAD - Dólar canadiense", " EUR - Euro", "JPY - Yen Japonés" });
            boxMoneda.Location = new Point(12, 32);
            boxMoneda.Name = "boxMoneda";
            boxMoneda.Size = new Size(260, 33);
            boxMoneda.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Gainsboro;
            btnCalcular.FlatAppearance.BorderColor = Color.DarkGray;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.ForeColor = SystemColors.ActiveCaptionText;
            btnCalcular.Location = new Point(278, 82);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(159, 35);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_click;
            // 
            // lblConversiones
            // 
            lblConversiones.AutoSize = true;
            lblConversiones.Location = new Point(37, 131);
            lblConversiones.Name = "lblConversiones";
            lblConversiones.Size = new Size(118, 25);
            lblConversiones.TabIndex = 5;
            lblConversiones.Text = "Conversiones";
            lblConversiones.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 371);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 526);
            Controls.Add(lblConversiones);
            Controls.Add(btnCalcular);
            Controls.Add(boxMoneda);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(lblMoneda);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMoneda;
        private Label lblMonto;
        private TextBox txtMonto;
        private ComboBox boxMoneda;
        private Button btnCalcular;
        private Label lblConversiones;
        private PictureBox pictureBox1;
    }
}
