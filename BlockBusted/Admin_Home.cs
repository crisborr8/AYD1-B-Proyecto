using BlockBusted.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlockBusted
{
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void gestionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPeliculas pl = new GestionPeliculas();
            pl.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lenguajes ln = new Lenguajes();
            ln.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            us.Show();
        }
    }
}
