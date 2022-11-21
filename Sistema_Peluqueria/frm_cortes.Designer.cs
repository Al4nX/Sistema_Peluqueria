
namespace Sistema_Peluqueria
{
    partial class frm_cortes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cortes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_Cortes = new System.Windows.Forms.ComboBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.combo_Peluqueros = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_Clientes = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_historial = new System.Windows.Forms.Button();
            this.btn_nuevo_corte = new System.Windows.Forms.Button();
            this.btn_salirRC = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 412);
            this.panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(54, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Corte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(368, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Peluquero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(395, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha";
            // 
            // combo_Cortes
            // 
            this.combo_Cortes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Cortes.FormattingEnabled = true;
            this.combo_Cortes.Location = new System.Drawing.Point(107, 178);
            this.combo_Cortes.Name = "combo_Cortes";
            this.combo_Cortes.Size = new System.Drawing.Size(219, 21);
            this.combo_Cortes.TabIndex = 2;
            this.combo_Cortes.SelectedIndexChanged += new System.EventHandler(this.combo_Cortes_SelectedIndexChanged);
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(453, 126);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(219, 20);
            this.fecha.TabIndex = 3;
            // 
            // combo_Peluqueros
            // 
            this.combo_Peluqueros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Peluqueros.FormattingEnabled = true;
            this.combo_Peluqueros.Location = new System.Drawing.Point(453, 179);
            this.combo_Peluqueros.Name = "combo_Peluqueros";
            this.combo_Peluqueros.Size = new System.Drawing.Size(219, 21);
            this.combo_Peluqueros.TabIndex = 4;
            this.combo_Peluqueros.SelectedIndexChanged += new System.EventHandler(this.combo_Peluqueros_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(36, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Clientes";
            // 
            // combo_Clientes
            // 
            this.combo_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Clientes.FormattingEnabled = true;
            this.combo_Clientes.Location = new System.Drawing.Point(107, 123);
            this.combo_Clientes.Name = "combo_Clientes";
            this.combo_Clientes.Size = new System.Drawing.Size(219, 21);
            this.combo_Clientes.TabIndex = 1;
            this.combo_Clientes.SelectedIndexChanged += new System.EventHandler(this.combo_Clientes_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-2, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 90);
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(420, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Haga su Corte";
            // 
            // btn_historial
            // 
            this.btn_historial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historial.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historial.Image = global::Sistema_Peluqueria.Properties.Resources._4552611_check_listing_loupe_magnifier_magnifying_glass_search_121392;
            this.btn_historial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_historial.Location = new System.Drawing.Point(908, 114);
            this.btn_historial.Name = "btn_historial";
            this.btn_historial.Size = new System.Drawing.Size(131, 42);
            this.btn_historial.TabIndex = 6;
            this.btn_historial.Text = "Historial";
            this.btn_historial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_historial.UseVisualStyleBackColor = false;
            this.btn_historial.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_nuevo_corte
            // 
            this.btn_nuevo_corte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_nuevo_corte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_corte.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_corte.Image = global::Sistema_Peluqueria.Properties.Resources.fullcut_cut_scissors_4720;
            this.btn_nuevo_corte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo_corte.Location = new System.Drawing.Point(734, 114);
            this.btn_nuevo_corte.Name = "btn_nuevo_corte";
            this.btn_nuevo_corte.Size = new System.Drawing.Size(168, 42);
            this.btn_nuevo_corte.TabIndex = 5;
            this.btn_nuevo_corte.Text = "Nuevo Corte";
            this.btn_nuevo_corte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuevo_corte.UseVisualStyleBackColor = false;
            this.btn_nuevo_corte.Click += new System.EventHandler(this.btn_nuevo_corte_Click);
            // 
            // btn_salirRC
            // 
            this.btn_salirRC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_salirRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salirRC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salirRC.Image = global::Sistema_Peluqueria.Properties.Resources.exit_icon_icons_com_70975;
            this.btn_salirRC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salirRC.Location = new System.Drawing.Point(933, 171);
            this.btn_salirRC.Name = "btn_salirRC";
            this.btn_salirRC.Size = new System.Drawing.Size(87, 37);
            this.btn_salirRC.TabIndex = 8;
            this.btn_salirRC.Text = "Salir";
            this.btn_salirRC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salirRC.UseVisualStyleBackColor = false;
            this.btn_salirRC.Click += new System.EventHandler(this.btn_salirRC_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Image = global::Sistema_Peluqueria.Properties.Resources.refresh_arrow_icon_icons_com_73442;
            this.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actualizar.Location = new System.Drawing.Point(755, 171);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(121, 37);
            this.btn_actualizar.TabIndex = 7;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // frm_cortes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1072, 660);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_historial);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_nuevo_corte);
            this.Controls.Add(this.btn_salirRC);
            this.Controls.Add(this.combo_Clientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_Peluqueros);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.combo_Cortes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_cortes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cortes Hombres";
            this.Load += new System.EventHandler(this.frm_cortes_hombres_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_Cortes;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.ComboBox combo_Peluqueros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_Clientes;
        private System.Windows.Forms.Button btn_salirRC;
        private System.Windows.Forms.Button btn_nuevo_corte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_historial;
        private System.Windows.Forms.Button btn_actualizar;
    }
}