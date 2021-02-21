using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FootballTeam.Entities
{
    public class Footballers
    {
        // Id property'si primary key olarak ayarlandı ve birer birer artarak devam edecek.
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(30)] // En fazla 30 karakterden oluşabilir.
        public string Firstname { get; set; }

        [StringLength(30)] // En fazla 30 karakterden oluşabilir.
        public string Lastname { get; set; }

        [StringLength(20)] // En fazla 20 karakterden oluşabilir.
        public string Position { get; set; }

    }
}
