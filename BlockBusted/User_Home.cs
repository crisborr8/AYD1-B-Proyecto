﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlockBusted
{
    public partial class User_Home : Form
    {
        String usuario, email;

        private void btn_Alquilar_Click(object sender, EventArgs e)
        {
            Alquiler conn = new Alquiler(this.email);
            conn.Show();
        }

        public User_Home(String usuario, String email)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.email = email;
            lbl_Usuario.Text = usuario;
            lbl_Emal.Text = email;
        }
    }
}
