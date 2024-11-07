namespace ProjectoEjemplo
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PrecioVenta = new System.Windows.Forms.TextBox();
            this.PrecioCompra = new System.Windows.Forms.TextBox();
            this.CantidadActual = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(340, 46);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(100, 22);
            this.ISBN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "precio venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "precio compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad actual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Titulo";
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.Location = new System.Drawing.Point(340, 172);
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Size = new System.Drawing.Size(100, 22);
            this.PrecioVenta.TabIndex = 7;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.Location = new System.Drawing.Point(340, 134);
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.Size = new System.Drawing.Size(100, 22);
            this.PrecioCompra.TabIndex = 8;
            // 
            // CantidadActual
            // 
            this.CantidadActual.Location = new System.Drawing.Point(340, 110);
            this.CantidadActual.Name = "CantidadActual";
            this.CantidadActual.Size = new System.Drawing.Size(100, 22);
            this.CantidadActual.TabIndex = 9;
            this.CantidadActual.Text = "tua";
            this.CantidadActual.TextChanged += new System.EventHandler(this.CantidadActual_TextChanged);
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(340, 77);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(100, 22);
            this.Titulo.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "buscar ISBN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.CantidadActual);
            this.Controls.Add(this.PrecioCompra);
            this.Controls.Add(this.PrecioVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PrecioVenta;
        private System.Windows.Forms.TextBox PrecioCompra;
        private System.Windows.Forms.TextBox CantidadActual;
        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.Button button2;
    }
}

