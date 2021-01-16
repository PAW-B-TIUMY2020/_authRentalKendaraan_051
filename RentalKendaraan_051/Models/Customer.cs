﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_051.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdCustomer { get; set; }
        [Required(ErrorMessage = "Nama Customer wajib diisi")]
        public string NamaCustomer { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "nik hanya boleh diisi dengan angka")]
        public string Nik { get; set; }
        [Required(ErrorMessage = "Alamat wajib diisi")]
        public string Alamat { get; set; }
        [MinLength(11, ErrorMessage = "No Hp minimal 10 angka")]
        [MaxLength(13, ErrorMessage = "No Hp minimal 13 angka")]
        public string NoHp { get; set; }
        public int? IdGender { get; set; }

        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
