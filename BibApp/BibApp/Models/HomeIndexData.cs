﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibApp.Models
{
    public class HomeIndexData
    {
        public List<Benutzer> Benutzers { get; set; }
        public Benutzer Benutzer { get; set; }

        public List<Buch> Buecher { get; set; }
        public Buch Buch { get; set; }
    }
}
