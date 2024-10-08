﻿namespace GymAkam
{
    partial class Cliente
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
            this.dt_client = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_enabled = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_clientID = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_mount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_expirationDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cb_options = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_client)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_client
            // 
            this.dt_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_client.Location = new System.Drawing.Point(9, 75);
            this.dt_client.Name = "dt_client";
            this.dt_client.ReadOnly = true;
            this.dt_client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_client.Size = new System.Drawing.Size(708, 184);
            this.dt_client.TabIndex = 0;
            this.dt_client.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_client_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(10, 320);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(148, 20);
            this.txt_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(211, 320);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(142, 20);
            this.txt_surname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Habilitado";
            // 
            // txt_enabled
            // 
            this.txt_enabled.Location = new System.Drawing.Point(393, 320);
            this.txt_enabled.Name = "txt_enabled";
            this.txt_enabled.Size = new System.Drawing.Size(136, 20);
            this.txt_enabled.TabIndex = 8;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(561, 471);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(84, 30);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Actualizar";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_delete
            // 
            this.txt_delete.Location = new System.Drawing.Point(561, 324);
            this.txt_delete.Name = "txt_delete";
            this.txt_delete.Size = new System.Drawing.Size(84, 29);
            this.txt_delete.TabIndex = 10;
            this.txt_delete.Text = "Borrar";
            this.txt_delete.UseVisualStyleBackColor = true;
            this.txt_delete.Click += new System.EventHandler(this.txt_delete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // txt_clientID
            // 
            this.txt_clientID.Location = new System.Drawing.Point(13, 385);
            this.txt_clientID.Name = "txt_clientID";
            this.txt_clientID.Size = new System.Drawing.Size(145, 20);
            this.txt_clientID.TabIndex = 12;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(211, 385);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(142, 20);
            this.txt_dni.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "DNI";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(199, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(119, 36);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(9, 34);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(142, 20);
            this.txt_search.TabIndex = 17;
            // 
            // txt_mount
            // 
            this.txt_mount.Location = new System.Drawing.Point(13, 471);
            this.txt_mount.Name = "txt_mount";
            this.txt_mount.Size = new System.Drawing.Size(142, 20);
            this.txt_mount.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Monto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Datos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Transaccion:";
            // 
            // txt_expirationDate
            // 
            this.txt_expirationDate.Location = new System.Drawing.Point(211, 471);
            this.txt_expirationDate.Name = "txt_expirationDate";
            this.txt_expirationDate.Size = new System.Drawing.Size(142, 20);
            this.txt_expirationDate.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 455);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Fecha vencimiento (AAAA-MM-DD)";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Habilitados",
            "Vencidos"});
            this.comboBox1.Location = new System.Drawing.Point(596, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Text = "Todos";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_options
            // 
            this.cb_options.FormattingEnabled = true;
            this.cb_options.Items.AddRange(new object[] {
            "Buscar por DNI",
            "Buscar por Apellido"});
            this.cb_options.Location = new System.Drawing.Point(9, 7);
            this.cb_options.Name = "cb_options";
            this.cb_options.Size = new System.Drawing.Size(121, 21);
            this.cb_options.TabIndex = 25;
            this.cb_options.Text = "Buscar por..";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_options);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_expirationDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_mount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_clientID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_enabled);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_client);
            this.Name = "Cliente";
            this.Text = "Contabilidad";
            ((System.ComponentModel.ISupportInitialize)(this.dt_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_enabled;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button txt_delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_clientID;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_mount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_expirationDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cb_options;
        private System.Windows.Forms.Button button1;
    }
}