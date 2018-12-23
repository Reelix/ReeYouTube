using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json; // Install-Package Newtonsoft.Json

internal class Video
{
    public string title;

    public string views;

    public string likes;

    public string dislikes;

    public string encrypted_id;

    public static List<Video> GetVideosFromPlaylist(string playlistId)
    {
        WebClient wc = new WebClient();
        string playlistUrl = "https://www.youtube.com/list_ajax?style=json&action_get_list=1&list=" + playlistId;
        string playlistData = wc.DownloadString(playlistUrl);
        Playlist thePlaylist = JsonConvert.DeserializeObject<Playlist>(playlistData);
        return thePlaylist.video;
    }
}