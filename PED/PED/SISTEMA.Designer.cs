namespace PED
{
    partial class SISTEMA
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_reserva = new System.Windows.Forms.Button();
            this.BTN_libro = new System.Windows.Forms.Button();
            this.BTN_usuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(105, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "SISTEMA DE LA BIBLIOTECA BINAES";
            // 
            // BTN_reserva
            // 
            this.BTN_reserva.BackColor = System.Drawing.SystemColors.ControlText;
            this.BTN_reserva.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_reserva.ForeColor = System.Drawing.Color.IndianRed;
            this.BTN_reserva.Location = new System.Drawing.Point(159, 156);
            this.BTN_reserva.Name = "BTN_reserva";
            this.BTN_reserva.Size = new System.Drawing.Size(208, 91);
            this.BTN_reserva.TabIndex = 5;
            this.BTN_reserva.Text = "RESERVA";
            this.BTN_reserva.UseVisualStyleBackColor = false;
            this.BTN_reserva.Click += new System.EventHandler(this.BTN_reserva_Click);
            // 
            // BTN_libro
            // 
            this.BTN_libro.BackColor = System.Drawing.SystemColors.ControlText;
            this.BTN_libro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_libro.ForeColor = System.Drawing.Color.IndianRed;
            this.BTN_libro.Location = new System.Drawing.Point(411, 156);
            this.BTN_libro.Name = "BTN_libro";
            this.BTN_libro.Size = new System.Drawing.Size(208, 91);
            this.BTN_libro.TabIndex = 6;
            this.BTN_libro.Text = "AGREGAR LIBRO";
            this.BTN_libro.UseVisualStyleBackColor = false;
            // 
            // BTN_usuarios
            // 
            this.BTN_usuarios.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_usuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_usuarios.ForeColor = System.Drawing.Color.IndianRed;
            this.BTN_usuarios.Location = new System.Drawing.Point(288, 267);
            this.BTN_usuarios.Name = "BTN_usuarios";
            this.BTN_usuarios.Size = new System.Drawing.Size(208, 91);
            this.BTN_usuarios.TabIndex = 7;
            this.BTN_usuarios.Text = "AGREGAR USUARIO";
            this.BTN_usuarios.UseVisualStyleBackColor = false;
            // 
            // SISTEMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_usuarios);
            this.Controls.Add(this.BTN_libro);
            this.Controls.Add(this.BTN_reserva);
            this.Controls.Add(this.label1);
            this.Name = "SISTEMA";
            this.Text = "SISTEMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_reserva;
        private System.Windows.Forms.Button BTN_libro;
        private System.Windows.Forms.Button BTN_usuarios;
    }
}