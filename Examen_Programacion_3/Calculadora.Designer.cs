namespace Examen_Programacion_3
{
    partial class Calculadora
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
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_suma = new System.Windows.Forms.Button();
            this.btn_resta = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_uno = new System.Windows.Forms.Button();
            this.btn_dos = new System.Windows.Forms.Button();
            this.btn_tres = new System.Windows.Forms.Button();
            this.btn_cero = new System.Windows.Forms.Button();
            this.btn_cuatro = new System.Windows.Forms.Button();
            this.btn_cinco = new System.Windows.Forms.Button();
            this.btn_seis = new System.Windows.Forms.Button();
            this.btn_siete = new System.Windows.Forms.Button();
            this.btn_ocho = new System.Windows.Forms.Button();
            this.btn_nueve = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPantalla
            // 
            this.txtPantalla.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.Location = new System.Drawing.Point(36, 23);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.Size = new System.Drawing.Size(463, 33);
            this.txtPantalla.TabIndex = 0;
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(144, 83);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(59, 41);
            this.btn_limpiar.TabIndex = 1;
            this.btn_limpiar.Text = "CE";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_suma
            // 
            this.btn_suma.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suma.Location = new System.Drawing.Point(209, 83);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(59, 41);
            this.btn_suma.TabIndex = 2;
            this.btn_suma.Text = "+";
            this.btn_suma.UseVisualStyleBackColor = true;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // btn_resta
            // 
            this.btn_resta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resta.Location = new System.Drawing.Point(274, 83);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(59, 41);
            this.btn_resta.TabIndex = 3;
            this.btn_resta.Text = "-";
            this.btn_resta.UseVisualStyleBackColor = true;
            this.btn_resta.Click += new System.EventHandler(this.btn_resta_Click);
            // 
            // btn_division
            // 
            this.btn_division.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_division.Location = new System.Drawing.Point(339, 140);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(59, 41);
            this.btn_division.TabIndex = 5;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_uno
            // 
            this.btn_uno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uno.Location = new System.Drawing.Point(144, 140);
            this.btn_uno.Name = "btn_uno";
            this.btn_uno.Size = new System.Drawing.Size(59, 41);
            this.btn_uno.TabIndex = 6;
            this.btn_uno.Text = "1";
            this.btn_uno.UseVisualStyleBackColor = true;
            this.btn_uno.Click += new System.EventHandler(this.btn_uno_Click);
            // 
            // btn_dos
            // 
            this.btn_dos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dos.Location = new System.Drawing.Point(209, 140);
            this.btn_dos.Name = "btn_dos";
            this.btn_dos.Size = new System.Drawing.Size(59, 41);
            this.btn_dos.TabIndex = 7;
            this.btn_dos.Text = "2";
            this.btn_dos.UseVisualStyleBackColor = true;
            this.btn_dos.Click += new System.EventHandler(this.btn_dos_Click);
            // 
            // btn_tres
            // 
            this.btn_tres.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tres.Location = new System.Drawing.Point(274, 140);
            this.btn_tres.Name = "btn_tres";
            this.btn_tres.Size = new System.Drawing.Size(59, 41);
            this.btn_tres.TabIndex = 8;
            this.btn_tres.Text = "3";
            this.btn_tres.UseVisualStyleBackColor = true;
            this.btn_tres.Click += new System.EventHandler(this.btn_tres_Click);
            // 
            // btn_cero
            // 
            this.btn_cero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cero.Location = new System.Drawing.Point(144, 281);
            this.btn_cero.Name = "btn_cero";
            this.btn_cero.Size = new System.Drawing.Size(189, 41);
            this.btn_cero.TabIndex = 9;
            this.btn_cero.Text = "0";
            this.btn_cero.UseVisualStyleBackColor = true;
            this.btn_cero.Click += new System.EventHandler(this.btn_cero_Click);
            // 
            // btn_cuatro
            // 
            this.btn_cuatro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cuatro.Location = new System.Drawing.Point(144, 187);
            this.btn_cuatro.Name = "btn_cuatro";
            this.btn_cuatro.Size = new System.Drawing.Size(59, 41);
            this.btn_cuatro.TabIndex = 10;
            this.btn_cuatro.Text = "4";
            this.btn_cuatro.UseVisualStyleBackColor = true;
            this.btn_cuatro.Click += new System.EventHandler(this.btn_cuatro_Click);
            // 
            // btn_cinco
            // 
            this.btn_cinco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cinco.Location = new System.Drawing.Point(209, 187);
            this.btn_cinco.Name = "btn_cinco";
            this.btn_cinco.Size = new System.Drawing.Size(59, 41);
            this.btn_cinco.TabIndex = 11;
            this.btn_cinco.Text = "5";
            this.btn_cinco.UseVisualStyleBackColor = true;
            this.btn_cinco.Click += new System.EventHandler(this.btn_cinco_Click);
            // 
            // btn_seis
            // 
            this.btn_seis.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seis.Location = new System.Drawing.Point(274, 187);
            this.btn_seis.Name = "btn_seis";
            this.btn_seis.Size = new System.Drawing.Size(59, 41);
            this.btn_seis.TabIndex = 12;
            this.btn_seis.Text = "6";
            this.btn_seis.UseVisualStyleBackColor = true;
            this.btn_seis.Click += new System.EventHandler(this.btn_seis_Click);
            // 
            // btn_siete
            // 
            this.btn_siete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_siete.Location = new System.Drawing.Point(144, 234);
            this.btn_siete.Name = "btn_siete";
            this.btn_siete.Size = new System.Drawing.Size(59, 41);
            this.btn_siete.TabIndex = 13;
            this.btn_siete.Text = "7";
            this.btn_siete.UseVisualStyleBackColor = true;
            this.btn_siete.Click += new System.EventHandler(this.btn_siete_Click);
            // 
            // btn_ocho
            // 
            this.btn_ocho.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ocho.Location = new System.Drawing.Point(209, 234);
            this.btn_ocho.Name = "btn_ocho";
            this.btn_ocho.Size = new System.Drawing.Size(59, 41);
            this.btn_ocho.TabIndex = 14;
            this.btn_ocho.Text = "8";
            this.btn_ocho.UseVisualStyleBackColor = true;
            this.btn_ocho.Click += new System.EventHandler(this.btn_ocho_Click);
            // 
            // btn_nueve
            // 
            this.btn_nueve.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nueve.Location = new System.Drawing.Point(274, 234);
            this.btn_nueve.Name = "btn_nueve";
            this.btn_nueve.Size = new System.Drawing.Size(59, 41);
            this.btn_nueve.TabIndex = 15;
            this.btn_nueve.Text = "9";
            this.btn_nueve.UseVisualStyleBackColor = true;
            this.btn_nueve.Click += new System.EventHandler(this.btn_nueve_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_igual.Location = new System.Drawing.Point(339, 187);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(59, 135);
            this.btn_igual.TabIndex = 16;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicar.Location = new System.Drawing.Point(339, 83);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(59, 41);
            this.btn_multiplicar.TabIndex = 17;
            this.btn_multiplicar.Text = "*";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 382);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_nueve);
            this.Controls.Add(this.btn_ocho);
            this.Controls.Add(this.btn_siete);
            this.Controls.Add(this.btn_seis);
            this.Controls.Add(this.btn_cinco);
            this.Controls.Add(this.btn_cuatro);
            this.Controls.Add(this.btn_cero);
            this.Controls.Add(this.btn_tres);
            this.Controls.Add(this.btn_dos);
            this.Controls.Add(this.btn_uno);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_resta);
            this.Controls.Add(this.btn_suma);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.txtPantalla);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Button btn_resta;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_uno;
        private System.Windows.Forms.Button btn_dos;
        private System.Windows.Forms.Button btn_tres;
        private System.Windows.Forms.Button btn_cero;
        private System.Windows.Forms.Button btn_cuatro;
        private System.Windows.Forms.Button btn_cinco;
        private System.Windows.Forms.Button btn_seis;
        private System.Windows.Forms.Button btn_siete;
        private System.Windows.Forms.Button btn_ocho;
        private System.Windows.Forms.Button btn_nueve;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_multiplicar;
    }
}

