﻿namespace Inicio_de_Sesion
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
            this.usulb = new System.Windows.Forms.Label();
            this.usutb = new System.Windows.Forms.TextBox();
            this.contrabt = new System.Windows.Forms.TextBox();
            this.contlb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usulb
            // 
            this.usulb.AutoSize = true;
            this.usulb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usulb.Location = new System.Drawing.Point(63, 101);
            this.usulb.Name = "usulb";
            this.usulb.Size = new System.Drawing.Size(79, 24);
            this.usulb.TabIndex = 0;
            this.usulb.Text = "Usuario:";
            // 
            // usutb
            // 
            this.usutb.Location = new System.Drawing.Point(148, 106);
            this.usutb.Name = "usutb";
            this.usutb.Size = new System.Drawing.Size(199, 20);
            this.usutb.TabIndex = 1;
            this.usutb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Usutb_KeyDown);
            // 
            // contrabt
            // 
            this.contrabt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrabt.Location = new System.Drawing.Point(180, 148);
            this.contrabt.Name = "contrabt";
            this.contrabt.PasswordChar = '*';
            this.contrabt.Size = new System.Drawing.Size(167, 22);
            this.contrabt.TabIndex = 2;
            this.contrabt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Contrabt_KeyDown);
            // 
            // contlb
            // 
            this.contlb.AutoSize = true;
            this.contlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contlb.Location = new System.Drawing.Point(63, 143);
            this.contlb.Name = "contlb";
            this.contlb.Size = new System.Drawing.Size(111, 24);
            this.contlb.TabIndex = 3;
            this.contlb.Text = "Contraseña:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inicio de sesion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contlb);
            this.Controls.Add(this.contrabt);
            this.Controls.Add(this.usutb);
            this.Controls.Add(this.usulb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usulb;
        private System.Windows.Forms.TextBox usutb;
        private System.Windows.Forms.TextBox contrabt;
        private System.Windows.Forms.Label contlb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

