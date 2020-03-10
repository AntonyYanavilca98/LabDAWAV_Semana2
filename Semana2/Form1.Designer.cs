namespace Semana2
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
            this.label1 = new System.Windows.Forms.Label();
            this.CboAnios = new System.Windows.Forms.ComboBox();
            this.DgPedidos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DgDetalle = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.LblMonto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCIONAR EL AÑO DEL PEDIDO";
            // 
            // CboAnios
            // 
            this.CboAnios.FormattingEnabled = true;
            this.CboAnios.Location = new System.Drawing.Point(370, 24);
            this.CboAnios.Name = "CboAnios";
            this.CboAnios.Size = new System.Drawing.Size(121, 24);
            this.CboAnios.TabIndex = 1;
            this.CboAnios.SelectionChangeCommitted += new System.EventHandler(this.CboAnios_SelectionChangeCommitted);
            // 
            // DgPedidos
            // 
            this.DgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPedidos.Location = new System.Drawing.Point(112, 108);
            this.DgPedidos.Name = "DgPedidos";
            this.DgPedidos.RowHeadersWidth = 51;
            this.DgPedidos.RowTemplate.Height = 24;
            this.DgPedidos.Size = new System.Drawing.Size(625, 179);
            this.DgPedidos.TabIndex = 2;
            this.DgPedidos.DoubleClick += new System.EventHandler(this.DgPedidos_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "LISTA DE PEDIDOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nro de Pedidos:";
            // 
            // LblNumero
            // 
            this.LblNumero.Location = new System.Drawing.Point(687, 310);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(50, 22);
            this.LblNumero.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "LISTA DE DETALLE";
            // 
            // DgDetalle
            // 
            this.DgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDetalle.Location = new System.Drawing.Point(115, 366);
            this.DgDetalle.Name = "DgDetalle";
            this.DgDetalle.RowHeadersWidth = 51;
            this.DgDetalle.RowTemplate.Height = 24;
            this.DgDetalle.Size = new System.Drawing.Size(632, 194);
            this.DgDetalle.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 582);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monto del Pedido";
            // 
            // LblMonto
            // 
            this.LblMonto.Location = new System.Drawing.Point(687, 582);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(50, 22);
            this.LblMonto.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 678);
            this.Controls.Add(this.LblMonto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DgDetalle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgPedidos);
            this.Controls.Add(this.CboAnios);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ado Net C Sharp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboAnios;
        private System.Windows.Forms.DataGridView DgPedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LblNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LblMonto;
    }
}

