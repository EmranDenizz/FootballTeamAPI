using FootballTeam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeam.DAL.Abstract
{
    public interface IFootballTeamRepository
    {
        List<Footballers> GetAllPlayers(); //Tüm futbolcu kadrosunu getirecek.
        Footballers GetPlayerById(int id); //Kullanıcıdan alacağı değere göre tablodan eşleşen veriyi çekecek
        Footballers CreatePlayers(Footballers footballers); //Yeni veri eklenir
        Footballers UpdatePlayers(Footballers footballers); //Güncelleme işlemi yapacak.
        void DeletePlayers(int id); //Veri silme işlemi yapacak
    }
}
