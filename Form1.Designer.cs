﻿namespace Tarea3_Calculadora
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
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.Numero1 = new System.Windows.Forms.Button();
            this.Numero2 = new System.Windows.Forms.Button();
            this.Numero3 = new System.Windows.Forms.Button();
            this.Suma = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Numero6 = new System.Windows.Forms.Button();
            this.Numero5 = new System.Windows.Forms.Button();
            this.Numero4 = new System.Windows.Forms.Button();
            this.Multiplicacion = new System.Windows.Forms.Button();
            this.Numero9 = new System.Windows.Forms.Button();
            this.Numero8 = new System.Windows.Forms.Button();
            this.Numero7 = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.BotonBorrar = new System.Windows.Forms.Button();
            this.BotonIgual = new System.Windows.Forms.Button();
            this.Numero0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.BackColor = System.Drawing.SystemColors.Info;
            this.Pantalla.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla.Location = new System.Drawing.Point(5, 8);
            this.Pantalla.Multiline = true;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(540, 117);
            this.Pantalla.TabIndex = 0;
            this.Pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Numero1
            // 
            this.Numero1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Numero1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero1.Location = new System.Drawing.Point(5, 131);
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(112, 46);
            this.Numero1.TabIndex = 1;
            this.Numero1.Text = "1";
            this.Numero1.UseVisualStyleBackColor = false;
            this.Numero1.Click += new System.EventHandler(this.Numero1_Click);
            // 
            // Numero2
            // 
            this.Numero2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Numero2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero2.Location = new System.Drawing.Point(151, 131);
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(112, 46);
            this.Numero2.TabIndex = 2;
            this.Numero2.Text = "2";
            this.Numero2.UseVisualStyleBackColor = false;
            this.Numero2.Click += new System.EventHandler(this.Numero2_Click);
            // 
            // Numero3
            // 
            this.Numero3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Numero3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero3.Location = new System.Drawing.Point(291, 131);
            this.Numero3.Name = "Numero3";
            this.Numero3.Size = new System.Drawing.Size(112, 46);
            this.Numero3.TabIndex = 3;
            this.Numero3.Text = "3";
            this.Numero3.UseVisualStyleBackColor = false;
            this.Numero3.Click += new System.EventHandler(this.Numero3_Click);
            // 
            // Suma
            // 
            this.Suma.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Suma.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suma.Location = new System.Drawing.Point(433, 131);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(112, 46);
            this.Suma.TabIndex = 4;
            this.Suma.Text = "+";
            this.Suma.UseVisualStyleBackColor = false;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Resta
            // 
            this.Resta.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Resta.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resta.Location = new System.Drawing.Point(433, 193);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(112, 46);
            this.Resta.TabIndex = 8;
            this.Resta.Text = "-";
            this.Resta.UseVisualStyleBackColor = false;
            this.Resta.Click += new System.EventHandler(this.Resta_Click);
            // 
            // Numero6
            // 
            this.Numero6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Numero6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero6.Location = new System.Drawing.Point(291, 193);
            this.Numero6.Name = "Numero6";
            this.Numero6.Size = new System.Drawing.Size(112, 46);
            this.Numero6.TabIndex = 7;
            this.Numero6.Text = "6";
            this.Numero6.UseVisualStyleBackColor = false;
            this.Numero6.Click += new System.EventHandler(this.Numero6_Click);
            // 
            // Numero5
            // 
            this.Numero5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Numero5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero5.Location = new System.Drawing.Point(151, 193);
            this.Numero5.Name = "Numero5";
            this.Numero5.Size = new System.Drawing.Size(112, 46);
            this.Numero5.TabIndex = 6;
            this.Numero5.Text = "5";
            this.Numero5.UseVisualStyleBackColor = false;
            this.Numero5.Click += new System.EventHandler(this.Numero5_Click);
            // 
            // Numero4
            // 
            this.Numero4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Numero4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero4.Location = new System.Drawing.Point(5, 193);
            this.Numero4.Name = "Numero4";
            this.Numero4.Size = new System.Drawing.Size(112, 46);
            this.Numero4.TabIndex = 5;
            this.Numero4.Text = "4";
            this.Numero4.UseVisualStyleBackColor = false;
            this.Numero4.Click += new System.EventHandler(this.Numero4_Click);
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Multiplicacion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicacion.Location = new System.Drawing.Point(433, 256);
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.Size = new System.Drawing.Size(112, 46);
            this.Multiplicacion.TabIndex = 12;
            this.Multiplicacion.Text = "x";
            this.Multiplicacion.UseVisualStyleBackColor = false;
            this.Multiplicacion.Click += new System.EventHandler(this.Multiplicacion_Click);
            // 
            // Numero9
            // 
            this.Numero9.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Numero9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero9.Location = new System.Drawing.Point(291, 256);
            this.Numero9.Name = "Numero9";
            this.Numero9.Size = new System.Drawing.Size(112, 46);
            this.Numero9.TabIndex = 11;
            this.Numero9.Text = "9";
            this.Numero9.UseVisualStyleBackColor = false;
            this.Numero9.Click += new System.EventHandler(this.Numero9_Click);
            // 
            // Numero8
            // 
            this.Numero8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Numero8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero8.Location = new System.Drawing.Point(151, 256);
            this.Numero8.Name = "Numero8";
            this.Numero8.Size = new System.Drawing.Size(112, 46);
            this.Numero8.TabIndex = 10;
            this.Numero8.Text = "8";
            this.Numero8.UseVisualStyleBackColor = false;
            this.Numero8.Click += new System.EventHandler(this.Numero8_Click);
            // 
            // Numero7
            // 
            this.Numero7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Numero7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero7.Location = new System.Drawing.Point(5, 256);
            this.Numero7.Name = "Numero7";
            this.Numero7.Size = new System.Drawing.Size(112, 46);
            this.Numero7.TabIndex = 9;
            this.Numero7.Text = "7";
            this.Numero7.UseVisualStyleBackColor = false;
            this.Numero7.Click += new System.EventHandler(this.Numero7_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Division.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.Location = new System.Drawing.Point(433, 313);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(112, 46);
            this.Division.TabIndex = 16;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // BotonBorrar
            // 
            this.BotonBorrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BotonBorrar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBorrar.Location = new System.Drawing.Point(291, 313);
            this.BotonBorrar.Name = "BotonBorrar";
            this.BotonBorrar.Size = new System.Drawing.Size(112, 46);
            this.BotonBorrar.TabIndex = 15;
            this.BotonBorrar.Text = "AC";
            this.BotonBorrar.UseVisualStyleBackColor = false;
            this.BotonBorrar.Click += new System.EventHandler(this.BotonBorrar_Click);
            // 
            // BotonIgual
            // 
            this.BotonIgual.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BotonIgual.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonIgual.Location = new System.Drawing.Point(151, 313);
            this.BotonIgual.Name = "BotonIgual";
            this.BotonIgual.Size = new System.Drawing.Size(112, 46);
            this.BotonIgual.TabIndex = 14;
            this.BotonIgual.Text = "=";
            this.BotonIgual.UseVisualStyleBackColor = false;
            this.BotonIgual.Click += new System.EventHandler(this.BotonIgual_Click);
            // 
            // Numero0
            // 
            this.Numero0.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Numero0.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero0.Location = new System.Drawing.Point(5, 313);
            this.Numero0.Name = "Numero0";
            this.Numero0.Size = new System.Drawing.Size(112, 46);
            this.Numero0.TabIndex = 13;
            this.Numero0.Text = "0";
            this.Numero0.UseVisualStyleBackColor = false;
            this.Numero0.Click += new System.EventHandler(this.Numero0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(551, 371);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.BotonBorrar);
            this.Controls.Add(this.BotonIgual);
            this.Controls.Add(this.Numero0);
            this.Controls.Add(this.Multiplicacion);
            this.Controls.Add(this.Numero9);
            this.Controls.Add(this.Numero8);
            this.Controls.Add(this.Numero7);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Numero6);
            this.Controls.Add(this.Numero5);
            this.Controls.Add(this.Numero4);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.Numero3);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Numero1);
            this.Controls.Add(this.Pantalla);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practica Calculadora Galaz_Molina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button Numero1;
        private System.Windows.Forms.Button Numero2;
        private System.Windows.Forms.Button Numero3;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Numero6;
        private System.Windows.Forms.Button Numero5;
        private System.Windows.Forms.Button Numero4;
        private System.Windows.Forms.Button Multiplicacion;
        private System.Windows.Forms.Button Numero9;
        private System.Windows.Forms.Button Numero8;
        private System.Windows.Forms.Button Numero7;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button BotonBorrar;
        private System.Windows.Forms.Button BotonIgual;
        private System.Windows.Forms.Button Numero0;
    }
}

