namespace Appli1
{
    partial class frmAppli1
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
            this.rbtSpeed100 = new System.Windows.Forms.RadioButton();
            this.rbtSpeed200 = new System.Windows.Forms.RadioButton();
            this.rbtSpeed300 = new System.Windows.Forms.RadioButton();
            this.rbtSpeed500 = new System.Windows.Forms.RadioButton();
            this.grbSpeedMelangeur = new System.Windows.Forms.GroupBox();
            this.rbtTemp50 = new System.Windows.Forms.RadioButton();
            this.rbtTemp80 = new System.Windows.Forms.RadioButton();
            this.rbtTemp100 = new System.Windows.Forms.RadioButton();
            this.grbTempMelangeur = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnRetablir = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.grbParametre = new System.Windows.Forms.GroupBox();
            this.grbSpeedMelangeur.SuspendLayout();
            this.grbTempMelangeur.SuspendLayout();
            this.grbParametre.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtSpeed100
            // 
            this.rbtSpeed100.AutoSize = true;
            this.rbtSpeed100.Checked = true;
            this.rbtSpeed100.Location = new System.Drawing.Point(18, 29);
            this.rbtSpeed100.Name = "rbtSpeed100";
            this.rbtSpeed100.Size = new System.Drawing.Size(43, 17);
            this.rbtSpeed100.TabIndex = 0;
            this.rbtSpeed100.TabStop = true;
            this.rbtSpeed100.Text = "100";
            this.rbtSpeed100.UseVisualStyleBackColor = true;
            // 
            // rbtSpeed200
            // 
            this.rbtSpeed200.AutoSize = true;
            this.rbtSpeed200.Location = new System.Drawing.Point(81, 29);
            this.rbtSpeed200.Name = "rbtSpeed200";
            this.rbtSpeed200.Size = new System.Drawing.Size(43, 17);
            this.rbtSpeed200.TabIndex = 1;
            this.rbtSpeed200.TabStop = true;
            this.rbtSpeed200.Text = "200";
            this.rbtSpeed200.UseVisualStyleBackColor = true;
            // 
            // rbtSpeed300
            // 
            this.rbtSpeed300.AutoSize = true;
            this.rbtSpeed300.Location = new System.Drawing.Point(149, 29);
            this.rbtSpeed300.Name = "rbtSpeed300";
            this.rbtSpeed300.Size = new System.Drawing.Size(43, 17);
            this.rbtSpeed300.TabIndex = 2;
            this.rbtSpeed300.TabStop = true;
            this.rbtSpeed300.Text = "300";
            this.rbtSpeed300.UseVisualStyleBackColor = true;
            // 
            // rbtSpeed500
            // 
            this.rbtSpeed500.AutoSize = true;
            this.rbtSpeed500.Location = new System.Drawing.Point(208, 29);
            this.rbtSpeed500.Name = "rbtSpeed500";
            this.rbtSpeed500.Size = new System.Drawing.Size(43, 17);
            this.rbtSpeed500.TabIndex = 3;
            this.rbtSpeed500.TabStop = true;
            this.rbtSpeed500.Text = "500";
            this.rbtSpeed500.UseVisualStyleBackColor = true;
            // 
            // grbSpeedMelangeur
            // 
            this.grbSpeedMelangeur.Controls.Add(this.rbtSpeed500);
            this.grbSpeedMelangeur.Controls.Add(this.rbtSpeed300);
            this.grbSpeedMelangeur.Controls.Add(this.rbtSpeed200);
            this.grbSpeedMelangeur.Controls.Add(this.rbtSpeed100);
            this.grbSpeedMelangeur.Location = new System.Drawing.Point(12, 12);
            this.grbSpeedMelangeur.Name = "grbSpeedMelangeur";
            this.grbSpeedMelangeur.Size = new System.Drawing.Size(289, 58);
            this.grbSpeedMelangeur.TabIndex = 4;
            this.grbSpeedMelangeur.TabStop = false;
            this.grbSpeedMelangeur.Text = "Vitesse du mélangeur en tours par minute";
            // 
            // rbtTemp50
            // 
            this.rbtTemp50.AutoSize = true;
            this.rbtTemp50.Checked = true;
            this.rbtTemp50.Location = new System.Drawing.Point(18, 36);
            this.rbtTemp50.Name = "rbtTemp50";
            this.rbtTemp50.Size = new System.Drawing.Size(37, 17);
            this.rbtTemp50.TabIndex = 5;
            this.rbtTemp50.TabStop = true;
            this.rbtTemp50.Text = "50";
            this.rbtTemp50.UseVisualStyleBackColor = true;
            // 
            // rbtTemp80
            // 
            this.rbtTemp80.AutoSize = true;
            this.rbtTemp80.Location = new System.Drawing.Point(81, 36);
            this.rbtTemp80.Name = "rbtTemp80";
            this.rbtTemp80.Size = new System.Drawing.Size(37, 17);
            this.rbtTemp80.TabIndex = 6;
            this.rbtTemp80.TabStop = true;
            this.rbtTemp80.Text = "80";
            this.rbtTemp80.UseVisualStyleBackColor = true;
            // 
            // rbtTemp100
            // 
            this.rbtTemp100.AutoSize = true;
            this.rbtTemp100.Location = new System.Drawing.Point(149, 36);
            this.rbtTemp100.Name = "rbtTemp100";
            this.rbtTemp100.Size = new System.Drawing.Size(43, 17);
            this.rbtTemp100.TabIndex = 7;
            this.rbtTemp100.TabStop = true;
            this.rbtTemp100.Text = "100";
            this.rbtTemp100.UseVisualStyleBackColor = true;
            // 
            // grbTempMelangeur
            // 
            this.grbTempMelangeur.Controls.Add(this.rbtTemp100);
            this.grbTempMelangeur.Controls.Add(this.rbtTemp80);
            this.grbTempMelangeur.Controls.Add(this.rbtTemp50);
            this.grbTempMelangeur.Location = new System.Drawing.Point(12, 76);
            this.grbTempMelangeur.Name = "grbTempMelangeur";
            this.grbTempMelangeur.Size = new System.Drawing.Size(208, 71);
            this.grbTempMelangeur.TabIndex = 8;
            this.grbTempMelangeur.TabStop = false;
            this.grbTempMelangeur.Text = "Température du mélangeur";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(226, 163);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnRetablir
            // 
            this.btnRetablir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRetablir.Location = new System.Drawing.Point(226, 192);
            this.btnRetablir.Name = "btnRetablir";
            this.btnRetablir.Size = new System.Drawing.Size(75, 23);
            this.btnRetablir.TabIndex = 10;
            this.btnRetablir.Text = "Rétablir";
            this.btnRetablir.UseVisualStyleBackColor = true;
            this.btnRetablir.Click += new System.EventHandler(this.btnRetablir_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(226, 221);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 11;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(6, 22);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(47, 13);
            this.lblSpeed.TabIndex = 12;
            this.lblSpeed.Text = "Vitesse :";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(6, 58);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(73, 13);
            this.lblTemp.TabIndex = 13;
            this.lblTemp.Text = "Température :";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(97, 19);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.ReadOnly = true;
            this.txtSpeed.Size = new System.Drawing.Size(66, 20);
            this.txtSpeed.TabIndex = 14;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(97, 55);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.ReadOnly = true;
            this.txtTemp.Size = new System.Drawing.Size(66, 20);
            this.txtTemp.TabIndex = 15;
            // 
            // grbParametre
            // 
            this.grbParametre.Controls.Add(this.txtTemp);
            this.grbParametre.Controls.Add(this.txtSpeed);
            this.grbParametre.Controls.Add(this.lblTemp);
            this.grbParametre.Controls.Add(this.lblSpeed);
            this.grbParametre.Location = new System.Drawing.Point(12, 153);
            this.grbParametre.Name = "grbParametre";
            this.grbParametre.Size = new System.Drawing.Size(208, 91);
            this.grbParametre.TabIndex = 16;
            this.grbParametre.TabStop = false;
            this.grbParametre.Text = "Paramètres retenues";
            this.grbParametre.Visible = false;
            // 
            // frmAppli1
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnRetablir;
            this.ClientSize = new System.Drawing.Size(308, 254);
            this.Controls.Add(this.grbParametre);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRetablir);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grbTempMelangeur);
            this.Controls.Add(this.grbSpeedMelangeur);
            this.Name = "frmAppli1";
            this.Text = "Paramètres de l\'analyseur";
            this.grbSpeedMelangeur.ResumeLayout(false);
            this.grbSpeedMelangeur.PerformLayout();
            this.grbTempMelangeur.ResumeLayout(false);
            this.grbTempMelangeur.PerformLayout();
            this.grbParametre.ResumeLayout(false);
            this.grbParametre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtSpeed100;
        private System.Windows.Forms.RadioButton rbtSpeed200;
        private System.Windows.Forms.RadioButton rbtSpeed300;
        private System.Windows.Forms.RadioButton rbtSpeed500;
        private System.Windows.Forms.GroupBox grbSpeedMelangeur;
        private System.Windows.Forms.RadioButton rbtTemp50;
        private System.Windows.Forms.RadioButton rbtTemp80;
        private System.Windows.Forms.RadioButton rbtTemp100;
        private System.Windows.Forms.GroupBox grbTempMelangeur;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnRetablir;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.GroupBox grbParametre;
    }
}

