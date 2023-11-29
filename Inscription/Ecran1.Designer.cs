
namespace Inscription
{
    partial class Ecran1
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
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.txtBoxMdp = new System.Windows.Forms.TextBox();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.btnRAZ = new System.Windows.Forms.Button();
            this.btnInscription = new System.Windows.Forms.Button();
            this.btnObtientLogin = new System.Windows.Forms.Button();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.LabelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelmdp = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(187, 44);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNom.TabIndex = 0;
            // 
            // txtBoxMdp
            // 
            this.txtBoxMdp.Location = new System.Drawing.Point(187, 322);
            this.txtBoxMdp.Name = "txtBoxMdp";
            this.txtBoxMdp.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMdp.TabIndex = 1;
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(187, 150);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMail.TabIndex = 2;
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(187, 96);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrenom.TabIndex = 3;
            // 
            // btnRAZ
            // 
            this.btnRAZ.Location = new System.Drawing.Point(337, 424);
            this.btnRAZ.Name = "btnRAZ";
            this.btnRAZ.Size = new System.Drawing.Size(75, 23);
            this.btnRAZ.TabIndex = 5;
            this.btnRAZ.Text = "RAZ";
            this.btnRAZ.UseVisualStyleBackColor = true;
            this.btnRAZ.Click += new System.EventHandler(this.btnRAZ_Click);
            // 
            // btnInscription
            // 
            this.btnInscription.Location = new System.Drawing.Point(35, 424);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(171, 23);
            this.btnInscription.TabIndex = 6;
            this.btnInscription.Text = "Poursuivre avec votre inscription";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // btnObtientLogin
            // 
            this.btnObtientLogin.Location = new System.Drawing.Point(180, 202);
            this.btnObtientLogin.Name = "btnObtientLogin";
            this.btnObtientLogin.Size = new System.Drawing.Size(107, 23);
            this.btnObtientLogin.TabIndex = 7;
            this.btnObtientLogin.Text = "Obtenir votre Login ";
            this.btnObtientLogin.UseVisualStyleBackColor = true;
            this.btnObtientLogin.Click += new System.EventHandler(this.btnObtientLogin_Click);
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(187, 280);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLogin.TabIndex = 8;
            // 
            // LabelNom
            // 
            this.LabelNom.AutoSize = true;
            this.LabelNom.Location = new System.Drawing.Point(49, 44);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(35, 13);
            this.LabelNom.TabIndex = 9;
            this.LabelNom.Text = "Nom :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(46, 103);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(49, 13);
            this.labelPrenom.TabIndex = 10;
            this.labelPrenom.Text = "Prénom :";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(46, 157);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(72, 13);
            this.labelAdresse.TabIndex = 11;
            this.labelAdresse.Text = "Adresse mail :";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(49, 287);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(84, 13);
            this.labelLogin.TabIndex = 12;
            this.labelLogin.Text = "Votre Login est :";
            // 
            // labelmdp
            // 
            this.labelmdp.AutoSize = true;
            this.labelmdp.Location = new System.Drawing.Point(46, 329);
            this.labelmdp.Name = "labelmdp";
            this.labelmdp.Size = new System.Drawing.Size(104, 13);
            this.labelmdp.TabIndex = 13;
            this.labelmdp.Text = "Votre mot de passe :";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(49, 373);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(100, 13);
            this.labelResult.TabIndex = 14;
            this.labelResult.Text = "Resultat de l\'envoi :";
            // 
            // Ecran1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 487);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelmdp);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.LabelNom);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.btnObtientLogin);
            this.Controls.Add(this.btnInscription);
            this.Controls.Add(this.btnRAZ);
            this.Controls.Add(this.txtBoxPrenom);
            this.Controls.Add(this.txtBoxMail);
            this.Controls.Add(this.txtBoxMdp);
            this.Controls.Add(this.txtBoxNom);
            this.Name = "Ecran1";
            this.Text = "Application FREDI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.TextBox txtBoxMdp;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.Button btnRAZ;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Button btnObtientLogin;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelmdp;
        private System.Windows.Forms.Label labelResult;
    }
}