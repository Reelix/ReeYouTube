using System;
using System.Collections.Generic;

namespace ReeYouTube
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Reelix's YouTube Utils App";
            string playlistId = "PLzw_r3FRBpcMejn_maOZjBKo51RkDue_3";
            Playlist thePlaylist = Playlist.GetPlaylistDetails(playlistId);
            List<Video> videoList = Video.GetVideosFromPlaylist(playlistId);
            Console.WriteLine("Playlist Title: " + thePlaylist.title);
            Console.WriteLine("Playlist Author: " + thePlaylist.author);
            Console.WriteLine("Video Count: " + thePlaylist.video.Count);
            Console.WriteLine();
            Console.WriteLine("Videos");
            Console.WriteLine("------");
            foreach (Video item in videoList)
            {
                Console.WriteLine("Title: " + item.title);
                Console.WriteLine("Views: " + item.views);
                Console.WriteLine("Likes: " + item.likes + ", Dislikes: " + item.dislikes);
                Console.WriteLine("Youtube Video Id: " + item.encrypted_id);
                Console.WriteLine();
            }
        }
    }
}