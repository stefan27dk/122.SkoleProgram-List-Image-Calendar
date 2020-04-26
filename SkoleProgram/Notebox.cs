using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleProgram
{
    [Serializable]
    class Notebox
    {
        public string date;
        public string noteboxtext;


        public Notebox(string Date, string Noteboxtext)
        {

            this.date = Date;
            this.noteboxtext = Noteboxtext;

        }

        public string GetNote()
        {
            return noteboxtext;
        }
    }
}
