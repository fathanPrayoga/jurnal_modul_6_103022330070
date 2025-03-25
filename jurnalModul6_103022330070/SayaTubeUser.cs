using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalModul6_103022330070
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideo;
        private String Username;


        public SayaTubeUser(String Username)
        {
            Random random = new Random();
            this.id = random.Next(10000, 1000000);
            this.Username = Username;
            this.uploadedVideo = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;
            for (int i = 0; i < uploadedVideo.Count; i++)
            {
                totalPlayCount += uploadedVideo[i].GetPlayCount();
            }
            return totalPlayCount;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideo.Add(video);
        }

        public void PrintAllVideo()
        {
            Console.WriteLine($"user: {Username}");
            for (int i = 0; i < uploadedVideo.Count; i++)
            {
                Console.WriteLine($"video {i + 1} judul: {uploadedVideo[i].GetTitle()}");
            }
        }

    }
}
