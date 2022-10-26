
namespace Ejercicio
{
    partial class frmEmpleado
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
            this.labelNombreCompleto = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelCasado = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.textNombreCompleto = new System.Windows.Forms.TextBox();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textSalario = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.checkBoxCasado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelNombreCompleto
            // 
            this.labelNombreCompleto.AutoSize = true;
            this.labelNombreCompleto.Location = new System.Drawing.Point(64, 52);
            this.labelNombreCompleto.Name = "labelNombreCompleto";
            this.labelNombreCompleto.Size = new System.Drawing.Size(110, 15);
            this.labelNombreCompleto.TabIndex = 0;
            this.labelNombreCompleto.Text = "Nombre Completo:";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(64, 93);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(30, 15);
            this.labelDNI.TabIndex = 1;
            this.labelDNI.Text = "DNI:";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(64, 134);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(36, 15);
            this.labelEdad.TabIndex = 2;
            this.labelEdad.Text = "Edad:";
            // 
            // labelCasado
            // 
            this.labelCasado.AutoSize = true;
            this.labelCasado.Location = new System.Drawing.Point(64, 175);
            this.labelCasado.Name = "labelCasado";
            this.labelCasado.Size = new System.Drawing.Size(49, 15);
            this.labelCasado.TabIndex = 3;
            this.labelCasado.Text = "Casado:";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(64, 216);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(45, 15);
            this.labelSalario.TabIndex = 4;
            this.labelSalario.Text = "Salario:";
            // 
            // textNombreCompleto
            // 
            this.textNombreCompleto.Location = new System.Drawing.Point(191, 49);
            this.textNombreCompleto.Name = "textNombreCompleto";
            this.textNombreCompleto.Size = new System.Drawing.Size(100, 23);
            this.textNombreCompleto.TabIndex = 5;
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(191, 90);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(100, 23);
            this.textDNI.TabIndex = 6;
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(191, 126);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(100, 23);
            this.textEdad.TabIndex = 7;
            // 
            // textSalario
            // 
            this.textSalario.Location = new System.Drawing.Point(191, 213);
            this.textSalario.Name = "textSalario";
            this.textSalario.Size = new System.Drawing.Size(100, 23);
            this.textSalario.TabIndex = 9;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(90, 279);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(68, 23);
            this.buttonAceptar.TabIndex = 10;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(191, 279);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(68, 23);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // checkBoxCasado
            // 
            this.checkBoxCasado.AutoSize = true;
            this.checkBoxCasado.Location = new System.Drawing.Point(191, 171);
            this.checkBoxCasado.Name = "checkBoxCasado";
            this.checkBoxCasado.Size = new System.Drawing.Size(35, 19);
            this.checkBoxCasado.TabIndex = 12;
            this.checkBoxCasado.Text = "Si";
            this.checkBoxCasado.UseVisualStyleBackColor = true;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 367);
            this.Controls.Add(this.checkBoxCasado);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textSalario);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.textNombreCompleto);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.labelCasado);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelNombreCompleto);
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreCompleto;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelCasado;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.TextBox textNombreCompleto;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textSalario;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.CheckBox checkBoxCasado;
    }
}