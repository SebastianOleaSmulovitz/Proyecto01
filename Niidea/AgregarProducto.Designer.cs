namespace Niidea
{
    partial class AgregarProducto
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddNombre = new System.Windows.Forms.TextBox();
            this.AddStock = new System.Windows.Forms.TextBox();
            this.InputPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddNombre
            // 
            this.AddNombre.Location = new System.Drawing.Point(227, 92);
            this.AddNombre.Name = "AddNombre";
            this.AddNombre.Size = new System.Drawing.Size(82, 20);
            this.AddNombre.TabIndex = 3;
            this.AddNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AddStock
            // 
            this.AddStock.Location = new System.Drawing.Point(62, 174);
            this.AddStock.Name = "AddStock";
            this.AddStock.Size = new System.Drawing.Size(82, 20);
            this.AddStock.TabIndex = 4;
            // 
            // InputPrecio
            // 
            this.InputPrecio.Location = new System.Drawing.Point(227, 174);
            this.InputPrecio.Name = "InputPrecio";
            this.InputPrecio.Size = new System.Drawing.Size(82, 20);
            this.InputPrecio.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stock";
            // 
            // BoxCategoria
            // 
            this.BoxCategoria.FormattingEnabled = true;
            this.BoxCategoria.Items.AddRange(new object[] {
            "Lavarropa",
            "Televisor",
            "Aire Acondicionado",
            "Cocina",
            "Horno Electrico",
            "Ventilador",
            "Calefactor",
            "Plancha",
            "Freidora de Aire",
            "Microondas"});
            this.BoxCategoria.Location = new System.Drawing.Point(62, 91);
            this.BoxCategoria.Name = "BoxCategoria";
            this.BoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.BoxCategoria.TabIndex = 11;
            this.BoxCategoria.Tag = "Seleccionar";
            this.BoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 332);
            this.Controls.Add(this.BoxCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputPrecio);
            this.Controls.Add(this.AddStock);
            this.Controls.Add(this.AddNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
          
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox AddNombre;
        private System.Windows.Forms.TextBox AddStock;
        private System.Windows.Forms.TextBox InputPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BoxCategoria;
    }
}