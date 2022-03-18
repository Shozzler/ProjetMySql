namespace Projet_BaseDonnee
{
    partial class ConnectionPage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblTitlePassword = new System.Windows.Forms.Label();
            this.lblTitleUser = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(235, 9);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(335, 25);
            this.lblMainTitle.TabIndex = 11;
            this.lblMainTitle.Text = "Projet-ConnectionBaseDonnée";
            // 
            // lblTitlePassword
            // 
            this.lblTitlePassword.AutoSize = true;
            this.lblTitlePassword.Location = new System.Drawing.Point(310, 214);
            this.lblTitlePassword.Name = "lblTitlePassword";
            this.lblTitlePassword.Size = new System.Drawing.Size(53, 13);
            this.lblTitlePassword.TabIndex = 10;
            this.lblTitlePassword.Text = "Password";
            // 
            // lblTitleUser
            // 
            this.lblTitleUser.AutoSize = true;
            this.lblTitleUser.Location = new System.Drawing.Point(310, 149);
            this.lblTitleUser.Name = "lblTitleUser";
            this.lblTitleUser.Size = new System.Drawing.Size(55, 13);
            this.lblTitleUser.TabIndex = 9;
            this.lblTitleUser.Text = "Username";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(313, 230);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(162, 20);
            this.tbPassword.TabIndex = 8;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(313, 165);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(162, 20);
            this.tbUserName.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(313, 321);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(162, 74);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Se Connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // ConnectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.lblTitlePassword);
            this.Controls.Add(this.lblTitleUser);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.btnConnect);
            this.Name = "ConnectionPage";
            this.Text = "P042";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblTitlePassword;
        private System.Windows.Forms.Label lblTitleUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btnConnect;
    }
}

