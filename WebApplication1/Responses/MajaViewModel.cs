﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Responses
{
    public class MajaViewModel
    {
        public Guid Id { get; set; }
        public int? Numurs { get; set; }
        public string Iela { get; set; }
        public string Pilseta { get; set; }
        public string Valsts { get; set; }
        public string PastaIndekss { get; set; }
    }
}
