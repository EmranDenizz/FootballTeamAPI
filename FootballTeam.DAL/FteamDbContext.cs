using FootballTeam.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeam.DAL
{
    public class FteamDbContext : DbContext
    {
        //Yapılandırma için bir seçenek belirlememizi sağlayan metot.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // c# unrecognized(tanınmayan) escape sequence hatası çözümü "\" gibi karakterler için hata almamak için "@" işareti eklenmelidir.
            optionsBuilder.UseSqlServer(@"Server=EMRAN\ED; Database=FootballTeamDb; integrated security=true;"); //ConnectionString adresi yazılır.Windows authentication ile bağlanırsak bu şekilde yazılır.
        }
        public DbSet<Footballers> players { get; set; }
    }
}
