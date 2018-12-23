using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json; // Install-Package Newtonsoft.Json

internal class Playlist
{
    public string views;

    public string title;

    public string description;

    public string author;

    public List<Video> video;

    public static Playlist GetPlaylistDetails(string playlistId)
    {
        WebClient wc = new WebClient();
        string playlistUrl = "https://www.youtube.com/list_ajax?style=json&action_get_list=1&list=" + playlistId;
        string playlistData = wc.DownloadString(playlistUrl);
        return JsonConvert.DeserializeObject<Playlist>(playlistData);
    }
}