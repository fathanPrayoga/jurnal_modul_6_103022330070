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
            if (Username == null)
            {
                throw new ArgumentNullException(nameof(Username),$"username tidak boleh kosong");

            }
            if (Username.Length > 100)
            {
                throw new ArgumentNullException($"username tidak boleh lebih dari 100 char", nameof(Username));
            }
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
            if (video == null)
            {
                throw new ArgumentNullException(nameof(video),$"video tidak boleh kosong");
            }

            if (video.GetPlayCount() == int.MaxValue)
            {
                throw new ArgumentNullException(nameof(video), $"video tidak boleh lebih batas integer");
            }
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
