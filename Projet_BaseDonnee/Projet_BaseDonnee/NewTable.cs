using System;
using System.Collections.Generic;
///ETML 
///Author : Sean Ford
///Date   : 11.03.2022
///Summary: Page de création d'une nouvelle table 
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projet_BaseDonnee
{
    public  partial class NewTable : Form
    {
    
        public MySqlConnection connection = ConnectionPage.connection;
        public string dbName =""; // a implementer
        List<TextBox> arrColumnNames = new List<TextBox>();
        List<ComboBox> arrColumnTypes = new List<ComboBox>();
        List<NumericUpDown> arrColumnSizes = new List<NumericUpDown>();
        int lastY = 2;

        public NewTable(string dbname)
        {
            InitializeComponent();
            this.dbName = dbname;
        }
        /// <summary>
        /// Ajouter des elements graphiques qui aident l'utilisateur a gerer les colonnes, leurs type, leurs taille
        /// </summary>
        /// <cke:param name="nbColumn"></cke:param>nombre de colonnes a ajouter</cke:param>
        public void AddColumn(int nbColumn)
        {
            for (int i = 0; i < nbColumn; i++)
            {
                lastY += 30;
                TextBox colName = new TextBox();
                colName.Location = new Point(10, lastY);
                pnlTableColumns.Controls.Add(colName);
                ComboBox colType = new ComboBox();
                colType.Location = new Point(120, lastY);
                colType.Width = 70;
                colType.Items.Add("int");
                colType.Items.Add("varchar");
                colType.Items.Add("float");
                colType.SelectedIndex = 0;
                pnlTableColumns.Controls.Add(colType);
                NumericUpDown colSize = new NumericUpDown();
                colSize.Location = new Point(200, lastY);
                colSize.Width = 70;
                pnlTableColumns.Controls.Add(colSize);
                arrColumnNames.Add(colName);
                arrColumnTypes.Add(colType);
                arrColumnSizes.Add(colSize);
            }
        }
        private void NewTable_Load(object sender, EventArgs e)
        {
            AddColumn(2);
        }
        public string GenerateTableCreationQuery()
        {
            // il faut initsaliser dbName
            MySqlCommand command = new MySqlCommand("use " + dbName + ";", ConnectionPage.connection);
            command.ExecuteNonQuery();
            string query = "CREATE TABLE " + txtTableName.Text   + "(";
            for (int i = 0; i < arrColumnNames.Count; i++)
            {
                if (i != 0 && i < arrColumnNames.Count)
                    query += ",";
                string _columnName = arrColumnNames[i].Text;
                string _columnType = arrColumnTypes[i].Text;
                int _columnSize = (int)arrColumnSizes[i].Value;
                if (_columnName != "")
                    query += string.Format("`{0}` {1}({2})", _columnName, _columnType, _columnSize);
            }
            query += ")";
            return query;
        }



        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            Hide();
            MainPage MP = new MainPage();
            MP.Show();
        }

        private void BtnAjt_Click(object sender, EventArgs e)
        {
            AddColumn((int)numericUpDown1.Value);
        }

        private void BtnCreateTable_Click(object sender, EventArgs e)
        {
            MySqlCommand newDbCMD = new MySqlCommand(GenerateTableCreationQuery(), ConnectionPage.connection);
            newDbCMD.ExecuteNonQuery();
        }
    }
}


