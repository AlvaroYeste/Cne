namespace Conozca_a_su_nuevo_empleado
{
    partial class FrmFAQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFAQ));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLinkedIn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Qué has estado haciendo desde que terminaste los estudios?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 36);
            this.label3.MaximumSize = new System.Drawing.Size(750, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(748, 242);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(558, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "¿Tienes algo que puedas enseñarnos sobre tu trabajo?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 431);
            this.label2.MaximumSize = new System.Drawing.Size(750, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tu, qué, crees...\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 377);
            this.label6.MaximumSize = new System.Drawing.Size(750, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(686, 54);
            this.label6.TabIndex = 6;
            this.label6.Text = "¿Estas familiarizado con conceptos como herencia, recursividad y anidamiento?";
            // 
            // lblLinkedIn
            // 
            this.lblLinkedIn.AutoSize = true;
            this.lblLinkedIn.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkedIn.Location = new System.Drawing.Point(12, 322);
            this.lblLinkedIn.Name = "lblLinkedIn";
            this.lblLinkedIn.Size = new System.Drawing.Size(370, 27);
            this.lblLinkedIn.TabIndex = 16;
            this.lblLinkedIn.TabStop = true;
            this.lblLinkedIn.Text = "https://github.com/AlvaroYeste/Cne";
            // 
            // FrmFAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(782, 473);
            this.Controls.Add(this.lblLinkedIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmFAQ";
            this.ShowIcon = false;
            this.Text = "FrmFAQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFAQ_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lblLinkedIn;
    }
}