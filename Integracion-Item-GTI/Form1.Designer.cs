namespace Integracion_Item_GTI
{
    partial class Form1
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.consultarTercero = new System.Windows.Forms.Button();
            this.txtIdDoc = new System.Windows.Forms.TextBox();
            this.txtIdCia = new System.Windows.Forms.TextBox();
            this.txtNomDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(517, 70);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(129, 70);
            this.btnActualizar.TabIndex = 45;
            this.btnActualizar.Text = "Guardar/Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // consultarTercero
            // 
            this.consultarTercero.Location = new System.Drawing.Point(517, 5);
            this.consultarTercero.Name = "consultarTercero";
            this.consultarTercero.Size = new System.Drawing.Size(116, 53);
            this.consultarTercero.TabIndex = 35;
            this.consultarTercero.Text = "Consultar";
            this.consultarTercero.UseVisualStyleBackColor = true;
            // 
            // txtIdDoc
            // 
            this.txtIdDoc.Location = new System.Drawing.Point(135, 40);
            this.txtIdDoc.Name = "txtIdDoc";
            this.txtIdDoc.Size = new System.Drawing.Size(260, 20);
            this.txtIdDoc.TabIndex = 1;
            // 
            // txtIdCia
            // 
            this.txtIdCia.Location = new System.Drawing.Point(135, 156);
            this.txtIdCia.Name = "txtIdCia";
            this.txtIdCia.Size = new System.Drawing.Size(260, 20);
            this.txtIdCia.TabIndex = 3;
            // 
            // txtNomDoc
            // 
            this.txtNomDoc.Location = new System.Drawing.Point(135, 99);
            this.txtNomDoc.Name = "txtNomDoc";
            this.txtNomDoc.Size = new System.Drawing.Size(260, 20);
            this.txtNomDoc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "ID del Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nombre del Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "ID de la Compañia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomDoc);
            this.Controls.Add(this.txtIdCia);
            this.Controls.Add(this.txtIdDoc);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.consultarTercero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button consultarTercero;
        private System.Windows.Forms.TextBox txtIdDoc;
        private System.Windows.Forms.TextBox txtIdCia;
        private System.Windows.Forms.TextBox txtNomDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

