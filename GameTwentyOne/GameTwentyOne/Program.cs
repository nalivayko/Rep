using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTwentyOne
{
    class Cazino
    {
        public Cazino()
        {

        }

        static void Razdacha()
        {

        }

        static void GetCard(ref ListDictionary hand,ref ListDictionary cardDeck)
        {

        }

        static void DelerActions()
        {

        }

        static int CetCount(ListDictionary hand)
        {
            int n = 0;

            foreach (DictionaryEntry de in hand)
                n += (int)de.Value;
            return n;
        }

        static void Save()
        {
        }

        static void Load()
        {

        }
        public void ChangeTable()
        {

        }
    }
    class Table
    {
        ListDictionary user;
        ListDictionary cardDeck;
        ListDictionary diler;
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cazino t = new Cazino();
            ConsoleKeyInfo cki;
            

        }
    }
}
