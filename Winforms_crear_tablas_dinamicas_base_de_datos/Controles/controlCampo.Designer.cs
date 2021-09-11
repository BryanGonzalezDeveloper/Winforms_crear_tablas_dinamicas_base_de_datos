
namespace Winforms_crear_tablas_dinamicas_base_de_datos.Controles
{
    partial class controlCampo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCampo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoDato = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Campo:";
            // 
            // txtNombreCampo
            // 
            this.txtNombreCampo.Enabled = false;
            this.txtNombreCampo.Location = new System.Drawing.Point(135, 17);
            this.txtNombreCampo.Name = "txtNombreCampo";
            this.txtNombreCampo.Size = new System.Drawing.Size(225, 20);
            this.txtNombreCampo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione tipo de dato:";
            // 
            // cboTipoDato
            // 
            this.cboTipoDato.AutoCompleteCustomSource.AddRange(new string[] {
            "VARCHAR(100)",
            "INT",
            "DECIMAL(8,2)",
            "DATE"});
            this.cboTipoDato.FormattingEnabled = true;
            this.cboTipoDato.Location = new System.Drawing.Point(413, 21);
            this.cboTipoDato.Name = "cboTipoDato";
            this.cboTipoDato.Size = new System.Drawing.Size(202, 21);
            this.cboTipoDato.TabIndex = 3;
            // 
            // controlCampo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboTipoDato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCampo);
            this.Controls.Add(this.label1);
            this.Name = "controlCampo";
            this.Size = new System.Drawing.Size(646, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCampo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoDato;
    }
}
