using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;



namespace Projet_BaseDonnee
{
    public partial class MainPage : Form
    {
        MySql.Data.MySqlClient.MySqlCommand _mySqlCommand;
        MySql.Data.MySqlClient.MySqlDataReader _mySqlDataReader;
        DataSet _dataSet;
        MySqlDataAdapter _dataAdapter;
        DataGridView DV = new DataGridView();
        string temp;
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

            TreeNode tn;
            _mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
            _mySqlCommand.CommandText = "Show DataBases;";
            

            if(ConnectionPage.connection.State == System.Data.ConnectionState.Closed)
            {
               ConnectionPage.connection.Open();

            }
            _mySqlCommand.Connection = ConnectionPage.connection;
            _mySqlDataReader = _mySqlCommand.ExecuteReader();
            while (_mySqlDataReader.Read())
            {
                tn = new TreeNode();
                tn.Text = _mySqlDataReader[0].ToString();
                tvDatabase.Nodes.Add(tn);
               
            }
            _mySqlDataReader.Close();
            for(int x = 0; x < tvDatabase.Nodes.Count; x++)
            {
                _mySqlCommand.CommandText = $"Use {tvDatabase.Nodes[x].Text} ;";
                _mySqlCommand.ExecuteNonQuery();
                _mySqlCommand.CommandText = $"show tables;";

                _mySqlDataReader = _mySqlCommand.ExecuteReader();
                while (_mySqlDataReader.Read())
                {
                    tn = tvDatabase.Nodes[x];
                    tn.Nodes.Add(_mySqlDataReader[0].ToString());
                }
                _mySqlDataReader.Close();
            }
           
        }

      

        private void BtnCreateDataB_Click(object sender, EventArgs e)
        {
            Hide();
            NewDatabase nd = new NewDatabase();
            nd.Show();

        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreaTables_Click(object sender, EventArgs e)
        {
            Hide();
            NewTable nt = new NewTable(temp);
            nt.Show();
        }

        private void TvDatabase_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(tvDatabase.SelectedNode.Parent != null)
            {
                string sql = $"SELECT * FROM {tvDatabase.SelectedNode.Parent.Text}.{tvDatabase.SelectedNode.Text} ;";
                if (ConnectionPage.connection.State == System.Data.ConnectionState.Closed)
                {
                    ConnectionPage.connection.Open();

                }
                _mySqlCommand.Connection = ConnectionPage.connection;
                _dataSet = new DataSet();
                _dataAdapter = new MySqlDataAdapter(sql,ConnectionPage.connection);
                MySqlCommandBuilder cb = new  MySqlCommandBuilder(_dataAdapter); //Builder fait appelle à databuilder
                _dataAdapter.Fill(_dataSet, tvDatabase.SelectedNode.Text);
                DV.DataSource = _dataSet;
                DV.DataMember = tvDatabase.SelectedNode.Text;
                this.Controls.Remove(tvDatabase);
                DV.Location = tvDatabase.Location;
                DV.Size = tvDatabase.Size;
                this.Controls.Add(DV);
            }        

            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(DV);
            this.Controls.Add(tvDatabase);
        }

        private void TvDatabase_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Program.currentDataBase = e.Node.FullPath;
            temp = Program.currentDataBase.Replace('\\', '.');
        }
    }
}
