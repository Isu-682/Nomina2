namespace Nomina2
{
    partial class frmPAgo
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRecarga = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDobleTurno = new System.Windows.Forms.TextBox();
            this.txtHorasExtra = new System.Windows.Forms.TextBox();
            this.txtHorasRegulares = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Pago por doble turno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pago por horas extra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pago por horas regulares";
            // 
            // btnRecarga
            // 
            this.btnRecarga.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRecarga.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecarga.Location = new System.Drawing.Point(287, 186);
            this.btnRecarga.Name = "btnRecarga";
            this.btnRecarga.Size = new System.Drawing.Size(93, 32);
            this.btnRecarga.TabIndex = 15;
            this.btnRecarga.Text = "Recargar Datos";
            this.btnRecarga.UseVisualStyleBackColor = true;
            this.btnRecarga.Click += new System.EventHandler(this.btnRecarga_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(156, 186);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 32);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDobleTurno
            // 
            this.txtDobleTurno.Location = new System.Drawing.Point(341, 136);
            this.txtDobleTurno.Name = "txtDobleTurno";
            this.txtDobleTurno.Size = new System.Drawing.Size(121, 20);
            this.txtDobleTurno.TabIndex = 13;
            // 
            // txtHorasExtra
            // 
            this.txtHorasExtra.Location = new System.Drawing.Point(341, 84);
            this.txtHorasExtra.Name = "txtHorasExtra";
            this.txtHorasExtra.Size = new System.Drawing.Size(121, 20);
            this.txtHorasExtra.TabIndex = 12;
            // 
            // txtHorasRegulares
            // 
            this.txtHorasRegulares.Location = new System.Drawing.Point(341, 33);
            this.txtHorasRegulares.Name = "txtHorasRegulares";
            this.txtHorasRegulares.Size = new System.Drawing.Size(121, 20);
            this.txtHorasRegulares.TabIndex = 11;
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 251);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRecarga);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDobleTurno);
            this.Controls.Add(this.txtHorasExtra);
            this.Controls.Add(this.txtHorasRegulares);
            this.Name = "Pago";
            this.Text = "Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRecarga;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtDobleTurno;
        private System.Windows.Forms.TextBox txtHorasExtra;
        private System.Windows.Forms.TextBox txtHorasRegulares;
    }
}