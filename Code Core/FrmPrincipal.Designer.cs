namespace Conozca_a_su_nuevo_empleado
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.imgPrincipal = new System.Windows.Forms.PictureBox();
            this.imgBocadillo = new System.Windows.Forms.PictureBox();
            this.txtMiDialogo = new System.Windows.Forms.TextBox();
            this.btnPanelInfoPersonal = new System.Windows.Forms.Button();
            this.btnPanelIntereses = new System.Windows.Forms.Button();
            this.btnPanelObjetivos = new System.Windows.Forms.Button();
            this.btnPanelEstadisticas = new System.Windows.Forms.Button();
            this.btnPanelCurriculum = new System.Windows.Forms.Button();
            this.btnPanelHabilidades = new System.Windows.Forms.Button();
            this.btnPanelExperiencia = new System.Windows.Forms.Button();
            this.btnFAQ = new System.Windows.Forms.Button();
            this.btnPanelSobreMi = new System.Windows.Forms.Button();
            this.btnJuegos = new System.Windows.Forms.Button();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.btnMemory = new System.Windows.Forms.Button();
            this.btnTresEnRaya = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBocadillo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPrincipal
            // 
            this.imgPrincipal.Location = new System.Drawing.Point(12, 12);
            this.imgPrincipal.Name = "imgPrincipal";
            this.imgPrincipal.Size = new System.Drawing.Size(250, 350);
            this.imgPrincipal.TabIndex = 0;
            this.imgPrincipal.TabStop = false;
            // 
            // imgBocadillo
            // 
            this.imgBocadillo.Image = ((System.Drawing.Image)(resources.GetObject("imgBocadillo.Image")));
            this.imgBocadillo.Location = new System.Drawing.Point(12, 368);
            this.imgBocadillo.Name = "imgBocadillo";
            this.imgBocadillo.Size = new System.Drawing.Size(758, 173);
            this.imgBocadillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBocadillo.TabIndex = 1;
            this.imgBocadillo.TabStop = false;
            // 
            // txtMiDialogo
            // 
            this.txtMiDialogo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMiDialogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMiDialogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMiDialogo.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiDialogo.Location = new System.Drawing.Point(55, 406);
            this.txtMiDialogo.Multiline = true;
            this.txtMiDialogo.Name = "txtMiDialogo";
            this.txtMiDialogo.ReadOnly = true;
            this.txtMiDialogo.Size = new System.Drawing.Size(668, 120);
            this.txtMiDialogo.TabIndex = 2;
            this.txtMiDialogo.TabStop = false;
            this.txtMiDialogo.Text = "¡Buenas! Mi nombre es Álvaro Yeste, en directo (en realidad no) desde este progra" +
    "ma para hacerle una oferta que (me gustaría que) no rechazará, pues he venido pa" +
    "ra ser...¡Su nuevo empleado!";
            this.txtMiDialogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiDialogo.Click += new System.EventHandler(this.TxtMiDialogo_Click);
            // 
            // btnPanelInfoPersonal
            // 
            this.btnPanelInfoPersonal.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelInfoPersonal.Location = new System.Drawing.Point(268, 12);
            this.btnPanelInfoPersonal.Name = "btnPanelInfoPersonal";
            this.btnPanelInfoPersonal.Size = new System.Drawing.Size(160, 50);
            this.btnPanelInfoPersonal.TabIndex = 3;
            this.btnPanelInfoPersonal.Tag = "1";
            this.btnPanelInfoPersonal.Text = "Info personal";
            this.btnPanelInfoPersonal.UseVisualStyleBackColor = true;
            this.btnPanelInfoPersonal.Click += new System.EventHandler(this.BotonesPanelClick);
            // 
            // btnPanelIntereses
            // 
            this.btnPanelIntereses.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelIntereses.Location = new System.Drawing.Point(434, 12);
            this.btnPanelIntereses.Name = "btnPanelIntereses";
            this.btnPanelIntereses.Size = new System.Drawing.Size(170, 50);
            this.btnPanelIntereses.TabIndex = 4;
            this.btnPanelIntereses.Tag = "2";
            this.btnPanelIntereses.Text = "Intereses";
            this.btnPanelIntereses.UseVisualStyleBackColor = true;
            this.btnPanelIntereses.Click += new System.EventHandler(this.BotonesPanelClick);
            // 
            // btnPanelObjetivos
            // 
            this.btnPanelObjetivos.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelObjetivos.Location = new System.Drawing.Point(610, 12);
            this.btnPanelObjetivos.Name = "btnPanelObjetivos";
            this.btnPanelObjetivos.Size = new System.Drawing.Size(160, 50);
            this.btnPanelObjetivos.TabIndex = 5;
            this.btnPanelObjetivos.Tag = "3";
            this.btnPanelObjetivos.Text = "Objetivos";
            this.btnPanelObjetivos.UseVisualStyleBackColor = true;
            this.btnPanelObjetivos.Click += new System.EventHandler(this.BotonesPanelClick);
            // 
            // btnPanelEstadisticas
            // 
            this.btnPanelEstadisticas.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelEstadisticas.Location = new System.Drawing.Point(268, 68);
            this.btnPanelEstadisticas.Name = "btnPanelEstadisticas";
            this.btnPanelEstadisticas.Size = new System.Drawing.Size(160, 50);
            this.btnPanelEstadisticas.TabIndex = 6;
            this.btnPanelEstadisticas.Text = "Estadísticas";
            this.btnPanelEstadisticas.UseVisualStyleBackColor = true;
            this.btnPanelEstadisticas.Click += new System.EventHandler(this.BotonesPanelClick);
            // 
            // btnPanelCurriculum
            // 
            this.btnPanelCurriculum.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelCurriculum.Location = new System.Drawing.Point(434, 68);
            this.btnPanelCurriculum.Name = "btnPanelCurriculum";
            this.btnPanelCurriculum.Size = new System.Drawing.Size(170, 50);
            this.btnPanelCurriculum.TabIndex = 7;
            this.btnPanelCurriculum.Text = "El CV Clásico";
            this.btnPanelCurriculum.UseVisualStyleBackColor = true;
            this.btnPanelCurriculum.Click += new System.EventHandler(this.BotonesPanelClick);
            // 
            // btnPanelHabilidades
            // 
            this.btnPanelHabilidades.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelHabilidades.Location = new System.Drawing.Point(610, 68);
            this.btnPanelHabilidades.Name = "btnPanelHabilidades";
            this.btnPanelHabilidades.Size = new System.Drawing.Size(160, 50);
            this.btnPanelHabilidades.TabIndex = 8;
            this.btnPanelHabilidades.Text = "Habilidades";
            this.btnPanelHabilidades.UseVisualStyleBackColor = true;
            this.btnPanelHabilidades.Click += new System.EventHandler(this.BotonesPanelClick);
            // 
            // btnPanelExperiencia
            // 
            this.btnPanelExperiencia.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelExperiencia.Location = new System.Drawing.Point(268, 124);
            this.btnPanelExperiencia.Name = "btnPanelExperiencia";
            this.btnPanelExperiencia.Size = new System.Drawing.Size(160, 50);
            this.btnPanelExperiencia.TabIndex = 9;
            this.btnPanelExperiencia.Text = "Experiencia";
            this.btnPanelExperiencia.UseVisualStyleBackColor = true;
            this.btnPanelExperiencia.Click += new System.EventHandler(this.BotonesPanelClick);
            // 
            // btnFAQ
            // 
            this.btnFAQ.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFAQ.Location = new System.Drawing.Point(434, 124);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Size = new System.Drawing.Size(170, 50);
            this.btnFAQ.TabIndex = 10;
            this.btnFAQ.Text = "FAQ";
            this.btnFAQ.UseVisualStyleBackColor = true;
            this.btnFAQ.Click += new System.EventHandler(this.BotonesPanelClick);
            // 
            // btnPanelSobreMi
            // 
            this.btnPanelSobreMi.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelSobreMi.Location = new System.Drawing.Point(610, 124);
            this.btnPanelSobreMi.Name = "btnPanelSobreMi";
            this.btnPanelSobreMi.Size = new System.Drawing.Size(160, 50);
            this.btnPanelSobreMi.TabIndex = 11;
            this.btnPanelSobreMi.Text = "Sobre mí";
            this.btnPanelSobreMi.UseVisualStyleBackColor = true;
            this.btnPanelSobreMi.Click += new System.EventHandler(this.BotonesPanelClick);
            // 
            // btnJuegos
            // 
            this.btnJuegos.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuegos.Location = new System.Drawing.Point(268, 180);
            this.btnJuegos.Name = "btnJuegos";
            this.btnJuegos.Size = new System.Drawing.Size(502, 50);
            this.btnJuegos.TabIndex = 12;
            this.btnJuegos.UseVisualStyleBackColor = true;
            this.btnJuegos.Visible = false;
            this.btnJuegos.Click += new System.EventHandler(this.BotonesPanelClick);
            // 
            // tmrReloj
            // 
            this.tmrReloj.Interval = 1000;
            this.tmrReloj.Tick += new System.EventHandler(this.TmrReloj_Tick);
            // 
            // btnMemory
            // 
            this.btnMemory.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemory.Location = new System.Drawing.Point(268, 236);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(502, 50);
            this.btnMemory.TabIndex = 16;
            this.btnMemory.Text = "Memory / Parejas";
            this.btnMemory.UseVisualStyleBackColor = true;
            this.btnMemory.Visible = false;
            this.btnMemory.Click += new System.EventHandler(this.BotonesPanelClick);
            // 
            // btnTresEnRaya
            // 
            this.btnTresEnRaya.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTresEnRaya.Location = new System.Drawing.Point(268, 292);
            this.btnTresEnRaya.Name = "btnTresEnRaya";
            this.btnTresEnRaya.Size = new System.Drawing.Size(502, 50);
            this.btnTresEnRaya.TabIndex = 17;
            this.btnTresEnRaya.Text = "Tres en raya";
            this.btnTresEnRaya.UseVisualStyleBackColor = true;
            this.btnTresEnRaya.Visible = false;
            this.btnTresEnRaya.Click += new System.EventHandler(this.BotonesPanelClick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnTresEnRaya);
            this.Controls.Add(this.btnMemory);
            this.Controls.Add(this.btnJuegos);
            this.Controls.Add(this.btnPanelSobreMi);
            this.Controls.Add(this.btnFAQ);
            this.Controls.Add(this.btnPanelExperiencia);
            this.Controls.Add(this.btnPanelHabilidades);
            this.Controls.Add(this.btnPanelCurriculum);
            this.Controls.Add(this.btnPanelEstadisticas);
            this.Controls.Add(this.btnPanelObjetivos);
            this.Controls.Add(this.btnPanelIntereses);
            this.Controls.Add(this.btnPanelInfoPersonal);
            this.Controls.Add(this.txtMiDialogo);
            this.Controls.Add(this.imgPrincipal);
            this.Controls.Add(this.imgBocadillo);
            this.Font = new System.Drawing.Font("Garamond", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conozca a su nuevo empleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBocadillo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPrincipal;
        private System.Windows.Forms.PictureBox imgBocadillo;
        private System.Windows.Forms.Button btnPanelInfoPersonal;
        private System.Windows.Forms.Button btnPanelIntereses;
        private System.Windows.Forms.Button btnPanelObjetivos;
        private System.Windows.Forms.Button btnPanelEstadisticas;
        private System.Windows.Forms.Button btnPanelCurriculum;
        private System.Windows.Forms.Button btnPanelHabilidades;
        private System.Windows.Forms.Button btnPanelExperiencia;
        private System.Windows.Forms.Button btnFAQ;
        private System.Windows.Forms.Button btnPanelSobreMi;
        private System.Windows.Forms.Button btnJuegos;
        public System.Windows.Forms.Timer tmrReloj;
        public System.Windows.Forms.TextBox txtMiDialogo;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.Button btnTresEnRaya;
    }
}

