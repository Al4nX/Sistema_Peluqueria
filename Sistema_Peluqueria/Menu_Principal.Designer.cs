
namespace Sistema_Peluqueria
{
    partial class Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.btn_salirMP = new System.Windows.Forms.Button();
            this.btn_nuevo_corte = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salirMP
            // 
            this.btn_salirMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_salirMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salirMP.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salirMP.Image = global::Sistema_Peluqueria.Properties.Resources.exit_icon_icons_com_70975;
            this.btn_salirMP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salirMP.Location = new System.Drawing.Point(217, 214);
            this.btn_salirMP.Name = "btn_salirMP";
            this.btn_salirMP.Size = new System.Drawing.Size(96, 42);
            this.btn_salirMP.TabIndex = 3;
            this.btn_salirMP.Text = "Salir";
            this.btn_salirMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salirMP.UseVisualStyleBackColor = false;
            this.btn_salirMP.Click += new System.EventHandler(this.btn_salirMP_Click);
            // 
            // btn_nuevo_corte
            // 
            this.btn_nuevo_corte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_nuevo_corte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_corte.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_corte.Image = global::Sistema_Peluqueria.Properties.Resources.fullcut_cut_scissors_4720;
            this.btn_nuevo_corte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo_corte.Location = new System.Drawing.Point(31, 137);
            this.btn_nuevo_corte.Name = "btn_nuevo_corte";
            this.btn_nuevo_corte.Size = new System.Drawing.Size(171, 42);
            this.btn_nuevo_corte.TabIndex = 1;
            this.btn_nuevo_corte.Text = "Nuevo Corte";
            this.btn_nuevo_corte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuevo_corte.UseVisualStyleBackColor = false;
            this.btn_nuevo_corte.Click += new System.EventHandler(this.btn_nuevo_corte_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.Image = global::Sistema_Peluqueria.Properties.Resources.Add_User_80_icon_icons_com_57380;
            this.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cliente.Location = new System.Drawing.Point(347, 137);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(130, 42);
            this.btn_cliente.TabIndex = 2;
            this.btn_cliente.Text = "Clientes";
            this.btn_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 93);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(124, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu Principal";
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(514, 283);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_salirMP);
            this.Controls.Add(this.btn_nuevo_corte);
            this.Controls.Add(this.btn_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_nuevo_corte;
        private System.Windows.Forms.Button btn_salirMP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}