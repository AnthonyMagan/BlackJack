using System.Threading;

namespace BlackJack
{
    class Pause 
    {
        public Pause(int pause)
        {
            Thread.Sleep(pause * 1000);
        }
        
    }
}
