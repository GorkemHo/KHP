﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.ViewModels.GidaVms
{
    public class GidaListVm
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Kalori { get; set; }
        public decimal Porsiyon { get; set; }
        public string GidaTuru { get; set; }
        public byte[]? Resim { get; set; }

    }
}
