using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalModul6_103022330070
{
    class SayaTubeVideo
    {
        private int id;
        private String title;
        private int Playcount;



        public SayaTubeVideo(String title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 1000000);
            this.title = title;
            this.Playcount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.Playcount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {Playcount}");
        }
        public int GetPlayCount()
        {
            return Playcount;
        }
        public String GetTitle()
        {
            return title;
        }
    }
}
