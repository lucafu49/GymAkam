﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GymAkam
{
    public partial class Form1 : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["GymAkam.Properties.Settings.GymAkamConnectionString"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            DeshabilitarClientesVencidos();
        }

        private void DeshabilitarClientesVencidos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para deshabilitar clientes basándonos en la última transacción registrada
                    string query = @"
                UPDATE Cliente
                SET Habilitado = 0
                FROM Cliente
                INNER JOIN (
                    SELECT IDCliente, MAX(IDTransaccion) AS UltimaTransaccionID
                    FROM Transacciones
                    GROUP BY IDCliente
                ) AS UltimaTransaccion
                ON Cliente.ClienteID = UltimaTransaccion.IDCliente
                INNER JOIN Transacciones ON Transacciones.IDTransaccion = UltimaTransaccion.UltimaTransaccionID
                WHERE Transacciones.FechaVencimiento < GETDATE()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"{rowsAffected} cliente(s) deshabilitado(s) correctamente.", "Clientes Deshabilitados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al deshabilitar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
        }

        private void btn_renew_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Show();
        }

        private void btn_paymentType_Click(object sender, EventArgs e)
        {
            Ganancias g = new Ganancias();
            g.Show();
        }
    }
}
