﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_WinForm.Entiteti
{
    public class Banka
    {
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Email { get; set; }
        public virtual string Web_adresa { get; set; }
        public virtual string Adresa_centrale { get; set; }


    }
}
