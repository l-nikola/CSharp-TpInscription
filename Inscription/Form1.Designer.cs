
namespace Inscription
{
    partial class Form1
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
            this.SansCompte = new System.Windows.Forms.Label();
            this.CreerCompte = new System.Windows.Forms.GroupBox();
            this.btnInscription = new System.Windows.Forms.Button();
            this.ExisteCompte = new System.Windows.Forms.GroupBox();
            this.txtBoxMdp = new System.Windows.Forms.TextBox();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.btnMdpOublie = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.mdp = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.AvecCompte = new System.Windows.Forms.Label();
            this.CreerCompte.SuspendLayout();
            this.ExisteCompte.SuspendLayout();
            this.SuspendLayout();
            // 
            // SansCompte
            // 
            this.SansCompte.AutoSize = true;
            this.SansCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SansCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SansCompte.Location = new System.Drawing.Point(53, 52);
            this.SansCompte.Name = "SansCompte";
            this.SansCompte.Size = new System.Drawing.Size(276, 25);
            this.SansCompte.TabIndex = 3;
            this.SansCompte.Text = "Vous n\'avez pas de compte";
            // 
            // CreerCompte
            // 
            this.CreerCompte.Controls.Add(this.btnInscription);
            this.CreerCompte.Location = new System.Drawing.Point(30, 91);
            this.CreerCompte.Name = "CreerCompte";
            this.CreerCompte.Size = new System.Drawing.Size(317, 306);
            this.CreerCompte.TabIndex = 4;
            this.CreerCompte.TabStop = false;
            this.CreerCompte.Text = "Créer un compte";
            // 
            // btnInscription
            // 
            this.btnInscription.Location = new System.Drawing.Point(95, 129);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(123, 63);
            this.btnInscription.TabIndex = 0;
            this.btnInscription.Text = "S\'inscrire en tant que demandeur";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // ExisteCompte
            // 
            this.ExisteCompte.Controls.Add(this.txtBoxMdp);
            this.ExisteCompte.Controls.Add(this.txtBoxLogin);
            this.ExisteCompte.Controls.Add(this.btnMdpOublie);
            this.ExisteCompte.Controls.Add(this.btnValider);
            this.ExisteCompte.Controls.Add(this.mdp);
            this.ExisteCompte.Controls.Add(this.login);
            this.ExisteCompte.Location = new System.Drawing.Point(435, 91);
            this.ExisteCompte.Name = "ExisteCompte";
            this.ExisteCompte.Size = new System.Drawing.Size(332, 306);
            this.ExisteCompte.TabIndex = 5;
            this.ExisteCompte.TabStop = false;
            this.ExisteCompte.Text = "Compte Existant";
            // 
            // txtBoxMdp
            // 
            this.txtBoxMdp.Location = new System.Drawing.Point(171, 154);
            this.txtBoxMdp.Name = "txtBoxMdp";
            this.txtBoxMdp.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMdp.TabIndex = 5;
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(171, 118);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLogin.TabIndex = 4;
            // 
            // btnMdpOublie
            // 
            this.btnMdpOublie.Location = new System.Drawing.Point(171, 222);
            this.btnMdpOublie.Name = "btnMdpOublie";
            this.btnMdpOublie.Size = new System.Drawing.Size(155, 23);
            this.btnMdpOublie.TabIndex = 3;
            this.btnMdpOublie.Text = "J\'ai oublié mon mot de passe";
            this.btnMdpOublie.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(61, 222);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Location = new System.Drawing.Point(58, 157);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(71, 13);
            this.mdp.TabIndex = 1;
            this.mdp.Text = "Mot de passe";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(58, 125);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(33, 13);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            // 
            // AvecCompte
            // 
            this.AvecCompte.AutoSize = true;
            this.AvecCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvecCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AvecCompte.Location = new System.Drawing.Point(472, 52);
            this.AvecCompte.Name = "AvecCompte";
            this.AvecCompte.Size = new System.Drawing.Size(266, 25);
            this.AvecCompte.TabIndex = 6;
            this.AvecCompte.Text = "Vous avez déjà un compte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 419);
            this.Controls.Add(this.AvecCompte);
            this.Controls.Add(this.ExisteCompte);
            this.Controls.Add(this.CreerCompte);
            this.Controls.Add(this.SansCompte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CreerCompte.ResumeLayout(false);
            this.ExisteCompte.ResumeLayout(false);
            this.ExisteCompte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SansCompte;
        private System.Windows.Forms.GroupBox CreerCompte;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.GroupBox ExisteCompte;
        private System.Windows.Forms.TextBox txtBoxMdp;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Button btnMdpOublie;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label AvecCompte;
    }
}

