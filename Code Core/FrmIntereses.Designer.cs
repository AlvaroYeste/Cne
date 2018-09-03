namespace Conozca_a_su_nuevo_empleado
{
    partial class FrmIntereses
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
            this.btnMusica = new System.Windows.Forms.Button();
            this.btnLiteratura = new System.Windows.Forms.Button();
            this.btnCine = new System.Windows.Forms.Button();
            this.btnVideojuegos = new System.Windows.Forms.Button();
            this.btnProgramar = new System.Windows.Forms.Button();
            this.btnAnimacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusica
            // 
            this.btnMusica.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusica.Location = new System.Drawing.Point(168, 12);
            this.btnMusica.Name = "btnMusica";
            this.btnMusica.Size = new System.Drawing.Size(150, 50);
            this.btnMusica.TabIndex = 4;
            this.btnMusica.Tag = "1";
            this.btnMusica.Text = "Música";
            this.btnMusica.UseVisualStyleBackColor = true;
            this.btnMusica.Click += new System.EventHandler(this.BotonClick);
            // 
            // btnLiteratura
            // 
            this.btnLiteratura.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiteratura.Location = new System.Drawing.Point(12, 124);
            this.btnLiteratura.Name = "btnLiteratura";
            this.btnLiteratura.Size = new System.Drawing.Size(150, 50);
            this.btnLiteratura.TabIndex = 5;
            this.btnLiteratura.Tag = "1";
            this.btnLiteratura.Text = "Literatura";
            this.btnLiteratura.UseVisualStyleBackColor = true;
            this.btnLiteratura.Click += new System.EventHandler(this.BotonClick);
            // 
            // btnCine
            // 
            this.btnCine.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCine.Location = new System.Drawing.Point(168, 124);
            this.btnCine.Name = "btnCine";
            this.btnCine.Size = new System.Drawing.Size(150, 50);
            this.btnCine.TabIndex = 6;
            this.btnCine.Tag = "1";
            this.btnCine.Text = "Cine";
            this.btnCine.UseVisualStyleBackColor = true;
            this.btnCine.Click += new System.EventHandler(this.BotonClick);
            // 
            // btnVideojuegos
            // 
            this.btnVideojuegos.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideojuegos.Location = new System.Drawing.Point(12, 12);
            this.btnVideojuegos.Name = "btnVideojuegos";
            this.btnVideojuegos.Size = new System.Drawing.Size(150, 50);
            this.btnVideojuegos.TabIndex = 7;
            this.btnVideojuegos.Tag = "1";
            this.btnVideojuegos.Text = "Videojuegos";
            this.btnVideojuegos.UseVisualStyleBackColor = true;
            this.btnVideojuegos.Click += new System.EventHandler(this.BotonClick);
            // 
            // btnProgramar
            // 
            this.btnProgramar.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramar.Location = new System.Drawing.Point(168, 68);
            this.btnProgramar.Name = "btnProgramar";
            this.btnProgramar.Size = new System.Drawing.Size(150, 50);
            this.btnProgramar.TabIndex = 8;
            this.btnProgramar.Tag = "1";
            this.btnProgramar.Text = "Programación";
            this.btnProgramar.UseVisualStyleBackColor = true;
            this.btnProgramar.Click += new System.EventHandler(this.BotonClick);
            // 
            // btnAnimacion
            // 
            this.btnAnimacion.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimacion.Location = new System.Drawing.Point(12, 68);
            this.btnAnimacion.Name = "btnAnimacion";
            this.btnAnimacion.Size = new System.Drawing.Size(150, 50);
            this.btnAnimacion.TabIndex = 9;
            this.btnAnimacion.Tag = "1";
            this.btnAnimacion.Text = "Animación";
            this.btnAnimacion.UseVisualStyleBackColor = true;
            this.btnAnimacion.Click += new System.EventHandler(this.BotonClick);
            // 
            // FrmIntereses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 183);
            this.Controls.Add(this.btnAnimacion);
            this.Controls.Add(this.btnProgramar);
            this.Controls.Add(this.btnVideojuegos);
            this.Controls.Add(this.btnCine);
            this.Controls.Add(this.btnLiteratura);
            this.Controls.Add(this.btnMusica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmIntereses";
            this.ShowIcon = false;
            this.Text = "Mis Intereses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIntereses_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusica;
        private System.Windows.Forms.Button btnLiteratura;
        private System.Windows.Forms.Button btnCine;
        private System.Windows.Forms.Button btnVideojuegos;
        private System.Windows.Forms.Button btnProgramar;
        private System.Windows.Forms.Button btnAnimacion;
    }
}