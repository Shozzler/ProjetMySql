namespace Projet_BaseDonnee
{
    partial class MainPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateDataB = new System.Windows.Forms.Button();
            this.btnCreaTables = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.tvDatabase = new System.Windows.Forms.TreeView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.Location = new System.Drawing.Point(767, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(702, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connected";
            // 
            // btnCreateDataB
            // 
            this.btnCreateDataB.Location = new System.Drawing.Point(45, 89);
            this.btnCreateDataB.Name = "btnCreateDataB";
            this.btnCreateDataB.Size = new System.Drawing.Size(132, 58);
            this.btnCreateDataB.TabIndex = 4;
            this.btnCreateDataB.Text = "Create/Delete Database";
            this.btnCreateDataB.UseVisualStyleBackColor = true;
            this.btnCreateDataB.Click += new System.EventHandler(this.BtnCreateDataB_Click);
            // 
            // btnCreaTables
            // 
            this.btnCreaTables.Location = new System.Drawing.Point(45, 189);
            this.btnCreaTables.Name = "btnCreaTables";
            this.btnCreaTables.Size = new System.Drawing.Size(132, 58);
            this.btnCreaTables.TabIndex = 5;
            this.btnCreaTables.Text = "Create Tables";
            this.btnCreaTables.UseVisualStyleBackColor = true;
            this.btnCreaTables.Click += new System.EventHandler(this.BtnCreaTables_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(45, 298);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(132, 58);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(236, 12);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(335, 25);
            this.lblMainTitle.TabIndex = 12;
            this.lblMainTitle.Text = "Projet-ConnectionBaseDonnée";
            // 
            // tvDatabase
            // 
            this.tvDatabase.Location = new System.Drawing.Point(241, 89);
            this.tvDatabase.Name = "tvDatabase";
            this.tvDatabase.Size = new System.Drawing.Size(410, 267);
            this.tvDatabase.TabIndex = 13;
            this.tvDatabase.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TvDatabase_NodeMouseClick);
            this.tvDatabase.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TvDatabase_MouseDoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(686, 89);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tvDatabase);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnCreaTables);
            this.Controls.Add(this.btnCreateDataB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Text = "P042";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateDataB;
        private System.Windows.Forms.Button btnCreaTables;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.TreeView tvDatabase;
        private System.Windows.Forms.Button btnBack;
    }
}