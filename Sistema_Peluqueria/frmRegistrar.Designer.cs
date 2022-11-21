
namespace Sistema_Peluqueria
{
    partial class frmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_guardar_usuario = new System.Windows.Forms.TextBox();
            this.txt_guardar_pass = new System.Windows.Forms.TextBox();
            this.txt_guardar_confirmarpass = new System.Windows.Forms.TextBox();
            this.txt_guardar_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboTipos = new System.Windows.Forms.ComboBox();
            this.btn_salirR = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_registarU = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(126, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(99, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(26, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // txt_guardar_usuario
            // 
            this.txt_guardar_usuario.Location = new System.Drawing.Point(194, 118);
            this.txt_guardar_usuario.Name = "txt_guardar_usuario";
            this.txt_guardar_usuario.Size = new System.Drawing.Size(121, 20);
            this.txt_guardar_usuario.TabIndex = 1;
            // 
            // txt_guardar_pass
            // 
            this.txt_guardar_pass.Location = new System.Drawing.Point(194, 157);
            this.txt_guardar_pass.Name = "txt_guardar_pass";
            this.txt_guardar_pass.PasswordChar = '*';
            this.txt_guardar_pass.Size = new System.Drawing.Size(121, 20);
            this.txt_guardar_pass.TabIndex = 2;
            // 
            // txt_guardar_confirmarpass
            // 
            this.txt_guardar_confirmarpass.Location = new System.Drawing.Point(194, 194);
            this.txt_guardar_confirmarpass.Name = "txt_guardar_confirmarpass";
            this.txt_guardar_confirmarpass.PasswordChar = '*';
            this.txt_guardar_confirmarpass.Size = new System.Drawing.Size(121, 20);
            this.txt_guardar_confirmarpass.TabIndex = 3;
            // 
            // txt_guardar_nombre
            // 
            this.txt_guardar_nombre.Location = new System.Drawing.Point(194, 234);
            this.txt_guardar_nombre.Name = "txt_guardar_nombre";
            this.txt_guardar_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_guardar_nombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(123, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(67, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo De Usuario";
            // 
            // comboTipos
            // 
            this.comboTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipos.FormattingEnabled = true;
            this.comboTipos.Location = new System.Drawing.Point(194, 267);
            this.comboTipos.Name = "comboTipos";
            this.comboTipos.Size = new System.Drawing.Size(121, 21);
            this.comboTipos.TabIndex = 5;
            this.comboTipos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_salirR
            // 
            this.btn_salirR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_salirR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salirR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salirR.Image = global::Sistema_Peluqueria.Properties.Resources.exit_icon_icons_com_70975;
            this.btn_salirR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salirR.Location = new System.Drawing.Point(141, 379);
            this.btn_salirR.Name = "btn_salirR";
            this.btn_salirR.Size = new System.Drawing.Size(87, 39);
            this.btn_salirR.TabIndex = 8;
            this.btn_salirR.Text = "Salir";
            this.btn_salirR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salirR.UseVisualStyleBackColor = false;
            this.btn_salirR.Click += new System.EventHandler(this.btn_salirR_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::Sistema_Peluqueria.Properties.Resources.Delete_80_icon_icons_com_57340;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(194, 326);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(109, 39);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_registarU
            // 
            this.btn_registarU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_registarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registarU.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registarU.Image = global::Sistema_Peluqueria.Properties.Resources.Add_User_80_icon_icons_com_57380;
            this.btn_registarU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registarU.Location = new System.Drawing.Point(80, 326);
            this.btn_registarU.Name = "btn_registarU";
            this.btn_registarU.Size = new System.Drawing.Size(108, 39);
            this.btn_registarU.TabIndex = 6;
            this.btn_registarU.Text = "Registar";
            this.btn_registarU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_registarU.UseVisualStyleBackColor = false;
            this.btn_registarU.Click += new System.EventHandler(this.btn_registarU_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 84);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(77, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Registrar Usuario";
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(361, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboTipos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_guardar_nombre);
            this.Controls.Add(this.btn_salirR);
            this.Controls.Add(this.txt_guardar_confirmarpass);
            this.Controls.Add(this.txt_guardar_pass);
            this.Controls.Add(this.txt_guardar_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_registarU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registar Usuarios";
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_registarU;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_guardar_usuario;
        private System.Windows.Forms.TextBox txt_guardar_pass;
        private System.Windows.Forms.TextBox txt_guardar_confirmarpass;
        private System.Windows.Forms.Button btn_salirR;
        private System.Windows.Forms.TextBox txt_guardar_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboTipos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}