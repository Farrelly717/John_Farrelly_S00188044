using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Farrelly_S00188044
{
    public enum Position { Goalkeeper, Defender,Midfielder, Forward}
    class Player
    {
        
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Position PreferredPosition { get; set; }
        public DateTime DOB { get; set; }
        public DateTime Age { get; set; }

    }
}
