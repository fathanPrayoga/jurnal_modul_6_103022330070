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
            if (title == null)
            {
                throw new ArgumentNullException(nameof(title), "Judul film tidak boleh kosong.");
            }
            if (title.Length > 100)
            {
                throw new ArgumentNullException("Judul film tidak boleh kosong.", nameof(title));
            }
            Random random = new Random();
            this.id = random.Next(10000, 1000000);
            this.title = title;
            this.Playcount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if(count <= 0)
            {
                throw new ArgumentException("Play count tidak boleh negatif", nameof(count));
            }
            if(count > 25000000)
            {
                throw new ArgumentException("Play count tidak boleh lebih dari 25jt", nameof(count));
            }
            try
            {
                checked
                {
                    this.Playcount += count;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"overflow terjadi: {ex.Message}");
                this.Playcount += int.MaxValue;
            }
            
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
