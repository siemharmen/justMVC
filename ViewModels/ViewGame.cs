using Microsoft.EntityFrameworkCore;
using ReversiMVC.Controllers;
using ReversiMVC.Data;
using ReversiMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ReversiMVC.ViewModels
{
    
    public class ViewGame
    {
        private readonly ApplicationDbContext _context;
        private readonly ReversiHerkansing.Data.ReversiHerkansingContext reversiHerkansingContext;
        public Spel spel;
        public int test;
        public string CurrentSpeler;
        public Board board;
        public Boolean Afgelopen;
        public List<int[]> Mogeljke { get; set; }
        public List<int[]> AfgelpenZetten { get; set; }


        public int rij { get; set; }
        public int kolom { get; set; }

        public int spelid { get; set; }


        private readonly IHttpClientFactory _httpCLientFactory;

        
        public ViewGame(ApplicationDbContext context, Spel spel,string currentSpeler, IHttpClientFactory httpClientFactory)
        {
            _context = context;
            this.spel = spel;
            test = 0;
            CurrentSpeler = currentSpeler;
            _httpCLientFactory = httpClientFactory;
            //AfgelpenZetten = spel.GetMogelijkeZettenAflopen();
        }
        public Boolean GetAfgelopen()
        {
            return true;
        }
        public async Task<Boolean> Doezet(int spelid,int rij,int kolom)
        {
            //_htttpclienfactory kijken
            HttpController httpController = new HttpController(_httpCLientFactory);
            await httpController.Doezet(spelid, rij, kolom);
            //kijke testen 
            return true;
        }

        public Kleur[,] LoadBoard()
        {
             Kleur[,] Bord = new Kleur[,] {
                    { board.Row00, board.Row01,board.Row02,board.Row03,board.Row04,board.Row05,board.Row06,board.Row07},
                    { board.Row10, board.Row11,board.Row12,board.Row13,board.Row14,board.Row15,board.Row16,board.Row17},
                    { board.Row20, board.Row21,board.Row22,board.Row23,board.Row24,board.Row25,board.Row26,board.Row27},
                    { board.Row30, board.Row31,board.Row32,board.Row33,board.Row34,board.Row35,board.Row36,board.Row37},
                    { board.Row40, board.Row41,board.Row42,board.Row43,board.Row44,board.Row45,board.Row46,board.Row47},
                    { board.Row50, board.Row51,board.Row52,board.Row53,board.Row54,board.Row55,board.Row56,board.Row57},
                    { board.Row60, board.Row61,board.Row62,board.Row63,board.Row64,board.Row65,board.Row66,board.Row67},
                    { board.Row70, board.Row71,board.Row72,board.Row73,board.Row74,board.Row75,board.Row76,board.Row77},
                };
            return Bord;
        }
        public List<int> LoadBoardInt()
        {
            int[,] Bord = new int[,] {
                     {(int)board.Row00, (int)board.Row01,(int)board.Row02,(int)board.Row03,(int)board.Row04,(int)board.Row05,(int)board.Row06,(int)board.Row07},
                     {(int)board.Row10, (int)board.Row11,(int)board.Row12,(int)board.Row13,(int)board.Row14,(int)board.Row15,(int)board.Row16,(int)board.Row17},
                     {(int)board.Row20, (int)board.Row21,(int)board.Row22,(int)board.Row23,(int)board.Row24,(int)board.Row25,(int)board.Row26,(int)board.Row27},
                     {(int)board.Row30, (int)board.Row31,(int)board.Row32,(int)board.Row33,(int)board.Row34,(int)board.Row35,(int)board.Row36,(int)board.Row37},
                     {(int)board.Row40, (int)board.Row41,(int)board.Row42,(int)board.Row43,(int)board.Row44,(int)board.Row45,(int)board.Row46,(int)board.Row47},
                     {(int)board.Row50, (int)board.Row51,(int)board.Row52,(int)board.Row53,(int)board.Row54,(int)board.Row55,(int)board.Row56,(int)board.Row57},
                     {(int)board.Row60, (int)board.Row61,(int)board.Row62,(int)board.Row63,(int)board.Row64,(int)board.Row65,(int)board.Row66,(int)board.Row67},
                     {(int)board.Row70, (int)board.Row71,(int)board.Row72,(int)board.Row73,(int)board.Row74,(int)board.Row75,(int)board.Row76,(int)board.Row77},
                };

            List<int> list = new List<int>();
            foreach (int array in Bord)
            {
                list.Add(array);
            }
            return list;
        }
        
        public int Refresh()
        {            //goede opstlelen   
            // ReversiHerkansing.Model.Spel Anderespel = new ReversiHerkansing.Model.Spel();
            // dal een communicatie methode maken

            //ReversiHerkansing.Model.Spel Anderespel = ReversiHerkansing.DAL.SpelAccessReversi.GetSpel(spel.Omschrijving,reversiHerkansingContext);
            //Anderespel.Afgelopen();
            //            Project B.Program ab = new Project B.Program();

            //ReversiHerkansing.DAL.SpelAccessReversi reversiHerkansing = new ReversiHerkansing.DAL.SpelAccessReversi();
            test++;

            Console.Write(test);
            spel = _context.Spellen.FirstOrDefault(m => m.ID == spel.ID);
            //spel.Speler1Token = "test";
            //spel.Speler2Token = "nummer: " + test;
            //HomeController.Index();

            return spel.Ingame;
            //in game return view doen
        }
        public int GetSpelId()
        {
            spel = _context.Spellen.FirstOrDefault(m => m.ID == spel.ID);
            //spel.Speler1Token = "test";
            //spel.Speler2Token = "nummer: " + test;
            //HomeController.Index();
            return spel.ID;
            //in game return view doen
        }
    }
}
