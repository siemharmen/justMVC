using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReversiMVC.Models
{
    public class Board
    {
        [Key]
        public int Id { get; set; }

        public Spel Spel { get; set; }
        public int SpelID { get; set; }


        public Kleur Row00 { get; set; }
        public Kleur Row01 { get; set; }
        public Kleur Row02 { get; set; }
        public Kleur Row03 { get; set; }
        public Kleur Row04 { get; set; }
        public Kleur Row05 { get; set; }
        public Kleur Row06 { get; set; }
        public Kleur Row07 { get; set; }
        public Kleur Row10 { get; set; }
        public Kleur Row11 { get; set; }
        public Kleur Row12 { get; set; }
        public Kleur Row13 { get; set; }
        public Kleur Row14 { get; set; }
        public Kleur Row15 { get; set; }
        public Kleur Row16 { get; set; }
        public Kleur Row17 { get; set; }
        public Kleur Row20 { get; set; }
        public Kleur Row21 { get; set; }
        public Kleur Row22 { get; set; }
        public Kleur Row23 { get; set; }
        public Kleur Row24 { get; set; }
        public Kleur Row25 { get; set; }
        public Kleur Row26 { get; set; }
        public Kleur Row27 { get; set; }
        public Kleur Row30 { get; set; }
        public Kleur Row31 { get; set; }
        public Kleur Row32 { get; set; }
        public Kleur Row33 { get; set; }
        public Kleur Row34 { get; set; }
        public Kleur Row35 { get; set; }
        public Kleur Row36 { get; set; }
        public Kleur Row37 { get; set; }
        public Kleur Row40 { get; set; }
        public Kleur Row41 { get; set; }
        public Kleur Row42 { get; set; }
        public Kleur Row43 { get; set; }
        public Kleur Row44 { get; set; }
        public Kleur Row45 { get; set; }
        public Kleur Row46 { get; set; }
        public Kleur Row47 { get; set; }
        public Kleur Row50 { get; set; }
        public Kleur Row51 { get; set; }
        public Kleur Row52 { get; set; }
        public Kleur Row53 { get; set; }
        public Kleur Row54 { get; set; }
        public Kleur Row55 { get; set; }
        public Kleur Row56 { get; set; }
        public Kleur Row57 { get; set; }
        public Kleur Row60 { get; set; }
        public Kleur Row61 { get; set; }
        public Kleur Row62 { get; set; }
        public Kleur Row63 { get; set; }
        public Kleur Row64 { get; set; }
        public Kleur Row65 { get; set; }
        public Kleur Row66 { get; set; }
        public Kleur Row67 { get; set; }
        public Kleur Row70 { get; set; }
        public Kleur Row71 { get; set; }
        public Kleur Row72 { get; set; }
        public Kleur Row73 { get; set; }
        public Kleur Row74 { get; set; }
        public Kleur Row75 { get; set; }
        public Kleur Row76 { get; set; }
        public Kleur Row77 { get; set; }
    }
}
