using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projet_BaseDonnee
{
    public partial class ConnectionPage : Form
    {
        static public MySqlConnection connection;
        public ConnectionPage()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
                connection = new MySqlConnection("server = localHost; user id = " + tbUserName.Text + "; pwd= " + tbPassword.Text);
                try
                {
                    connection.Open();
                    MessageBox.Show("Connecté");
                    if (connection.State ==  System.Data.ConnectionState.Open)
                    {

                        Hide();
                        MainPage mp = new MainPage();
                        mp.Show();
                    }
                }
                catch (MySqlException co)
                {
                     MessageBox.Show(co.ToString());
                    MessageBox.Show("Non Connecté");
                    connection.Close();
                }
        }

    }
}
