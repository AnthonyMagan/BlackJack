using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack 
{
    public class Card
    {
        public string CardValueText { get; set; }       
        public int CardValueNum { get; set; }
        public Image Picture { get; set; }
    }
}
