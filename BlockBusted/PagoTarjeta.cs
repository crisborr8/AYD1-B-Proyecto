﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockBusted
{
    public partial class PagoTarjeta : Form
    {
        public PagoTarjeta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals("")|| textBox2.Text.Equals("")|| textBox4.Text.Equals(""))
            {
                MessageBox.Show("FALTAN DATOS PARA FINALIZAR LA TRANSACCION");
            }
        }
    }
}
