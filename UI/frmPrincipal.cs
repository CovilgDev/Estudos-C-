using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace UI
{
    public partial class frmPrincipal : Form
    {
        private String usuario;
        public frmPrincipal(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void usuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Bem-Vindo " + usuario + "!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void consultaDetranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("chrome.exe","www.detran.rj.gov.br");
            }
            catch(Exception ex)
            {
                Process.Start("msedge.exe", "www.detran.rj.gov.br");
            }
        }

        private void exibirBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exibirBarraToolStripMenuItem.Checked)
            {
                toolStrip1.Show();
            }
            else
            {
                toolStrip1.Hide();
            }
        }

        private void corDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void papelDeParedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                this.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
