﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bella_Bijoux
{
    public partial class Relatorios : Form
    {
        public Relatorios(MySql.Data.MySqlClient.MySqlConnection connection)
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Relatorios_Load(object sender, EventArgs e)
        {

        }
    }
}
