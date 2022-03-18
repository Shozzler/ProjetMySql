using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Projet_BaseDonnee
{
    public partial class NewDatabase : Form
    {
        string str;

        public NewDatabase()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            MySqlCommand cmdCreate = new MySqlCommand("CREATE DATABASE "+tbDBName.Text+";", ConnectionPage.connection);
            if(ConnectionPage.connection.State ==  System.Data.ConnectionState.Open)
            {
                try
                {
                    cmdCreate.ExecuteNonQuery();
                    MessageBox.Show("DataBase is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vous avez un problème de connection", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            MainPage mp = new MainPage();
            mp.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            MySqlCommand cmdDrop = new MySqlCommand("DROP DATABASE " + tbDBName.Text + ";", ConnectionPage.connection);

            if (ConnectionPage.connection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    cmdDrop.ExecuteNonQuery();
                    MessageBox.Show("DataBase wad Successfully deleted", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Database wasn't deleted", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }   
}
