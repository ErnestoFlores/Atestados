namespace Atesta2.Formularios
{
    partial class Frm_Juzgados
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
            this.dtp_Juzgados = new System.Windows.Forms.DateTimePicker();
            this.lbl_Juzgado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_Juzgados
            // 
            this.dtp_Juzgados.CalendarFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Juzgados.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.dtp_Juzgados.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Juzgados.Location = new System.Drawing.Point(83, 49);
            this.dtp_Juzgados.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtp_Juzgados.Name = "dtp_Juzgados";
            this.dtp_Juzgados.Size = new System.Drawing.Size(287, 26);
            this.dtp_Juzgados.TabIndex = 0;
            this.dtp_Juzgados.Value = new System.DateTime(2018, 4, 24, 23, 59, 59, 0);
            this.dtp_Juzgados.ValueChanged += new System.EventHandler(this.dtp_Juzgados_ValueChanged);
            // 
            // lbl_Juzgado
            // 
            this.lbl_Juzgado.AutoSize = true;
            this.lbl_Juzgado.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Juzgado.Location = new System.Drawing.Point(98, 28);
            this.lbl_Juzgado.Name = "lbl_Juzgado";
            this.lbl_Juzgado.Size = new System.Drawing.Size(0, 23);
            this.lbl_Juzgado.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Juzgado);
            this.groupBox1.Location = new System.Drawing.Point(14, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guardia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Juzgados";
            // 
            // Frm_Juzgados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 169);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtp_Juzgados);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Juzgados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juzgados de Guardia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Juzgados;
        private System.Windows.Forms.Label lbl_Juzgado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
    }
}