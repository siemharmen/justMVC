using ReversiMVC.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReversiMVC.Models
{
    public class Spel
    {
        //[Auto]
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Omschrijving { get; set; }
       //public Kleur[,] Bord { get; set; }
        public Kleur AandeBeurt { get; set; }
        public String Speler1Token { get; set; }
        public String Speler2Token { get; set; }
        [NotMapped]
        public Kleur[,] Bord { get; set; }
        //[NotMapped]
        public int Ingame { get; set; }
        //public Speler Speler1 { get; set; }
        //public Speler Speler2 { get; s    et; }

        //public int BoardId { get; set; }
        //public Board Board { get; set; }

        public void BoardCreate(Board board)
        {
                Bord = new Kleur[,] {
                    { board.Row00, board.Row01,board.Row02,board.Row03,board.Row04,board.Row05,board.Row06,board.Row07},
                    { board.Row10, board.Row11,board.Row12,board.Row13,board.Row14,board.Row15,board.Row16,board.Row17},
                    { board.Row20, board.Row21,board.Row22,board.Row23,board.Row24,board.Row25,board.Row26,board.Row27},
                    { board.Row30, board.Row31,board.Row32,board.Row33,board.Row34,board.Row35,board.Row36,board.Row37},
                    { board.Row40, board.Row41,board.Row42,board.Row43,board.Row44,board.Row45,board.Row46,board.Row47},
                    { board.Row50, board.Row51,board.Row52,board.Row53,board.Row54,board.Row55,board.Row56,board.Row57},
                    { board.Row60, board.Row61,board.Row62,board.Row63,board.Row64,board.Row65,board.Row66,board.Row67},
                    { board.Row70, board.Row71,board.Row72,board.Row73,board.Row74,board.Row75,board.Row76,board.Row77},
                };
        }
        public void JoinGame()
        {
            Ingame++;
        }

        public void test()
        {
        }


        public bool Afgelopen()
        {
            Console.WriteLine("test");
            return true;
        }
        public string Resultaat(Kleur[,] Board,string speler)
        {
            Kleur kleur;
            if (speler == Speler1Token)
            {
                kleur = Kleur.Wit;
            }
            else
            {
                kleur = Kleur.Zwart;
            }
            int MijnKleur = 0;
            int AndereKleur = 0;
            foreach (Kleur k in Board)
            {
                if (k == kleur)
                {
                    MijnKleur++;
                }else
                if (k == Kleur.Geen)
                {
                }
                else
                {
                    AndereKleur++;
                }
            }
            if (MijnKleur > AndereKleur)
            {
                return speler + " heeft gewonnen";
            }
            else if (MijnKleur < AndereKleur)
            {
                return speler + " heeft verloren";
            }
            else
            {
                return speler + " heeft gelijk gespeelt";
            }
        }

        public Kleur OverwegendeKleur(Kleur[,] Board)
        {
            int Wit = 0;
            int Zwart = 0;
            //int Wit = board.GetType().GetFields().Select(field => field.GetValue(Kleur.Wit)).ToList().Count();
            //int Zwart = board.GetType().GetFields().Select(field => field.GetValue(Kleur.Zwart)).ToList().Count();
            foreach (Kleur kleur in Board)
            {
                if(kleur == Kleur.Zwart)
                {
                    Zwart++;
                }
                if(kleur == Kleur.Wit)
                {
                    Wit++;
                }
            }
            if (Wit > Zwart)
            {
                return Kleur.Wit;
            }else if (Wit < Zwart)
            {
                return Kleur.Zwart;
            }
            else
            {
                return Kleur.Geen;
            }
        }
    }
    public enum Kleur { Geen, Wit, Zwart };

}
