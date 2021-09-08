
namespace Winforms_crear_tablas_dinamicas_base_de_datos.Controles
{
    partial class controlColumna
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
            this.txtNombreColumna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDatatype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la columna:";
            // 
            // txtNombreColumna
            // 
            this.txtNombreColumna.Location = new System.Drawing.Point(197, 23);
            this.txtNombreColumna.Name = "txtNombreColumna";
            this.txtNombreColumna.Size = new System.Drawing.Size(150, 20);
            this.txtNombreColumna.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de dato:";
            // 
            // cboDatatype
            // 
            this.cboDatatype.AutoCompleteCustomSource.AddRange(new string[] {
            "VARCHAR(100)",
            "INT",
            "DECIMAL(8,2)",
            "DATE"});
            this.cboDatatype.FormattingEnabled = true;
            this.cboDatatype.Items.AddRange(new object[] {
            "VARCHAR(100)",
            "INT",
            "DECIMAL(8,2)",
            "DATE"});
            this.cboDatatype.Location = new System.Drawing.Point(493, 19);
            this.cboDatatype.Name = "cboDatatype";
            this.cboDatatype.Size = new System.Drawing.Size(160, 21);
            this.cboDatatype.TabIndex = 3;
            // 
            // controlColumna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboDatatype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreColumna);
            this.Controls.Add(this.label1);
            this.Name = "controlColumna";
            this.Size = new System.Drawing.Size(670, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreColumna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDatatype;
    }
}
