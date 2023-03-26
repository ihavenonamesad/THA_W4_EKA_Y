using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Presett
    {
        public Team BD()
        {
        Team team = new Team();
        team.teamName = "Borussia Dortmund";
        team.teamCity = "Dortmund";
        team.teamCountry = "German";
        team.Playerslist = new List<Player>();
        string[] pla = { "Gregor Kobel", "Mateu Morey", "Nico Schlotterbeck", "Salih Özcan", "Giovanni Reyna",
        "Mahmoud Dahoud", "Sébastien Haller","Marco reus","Raphaël Guerreiro", "Nico Schulz", "Mats Hummels", "Marius Wolf",
        "Youssoufa Moukoko", "Julian Brandt", "Anthony Modeste", "Donyell Malen","Jude Bellingham","Emre Can", "Thomas Meunier",
        "Niklas Süle","Julian Ryerson","Karim Adeyemi","Felix Passlack","Abdoulaye Kamara","Alexander Meyer", 
        "Marcel Lotka", "Tom Rothe", "Luca Unbehaun","Göktan Gürpüz", "Jamie Bynoe-Gittens","Soumaïla Coulibaly","Antonios Papadopoulos" };
        string[] num = { "01","02","04","06","07","08","09","11","13","14","15","17","18","19","20","21","22","23","24","25","26","27","30","32","33",
        "35","36","38","42","43","44","47"};
        string[] pos = { "GK", "DF","DF","MF","MF","MF","FW","DF","DF","DF","MF","FW","MF","FW","MF","FW","FW","MF","MF","DF","DF","DF","FW",
            "MF","MF","GK","GK","DF","GK","MF","FW","DF","DF"};
        for (int i = 0; i < pla.Length; i++)
        {
            Player player = new Player();
            player.playerName = pla[i];
            player.playerNum = num[i];
            player.playerPos = pos[i];
            team.Playerslist.Add(player);
        }
        return team;
        }
    public Team AF()
    {
        Team team = new Team();
        team.teamName = "Assyriska Fotbollsföreningen";
        team.teamCity = "Södertälje";
        team.teamCountry = "Sweden";
        team.Playerslist = new List<Player>();
        
        string[] pla = { "Jasmine Ljuca", "Essel Sampson", "Eufrat Barmousa", "Kevin Rohlin","David Durmaz", "Gabriel Aphrem", "Christian Aphrem",
            "Oskar Wener","Antonio Yakoub", "Gino Berg","Kevin Sharro","Uchenna Ike","Moussa Traoré","Adi Tahirovic","Youri de Winter","Linus Hillemar",
            "Younas Messaoudi","Amani Biregeyi","Afram Hanna","Malte Häggqvist","Nemrut Awrohum","Marcus Linday","Quintón Christina",
            "Nahir Saliba","Kyle Konwea"};
        string[] num = { "01", "02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","19","20","21","22","24","25","85","88"};
        string[] pos = { "GK", "DF", "DF", "DF", "DF", "MF", "MF", "DF", "FW", "MF", "MF", "FW", "MF", "DF", "FW", "FW", "MF", "MF","DF","GK","DF","MF","MF",
              "GK","DF"};
        for (int i = 0; i < pla.Length; i++)
        {
            Player player = new Player();
            player.playerName = pla[i];
            player.playerNum = num[i];
            player.playerPos = pos[i];
            team.Playerslist.Add(player);
        }
        return team;
    }
    public Team EF()
    {
        Team team = new Team();
        team.teamName = "Eintracht Frankfurt";
        team.teamCity = "Frankfurt";
        team.teamCountry = "German";
        team.Playerslist = new List<Player>();
        string[] pla = { "Kevin Trapp","Evan N'Dicka" ,"Hrvoje Smollchischt", "Kristijan Jakić", "Djibril Sow", "Randal Kolo Muani", "Faride Alidou", "Daichi Kamada",
        "Sebastian Rode","Almamy Touré","Rafael Santos Borré","Makoto Hasebe","Lucas Alario","Timothy Chandler","Aurélio Buta","Christopher Lenz","Éric Junior Dina Ebimbe",
        "Marcel Wenig","Jesper Lindstrøm","Jens Grahl","Philipp Max","Tuta","Ansgar Kanuff","Diant Ramaj","Simon Simoni","Mehdi Loude","Nacho Ferri","Jan Schröder"};
        string[] num = { "01", "02","05","06","08","09","11","15","17","18","19","20","21","22","24","25","26","27","28","29","31","32","35","36","40","41","42","48","49" };
        string[] pos = { "GK", "DF","DF","MF","MF","FW","FW","MF","MF","DF","FW","MF","DF","FW","MF","FW","DF","DF","DF","MF","MF","MF","MF","GK","DF","DF","MF","GK","GK","MF","FW","" };
        for (int i = 0; i < pla.Length; i++)
        {
            Player player = new Player();
            player.playerName = pla[i];
            player.playerNum = num[i];
            player.playerPos = pos[i];
            team.Playerslist.Add(player);
        }
        return team;
    }
}

