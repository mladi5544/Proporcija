using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProporcijaProjekat
{
    public partial class Form1 : Form
    {
        private ProporcijaViewModel proporcijaVM = new ProporcijaViewModel();
        public Form1()
        {
            InitializeComponent();
        }

        string[] pojmovi = new string[100];
        int n = 0;

        int[,] proporcija = new int[100, 100];
        /*
         * 0- ne moze
         * 1 - direktna
         * 2 * obrnuta
         * */



        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader most = new StreamReader("izbor.txt");
            int i = 0;
            while (!most.EndOfStream)
            {
                pojmovi[i] = most.ReadLine();
                i++;
            }
            n = i;
            most.Close();

            proporcija[0, 0] = 0;

            //nebitni>
            for (int j = 0; j < n; j++)
            {
                proporcija[0, j] = 0;
                proporcija[j, 0] = 0;
                proporcija[j, j] = 0;
            }

            //Radnici -->1
            proporcija[1, 1] = 0;
            proporcija[1, 2] = 2;
            proporcija[1, 3] = 2;
            proporcija[1, 4] = 0;
            proporcija[1, 5] = 0;
            proporcija[1, 6] = 0;
            proporcija[1, 7] = 0;
            proporcija[1, 8] = 0;
            proporcija[1, 9] = 0;
            proporcija[1, 10] = 0;

            //Sati --> 2
            proporcija[2, 1] = 2;
            proporcija[2, 3] = 2;
            proporcija[2, 4] = 0;
            proporcija[2, 5] = 0;
            proporcija[2, 6] = 0;
            proporcija[2, 7] = 0;
            proporcija[2, 8] = 0;
            proporcija[2, 9] = 0;
            proporcija[2, 10] = 2;
            // Dani --> 3
            proporcija[3, 1] = 2;
            proporcija[3, 2] = 0;
            proporcija[3, 3] = 0;
            proporcija[3, 4] = 0;
            proporcija[3, 5] = 0;
            proporcija[3, 6] = 0;
            proporcija[3, 7] = 0;
            proporcija[3, 8] = 0;
            proporcija[3, 9] = 0;
            proporcija[3, 10] = 2;
            //kg robe -->4
            proporcija[4, 1] = 0;
            proporcija[4, 2] = 2;
            proporcija[4, 3] = 2;
            proporcija[4, 4] = 0;
            proporcija[4, 5] = 1;
            proporcija[4, 6] = 0;
            proporcija[4, 7] = 0;
            proporcija[4, 8] = 0;
            proporcija[4, 9] = 0;
            proporcija[4, 10] = 0;
            //dinara -->5
            proporcija[5, 1] = 0;
            proporcija[5, 2] = 2;
            proporcija[5, 3] = 2;
            proporcija[5, 4] = 1;
            proporcija[5, 5] = 0;
            proporcija[5, 6] = 0;
            proporcija[5, 7] = 0;
            proporcija[5, 8] = 0;
            proporcija[5, 9] = 0;
            proporcija[5, 10] = 0;
            //štof --> 6
            proporcija[6, 1] = 0;
            proporcija[6, 2] = 0;
            proporcija[6, 3] = 0;
            proporcija[6, 4] = 0;
            proporcija[6, 5] = 0;
            proporcija[6, 6] = 0;
            proporcija[6, 7] = 1;
            proporcija[6, 8] = 0;
            proporcija[6, 9] = 0;
            proporcija[6, 10] = 0;
            //predivo --> 7
            proporcija[7, 1] = 0;
            proporcija[7, 2] = 0;
            proporcija[7, 3] = 0;
            proporcija[7, 4] = 0;
            proporcija[7, 5] = 0;
            proporcija[7, 6] = 1;
            proporcija[7, 7] = 0;
            proporcija[7, 8] = 0;
            proporcija[7, 9] = 0;
            proporcija[7, 10] = 0;
            //mačka --> 8
            proporcija[8, 1] = 0;
            proporcija[8, 2] = 0;
            proporcija[8, 3] = 0;
            proporcija[8, 4] = 0;
            proporcija[8, 5] = 0;
            proporcija[8, 6] = 0;
            proporcija[8, 7] = 0;
            proporcija[8, 8] = 0;
            proporcija[8, 9] = 1;
            proporcija[8, 10] = 0;
            //miš --> 9
            proporcija[9, 1] = 0;
            proporcija[9, 2] = 0;
            proporcija[9, 3] = 0;
            proporcija[9, 4] = 0;
            proporcija[9, 5] = 0;
            proporcija[9, 6] = 0;
            proporcija[9, 7] = 0;
            proporcija[9, 8] = 0;
            proporcija[9, 9] = 1;
            proporcija[9, 10] = 0;
            //cevi --> 10
            proporcija[10, 1] = 0;
            proporcija[10, 2] = 2;
            proporcija[10, 3] = 2;
            proporcija[10, 4] = 0;
            proporcija[10, 5] = 0;
            proporcija[10, 6] = 0;
            proporcija[10, 7] = 0;
            proporcija[10, 8] = 0;
            proporcija[10, 9] = 0;
            proporcija[10, 10] = 0;

            for (int j = 0; j < n; j++)
            {
                cmbProporcija1.Items.Add(pojmovi[j]);
                cmbProporcija2.Items.Add(pojmovi[j]);

            }
            cmbProporcija1.SelectedIndex = 0;
            cmbProporcija2.SelectedIndex = 0;

        }

        private void cmbProporcija2_ValueChanged(object sender, EventArgs e)
        {
            proporcijaVM.Opcija2 = cmbProporcija2.SelectedItem.ToString();
            Obradi(proporcijaVM);
        }

        private void cmbProporcija1_ValueChanged(object sender, EventArgs e)
        {
            proporcijaVM.Opcija1 = cmbProporcija1.SelectedItem.ToString();
            Obradi(proporcijaVM);
        }

        private void Obradi(ProporcijaViewModel proporcija)
        {

            if (!string.IsNullOrEmpty(proporcija.Opcija1))
            {
                if (proporcija.Opcija1 == proporcija.Opcija2 & cmbProporcija2.SelectedIndex.ToString() != "0")
                {
                    MessageBox.Show("Vrednosti ne smeju biti iste");
                    cmbProporcija1.SelectedIndex = 0;
                    cmbProporcija2.SelectedIndex = 0;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //proveri da 3 vrednost ipostoje a samo jedna textbox.Text=""
            //ako jeste moze da se radi inace message box

            int red = Convert.ToInt32(cmbProporcija1.SelectedIndex);
            int kolona = Convert.ToInt32(cmbProporcija2.SelectedIndex);
            int vrstaProporcije = proporcija[red, kolona];
            if (vrstaProporcije == 1)
            {
                //direktna..
                string vr1 = txtVrednost1.Text.ToString();
                string vr2 = txtVrednost2.Text.ToString();
                string vr3 = txtVrednost3.Text.ToString();
                string vr4 = txtVrednost4.Text.ToString();

                if (vr1 == "") vr1 = "x";
                if (vr2 == "") vr2 = "x";
                if (vr3 == "") vr3 = "x";
                if (vr4 == "") vr4 = "x";

                label1.Text = vr1 + " : " + vr3 + " = " + vr2 + " : " + vr4;
                //dugme ya jasno1 da je visible
                picDown1.Visible = true;
                picDown2.Visible = true;


            }
            else if (vrstaProporcije == 2)
            {
                //obrnuta..

                string vr1 = txtVrednost1.Text.ToString();
                string vr2 = txtVrednost2.Text.ToString();
                string vr3 = txtVrednost3.Text.ToString();
                string vr4 = txtVrednost4.Text.ToString();

                if (vr1 == "") vr1 = "x";
                if (vr2 == "") vr2 = "x";
                if (vr3 == "") vr3 = "x";
                if (vr4 == "") vr4 = "x";

                label1.Text = vr1 + " : " + vr3 + " = " + vr4 + " : " + vr2;
                picUp2.Visible = true;
                picDown1.Visible = true;

            }
            else if (vrstaProporcije == 0)
            {
                //message box da morau obapojma biti iyabrani i razliciti
                MessageBox.Show("Oba pojma moraju biti izabrana i različita");
            }
            btnResenje1.Show();
        }

        private void btnResenje1_Click(object sender, EventArgs e)
        {
            int red = Convert.ToInt32(cmbProporcija1.SelectedIndex);
            int kolona = Convert.ToInt32(cmbProporcija2.SelectedIndex);
            int vrstaProporcije = proporcija[red, kolona];
            if (vrstaProporcije == 1)
            {
                //direktna
                string vr1 = txtVrednost1.Text.ToString();
                string vr2 = txtVrednost2.Text.ToString();
                string vr3 = txtVrednost3.Text.ToString();
                string vr4 = txtVrednost4.Text.ToString();
                if (vr1 == "") vr1 = "x";
                if (vr2 == "") vr2 = "x";
                if (vr3 == "") vr3 = "x";
                if (vr4 == "") vr4 = "x";
                label2.Text = vr1 + " * " + vr4 + " = " + vr3 + " * " + vr2;

            }
            else if (vrstaProporcije ==2)
            {
                //obrnuta
                string vr1 = txtVrednost1.Text.ToString();
                string vr2 = txtVrednost2.Text.ToString();
                string vr3 = txtVrednost3.Text.ToString();
                string vr4 = txtVrednost4.Text.ToString();
                if (vr1 == "") vr1 = "x";
                if (vr2 == "") vr2 = "x";
                if (vr3 == "") vr3 = "x";
                if (vr4 == "") vr4 = "x";
                label2.Text = vr1 + " * " + vr2 + " = " + vr4 + " * " + vr3;
 
            }
            btnResenje2.Show();
        }

        private void btnResenje2_Click(object sender, EventArgs e)
        {
            int red = Convert.ToInt32(cmbProporcija1.SelectedIndex);
            int kolona = Convert.ToInt32(cmbProporcija2.SelectedIndex);
            int vrstaProporcije = proporcija[red, kolona];
            if (vrstaProporcije == 1)
            {
                //direktna
                if (string.IsNullOrEmpty(txtVrednost1.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);
                    label3.Text = $"x * {vr4D} = {vr3D * vr2D}";
                }
                else if (string.IsNullOrEmpty(txtVrednost2.Text))
                {
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);
                    label3.Text = $"{vr1D * vr4D}  = {vr3D} * x";
                }
                else if (string.IsNullOrEmpty(txtVrednost3.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);
                    label3.Text = $"{vr1D * vr4D} = x * {vr2D}";
                }
                else if (string.IsNullOrEmpty(txtVrednost4.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    label3.Text = $" {vr1D} * x = {vr3D * vr2D} ";
                }
            }
            else if (vrstaProporcije == 2)
            {
                //obrnuta

                if (string.IsNullOrEmpty(txtVrednost1.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);
                    label3.Text = $"x * {vr2D} = {vr3D * vr4D}";
                }
                else if (string.IsNullOrEmpty(txtVrednost2.Text))
                {
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);
                    label3.Text = $"{vr1D} * x  = {vr3D * vr4D}";
                }
                else if (string.IsNullOrEmpty(txtVrednost3.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);
                    label3.Text = $"{vr1D} * {vr2D} = x * {vr4D}";
                }
                else if (string.IsNullOrEmpty(txtVrednost4.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    label3.Text = $" {vr1D * vr2D} = {vr3D} * x ";
                }
            }
            btnResenje3.Show();
        }

        private void btnResenje3_Click(object sender, EventArgs e)
        {
            int red = Convert.ToInt32(cmbProporcija1.SelectedIndex);
            int kolona = Convert.ToInt32(cmbProporcija2.SelectedIndex);
            int vrstaProporcije = proporcija[red, kolona];
            if (vrstaProporcije == 1)
            {
                //direktna
                if (string.IsNullOrEmpty(txtVrednost1.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);
                    label4.Text = $"x  = {vr3D * vr2D} / {vr4D}";
                }
                else if (string.IsNullOrEmpty(txtVrednost2.Text))
                {
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);
                    label4.Text = $" x  = {vr1D * vr4D} / {vr3D}";
                }
                else if (string.IsNullOrEmpty(txtVrednost3.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);

                    label4.Text = $"{vr1D * vr4D} / {vr2D} = x ";
                }
                else if (string.IsNullOrEmpty(txtVrednost4.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    label4.Text = $" {vr3D * vr2D} / {vr1D} =  x ";
                }
            }
            else if (vrstaProporcije == 2)
            {
                //obrnuta

                if (string.IsNullOrEmpty(txtVrednost1.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);
                    label4.Text = $"x  = {vr3D * vr4D} / {vr2D}";
                }
                else if (string.IsNullOrEmpty(txtVrednost2.Text))
                {
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);
                    label4.Text = $" x  = {vr3D * vr4D} / {vr1D}";
                }
                else if (string.IsNullOrEmpty(txtVrednost3.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);
                    
                    label4.Text = $"{vr1D * vr2D} / {vr4D} = x ";
                }
                else if (string.IsNullOrEmpty(txtVrednost4.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    label4.Text = $" {vr1D * vr2D} / {vr3D} =  x ";
                }
            }
            btnResenje4.Show();
        }

        private void btnResenje4_Click(object sender, EventArgs e)
        {
            int red = Convert.ToInt32(cmbProporcija1.SelectedIndex);
            int kolona = Convert.ToInt32(cmbProporcija2.SelectedIndex);
            int vrstaProporcije = proporcija[red, kolona];
            if (vrstaProporcije == 1)
            {
                //direktna
                if (string.IsNullOrEmpty(txtVrednost1.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);
                    label5.Text = $"x  = {vr3D * vr2D / vr4D}";
                }
                else if (string.IsNullOrEmpty(txtVrednost2.Text))
                {
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);
                    label5.Text = $" x  = {vr1D * vr4D / vr3D}";
                }
                else if (string.IsNullOrEmpty(txtVrednost3.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);

                    label5.Text = $"{vr1D * vr4D / vr2D} = x ";
                }
                else if (string.IsNullOrEmpty(txtVrednost4.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    label5.Text = $" {vr3D * vr2D / vr1D} =  x ";
                }
            }
            else if (vrstaProporcije == 2)
            {
                //obrnuta

                if (string.IsNullOrEmpty(txtVrednost1.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);
                    label5.Text = $"x  = {vr3D * vr4D / vr2D}";
                }
                else if (string.IsNullOrEmpty(txtVrednost2.Text))
                {
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);
                    label5.Text = $" x  = {vr3D * vr4D / vr1D}";
                }
                else if (string.IsNullOrEmpty(txtVrednost3.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    double vr4D = Convert.ToDouble(txtVrednost4.Text);

                    label5.Text = $"{vr1D * vr2D / vr4D} = x ";
                }
                else if (string.IsNullOrEmpty(txtVrednost4.Text))
                {
                    double vr2D = Convert.ToDouble(txtVrednost2.Text);
                    double vr3D = Convert.ToDouble(txtVrednost3.Text);
                    double vr1D = Convert.ToDouble(txtVrednost1.Text);
                    label5.Text = $" {vr1D * vr2D / vr3D} =  x ";
                }
                btnRestartuj.Visible = true;
            }
        }

       
        private void btnRestartuj_Click(object sender, EventArgs e)
        {
            picDown1.Visible = false;
            picDown2.Visible = false;
            picUp1.Visible = false;
            picUp2.Visible = false;
            cmbProporcija1.SelectedIndex = 0;
            cmbProporcija2.SelectedIndex = 0;
            txtVrednost1.Text = null;
            txtVrednost2.Text = null;
            txtVrednost3.Text = null;
            txtVrednost4.Text = null;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            btnResenje1.Visible = false;
            btnResenje2.Visible = false;
            btnResenje3.Visible = false;
            btnResenje4.Visible = false;
            btnRestartuj.Visible = false;
        }
    }
}
