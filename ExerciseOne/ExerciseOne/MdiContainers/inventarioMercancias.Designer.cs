
namespace ExerciseOne.MdiContainers
{
    partial class inventarioMercancias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventarioMercancias));
            this.panelbackground = new System.Windows.Forms.Panel();
            this.txtNumAjuste = new System.Windows.Forms.MaskedTextBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.btnFinally = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbArticulo = new System.Windows.Forms.ComboBox();
            this.txtExistencia = new AppPresentation.Designs.Textbox.RJTextbox();
            this.txtVentas = new AppPresentation.Designs.Textbox.RJTextbox();
            this.txtCompras = new AppPresentation.Designs.Textbox.RJTextbox();
            this.panelbackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelbackground
            // 
            this.panelbackground.Controls.Add(this.CbArticulo);
            this.panelbackground.Controls.Add(this.txtNumAjuste);
            this.panelbackground.Controls.Add(this.txtExistencia);
            this.panelbackground.Controls.Add(this.txtVentas);
            this.panelbackground.Controls.Add(this.txtCompras);
            this.panelbackground.Controls.Add(this.txtdate);
            this.panelbackground.Controls.Add(this.btnFinally);
            this.panelbackground.Controls.Add(this.btnNew);
            this.panelbackground.Controls.Add(this.btnCalc);
            this.panelbackground.Controls.Add(this.label5);
            this.panelbackground.Controls.Add(this.label6);
            this.panelbackground.Controls.Add(this.label3);
            this.panelbackground.Controls.Add(this.label4);
            this.panelbackground.Controls.Add(this.label2);
            this.panelbackground.Controls.Add(this.label1);
            this.panelbackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbackground.Location = new System.Drawing.Point(0, 0);
            this.panelbackground.Name = "panelbackground";
            this.panelbackground.Size = new System.Drawing.Size(845, 407);
            this.panelbackground.TabIndex = 0;
            this.panelbackground.Paint += new System.Windows.Forms.PaintEventHandler(this.panelbackground_Paint);
            // 
            // txtNumAjuste
            // 
            this.txtNumAjuste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumAjuste.Location = new System.Drawing.Point(611, 14);
            this.txtNumAjuste.Name = "txtNumAjuste";
            this.txtNumAjuste.Size = new System.Drawing.Size(201, 20);
            this.txtNumAjuste.TabIndex = 31;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(611, 51);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(201, 20);
            this.txtdate.TabIndex = 26;
            // 
            // btnFinally
            // 
            this.btnFinally.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinally.Location = new System.Drawing.Point(677, 346);
            this.btnFinally.Name = "btnFinally";
            this.btnFinally.Size = new System.Drawing.Size(135, 33);
            this.btnFinally.TabIndex = 24;
            this.btnFinally.Text = "Finalizar";
            this.btnFinally.UseVisualStyleBackColor = true;
            this.btnFinally.Click += new System.EventHandler(this.btnFinally_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(179, 346);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(135, 33);
            this.btnNew.TabIndex = 23;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Location = new System.Drawing.Point(22, 346);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(135, 33);
            this.btnCalc.TabIndex = 22;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(554, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 14);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(501, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "Numero de ajuste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "Existencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Compras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Articulos";
            // 
            // CbArticulo
            // 
            this.CbArticulo.FormattingEnabled = true;
            this.CbArticulo.Location = new System.Drawing.Point(87, 98);
            this.CbArticulo.Name = "CbArticulo";
            this.CbArticulo.Size = new System.Drawing.Size(210, 21);
            this.CbArticulo.TabIndex = 32;
            // 
            // txtExistencia
            // 
            this.txtExistencia.BorderColor = System.Drawing.Color.Black;
            this.txtExistencia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtExistencia.BorderSize = 1;
            this.txtExistencia.Location = new System.Drawing.Point(94, 225);
            this.txtExistencia.Multiline = false;
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Padding = new System.Windows.Forms.Padding(7);
            this.txtExistencia.PasswordChar = false;
            this.txtExistencia.Size = new System.Drawing.Size(210, 28);
            this.txtExistencia.TabIndex = 30;
            this.txtExistencia.Text = "";
            this.txtExistencia.UnderlinedStyle = true;
            this.txtExistencia.Load += new System.EventHandler(this.txtExistencia_Load);
            // 
            // txtVentas
            // 
            this.txtVentas.BorderColor = System.Drawing.Color.Black;
            this.txtVentas.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtVentas.BorderSize = 1;
            this.txtVentas.Location = new System.Drawing.Point(87, 179);
            this.txtVentas.Multiline = false;
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Padding = new System.Windows.Forms.Padding(7);
            this.txtVentas.PasswordChar = false;
            this.txtVentas.Size = new System.Drawing.Size(210, 28);
            this.txtVentas.TabIndex = 29;
            this.txtVentas.Text = "";
            this.txtVentas.UnderlinedStyle = true;
            // 
            // txtCompras
            // 
            this.txtCompras.BorderColor = System.Drawing.Color.Black;
            this.txtCompras.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCompras.BorderSize = 1;
            this.txtCompras.Location = new System.Drawing.Point(87, 130);
            this.txtCompras.Multiline = false;
            this.txtCompras.Name = "txtCompras";
            this.txtCompras.Padding = new System.Windows.Forms.Padding(7);
            this.txtCompras.PasswordChar = false;
            this.txtCompras.Size = new System.Drawing.Size(210, 28);
            this.txtCompras.TabIndex = 28;
            this.txtCompras.Text = "";
            this.txtCompras.UnderlinedStyle = true;
            this.txtCompras.Load += new System.EventHandler(this.txtCompras_Load);
            // 
            // inventarioMercancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 407);
            this.Controls.Add(this.panelbackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "inventarioMercancias";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.inventarioMercancias_Load);
            this.panelbackground.ResumeLayout(false);
            this.panelbackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelbackground;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Button btnFinally;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AppPresentation.Designs.Textbox.RJTextbox txtExistencia;
        private AppPresentation.Designs.Textbox.RJTextbox txtVentas;
        private AppPresentation.Designs.Textbox.RJTextbox txtCompras;
        private System.Windows.Forms.MaskedTextBox txtNumAjuste;
        private System.Windows.Forms.ComboBox CbArticulo;
    }
}