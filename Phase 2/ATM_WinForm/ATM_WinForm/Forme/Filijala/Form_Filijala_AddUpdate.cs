﻿using ATM_WinForm.Klase;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATM_WinForm.Forme.Filijala
{
    public partial class Form_Filijala_AddUpdate : Form
    {
        private readonly string type = "";
        private readonly int bankaId = -1;
        private readonly ATM_WinForm.Entiteti.Filijala filijala = null;
        static public event EventHandler<FilijalaEventArgs> FilijalaEventi;
        public Form_Filijala_AddUpdate(string type, ATM_WinForm.Entiteti.Filijala filijala, int bankaId)
        {
            InitializeComponent();

            this.BankaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            this.type = type;
            this.filijala = filijala;
            this.bankaId = bankaId;

            switch (this.type)
            {
                case "add":
                    {
                        AkcijaFilijaleBtn.Text = "Dodaj Filijalu";

                        this.Text = "ATM - Dodaj Filijalu";

                        break;
                    }
                case "update":
                    {
                        AkcijaFilijaleBtn.Text = "Izmeni Filijalu";

                        AdresaTxtBx.Text = filijala.Adresa;
                        BrTelefonaTxtBx.Text = filijala.Br_telefona;
                        RadnoVremeTxtBx.Text = filijala.Radno_vreme;

                        this.Text = "ATM - Izmeni Filijalu";

                        break;
                    }
                default: break;
            }

        }

        private void Form_Filijala_AddUpdate_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            BankaComboBox.DisplayMember = "Text";
            BankaComboBox.ValueMember = "ID";

            List<ComboItem> lista = new List<ComboItem>();

            if (this.bankaId == -1)
            {
                var banke = s.Query<ATM_WinForm.Entiteti.Banka>().ToList();

                foreach (var banka in banke)
                {
                    lista.Add(new ComboItem { ID = banka.Id, Text = banka.Ime });
                }
            } 
            else
            {
                var banka = s.Get<ATM_WinForm.Entiteti.Banka>(this.bankaId);

                lista.Add(new ComboItem { ID = banka.Id, Text = banka.Ime });
            }

            BankaComboBox.DataSource = lista;

            s.Close();
        }

        private void AkcijaFilijaleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (AdresaTxtBx.Text == "" ||
                   BrTelefonaTxtBx.Text == "" ||
                   RadnoVremeTxtBx.Text == ""
                   )
                {
                    MessageBox.Show("Polja ne smeju biti prazna!");
                    return;
                }

                switch (this.type)
                {
                    case "add":
                        {
                            var pripadaBanci = s.Load<ATM_WinForm.Entiteti.Banka>((int)BankaComboBox.SelectedValue);

                            MessageBox.Show(pripadaBanci.Ime.ToString());

                            Entiteti.Filijala filijala = new Entiteti.Filijala
                            {
                                Adresa = AdresaTxtBx.Text,
                                Br_telefona = BrTelefonaTxtBx.Text,
                                Radno_vreme = RadnoVremeTxtBx.Text,
                                PripadaBanci = pripadaBanci
                            };

                            s.Save(filijala);

                            MessageBox.Show("Uspesno ste dodali banku!");

                            FilijalaEventi?.Invoke(this, new FilijalaEventArgs("add", filijala));

                            AdresaTxtBx.Text = "";
                            BrTelefonaTxtBx.Text = "";
                            RadnoVremeTxtBx.Text = "";

                            break;
                        }
                    case "update":
                        {
                            /*
                             
                            this.banka.Ime = ImeTxtBx.Text;
                            this.banka.Email = EmailTxtBx.Text;
                            this.banka.Web_adresa = WebAdresaTxtBx.Text;
                            this.banka.Adresa_centrale = AdresaCentraleTxtBx.Text;
                            s.Update(this.banka);

                            BankaEventi?.Invoke(this, new BankaEventArgs("update", banka));

                            MessageBox.Show("Uspesno ste izmenili banku!");
                            
                            */
                            
                            break;
                        }
                    default: break;
                }

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
