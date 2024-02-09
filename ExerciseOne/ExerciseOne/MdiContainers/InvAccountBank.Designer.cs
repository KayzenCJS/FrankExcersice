
namespace ExerciseOne.MdiContainers
{
    partial class InvAccountBank
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
            this.panelbackground = new System.Windows.Forms.Panel();
            this.cbaAccount = new System.Windows.Forms.ComboBox();
            this.txtTransiccion = new System.Windows.Forms.MaskedTextBox();
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.txtBalance = new AppPresentation.Designs.Textbox.RJTextbox();
            this.txtReturis = new AppPresentation.Designs.Textbox.RJTextbox();
            this.txtDepositos = new AppPresentation.Designs.Textbox.RJTextbox();
            this.panelbackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelbackground
            // 
            this.panelbackground.BackColor = System.Drawing.Color.White;
            this.panelbackground.Controls.Add(this.richTextBox2);
            this.panelbackground.Controls.Add(this.richTextBox1);
            this.panelbackground.Controls.Add(this.cbaAccount);
            this.panelbackground.Controls.Add(this.txtTransiccion);
            this.panelbackground.Controls.Add(this.txtBalance);
            this.panelbackground.Controls.Add(this.txtReturis);
            this.panelbackground.Controls.Add(this.txtDepositos);
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
            this.panelbackground.Size = new System.Drawing.Size(840, 432);
            this.panelbackground.TabIndex = 1;
            // 
            // cbaAccount
            // 
            this.cbaAccount.FormattingEnabled = true;
            this.cbaAccount.Location = new System.Drawing.Point(87, 98);
            this.cbaAccount.Name = "cbaAccount";
            this.cbaAccount.Size = new System.Drawing.Size(210, 21);
            this.cbaAccount.TabIndex = 32;
            // 
            // txtTransiccion
            // 
            this.txtTransiccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransiccion.Location = new System.Drawing.Point(611, 14);
            this.txtTransiccion.Name = "txtTransiccion";
            this.txtTransiccion.Size = new System.Drawing.Size(201, 20);
            this.txtTransiccion.TabIndex = 31;
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
            this.btnFinally.Location = new System.Drawing.Point(677, 376);
            this.btnFinally.Name = "btnFinally";
            this.btnFinally.Size = new System.Drawing.Size(135, 33);
            this.btnFinally.TabIndex = 24;
            this.btnFinally.Text = "Finalizar";
            this.btnFinally.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(200, 376);
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
            this.btnCalc.Location = new System.Drawing.Point(22, 376);
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
            this.label6.Size = new System.Drawing.Size(97, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "No. Transaccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "Retiros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Depositos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cuenta";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(521, 157);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(291, 31);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Location = new System.Drawing.Point(521, 194);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(291, 31);
            this.richTextBox2.TabIndex = 34;
            this.richTextBox2.Text = "";
            // 
            // txtBalance
            // 
            this.txtBalance.BorderColor = System.Drawing.Color.Black;
            this.txtBalance.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBalance.BorderSize = 1;
            this.txtBalance.Location = new System.Drawing.Point(94, 225);
            this.txtBalance.Multiline = false;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Padding = new System.Windows.Forms.Padding(7);
            this.txtBalance.PasswordChar = false;
            this.txtBalance.Size = new System.Drawing.Size(210, 28);
            this.txtBalance.TabIndex = 30;
            this.txtBalance.UnderlinedStyle = true;
            // 
            // txtReturis
            // 
            this.txtReturis.BorderColor = System.Drawing.Color.Black;
            this.txtReturis.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtReturis.BorderSize = 1;
            this.txtReturis.Location = new System.Drawing.Point(87, 179);
            this.txtReturis.Multiline = false;
            this.txtReturis.Name = "txtReturis";
            this.txtReturis.Padding = new System.Windows.Forms.Padding(7);
            this.txtReturis.PasswordChar = false;
            this.txtReturis.Size = new System.Drawing.Size(210, 28);
            this.txtReturis.TabIndex = 29;
            this.txtReturis.UnderlinedStyle = true;
            // 
            // txtDepositos
            // 
            this.txtDepositos.BorderColor = System.Drawing.Color.Black;
            this.txtDepositos.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDepositos.BorderSize = 1;
            this.txtDepositos.Location = new System.Drawing.Point(87, 130);
            this.txtDepositos.Multiline = false;
            this.txtDepositos.Name = "txtDepositos";
            this.txtDepositos.Padding = new System.Windows.Forms.Padding(7);
            this.txtDepositos.PasswordChar = false;
            this.txtDepositos.Size = new System.Drawing.Size(210, 28);
            this.txtDepositos.TabIndex = 28;
            this.txtDepositos.UnderlinedStyle = true;
            // 
            // InvAccountBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 432);
            this.Controls.Add(this.panelbackground);
            this.Name = "InvAccountBank";
            this.Text = "InvAccountBank";
            this.Load += new System.EventHandler(this.InvAccountBank_Load);
            this.panelbackground.ResumeLayout(false);
            this.panelbackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelbackground;
        private System.Windows.Forms.ComboBox cbaAccount;
        private System.Windows.Forms.MaskedTextBox txtTransiccion;
        private AppPresentation.Designs.Textbox.RJTextbox txtBalance;
        private AppPresentation.Designs.Textbox.RJTextbox txtReturis;
        private AppPresentation.Designs.Textbox.RJTextbox txtDepositos;
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}