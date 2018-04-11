using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appli1
{
    public partial class frmAppli1 : Form
    {
        public frmAppli1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Rend les GroupBox de vitesse et température grisé et la GroupBox paramètre visible
            this.grbParametre.Visible = true;
            this.grbSpeedMelangeur.Enabled = false;
            this.grbTempMelangeur.Enabled = false;


            ////Si un des radio boutons de vitesse est CHECKED alors le txtSPEED affiche sa valeur (FACON PR0)
            var VitesseMelangeur = this.grbSpeedMelangeur.Controls.OfType<RadioButton>().First(a => a.Checked);

            this.txtSpeed.Text = VitesseMelangeur.Text;


            ////Si un des radio boutons de vitesse est CHECKED alors le txtSPEED affiche sa valeur (FACON N00B)
            //if (this.rbtSpeed100.Checked == true)
            //{
            //    this.txtSpeed.Text = "100";
            //}
            //else if (this.rbtSpeed200.Checked == true)
            //{
            //    this.txtSpeed.Text = "200";
            //}
            //else if(this.rbtSpeed300.Checked == true)
            //{
            //    this.txtSpeed.Text = "300";
            //}
            //else if(this.rbtSpeed500.Checked == true)
            //{
            //    this.txtSpeed.Text = "500";
            //}

            //Si un des radio bouton de Température est cheked alors le txtTemp affiche sa valeur (FACON PR0)
            var TemperatureMelangeur = this.grbTempMelangeur.Controls.OfType<RadioButton>().First(a => a.Checked);

            this.txtTemp.Text = TemperatureMelangeur.Text;


            ////Si un des radio bouton de Température est cheked alors le txtTemp affiche sa valeur (FACON N00B)
            //if (this.rbtTemp50.Checked == true)
            //{
            //    this.txtTemp.Text = "50";
            //}
            //else if (this.rbtTemp80.Checked == true)
            //{
            //    this.txtTemp.Text = "80";
            //}
            //else if (this.rbtTemp100.Checked == true)
            //{
            //    this.txtTemp.Text = "100";
            //}



        }

        private void btnRetablir_Click(object sender, EventArgs e)
        {
            //Rend les GroupBox de vitesse et température utilisable et la GroupBox paramètre invisible
            this.grbParametre.Visible = false;
            this.grbSpeedMelangeur.Enabled = true;
            this.grbTempMelangeur.Enabled = true;

            //Remet la valeur par défaut du radio bouton speed et du radio bouton Temp
            this.rbtSpeed100.Checked = true;
            this.rbtTemp50.Checked = true;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            // Quitte l'application.
            Application.Exit();
        }
    }
}
