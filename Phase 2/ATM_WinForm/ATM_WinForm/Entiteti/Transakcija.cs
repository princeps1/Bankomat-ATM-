﻿using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace ATM_WinForm.Entiteti
{
    public class Transakcija
    {
        [DisplayName("ID")]
        public virtual int Id { get; protected set; }

        [DisplayName("PODIGNUTI IZNOS")]
        public virtual string Podignuti_iznos { get; set; }

        [DisplayName("DATUM PODIZANJA NOVCA")]
        public virtual DateTime Datum_Podizanja_Novca { get; set; }

        [DisplayName("VREME PODIZANJA NOVCA")]
        public virtual DateTime Vreme_Podizanja_Novca { get; set; }
    }
}
