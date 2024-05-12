﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM_WinForm.Forme.Filijala;
using NHibernate;

namespace ATM_WinForm
{
    public partial class Form_Filijala_Main : Form
    {
        private int id = -1;
        private readonly BindingSource bindingSource = new BindingSource();
        List<ATM_WinForm.Entiteti.Filijala> filijale = null;
        public Form_Filijala_Main(int id = -1)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Form_Filijala_Main_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            if(this.id == -1)
            {
                filijale = s.Query<ATM_WinForm.Entiteti.Filijala>().ToList();
            }
            else
            {
                var banka = s.Get<ATM_WinForm.Entiteti.Banka>(this.id);
                filijale = banka.Filijala.ToList();
            }

            bindingSource.DataSource = filijale;
            FilijalaGrid.DataSource = bindingSource;

            FilijalaGrid.AllowUserToAddRows = false;

            s.Close();
        }

        private void DodajFilijaluBtn_Click(object sender, EventArgs e)
        {
            var dodajIzmeniFilijaluForm = new Form_Filijala_AddUpdate("add", null);
            dodajIzmeniFilijaluForm.ShowDialog();
        }
    }
}
