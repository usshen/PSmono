using MonoTorrent;

namespace PSmono
{
    public class PSMonoOBJ
    {
        public PSMonoOBJ()
        {
            
        }

        public string Hashinfomation(string torrentfile)
        {
            InfoHash Tinfohash;
            Tinfohash = MonoTorrent.Torrent.Load(torrentfile).InfoHash;
            return Tinfohash.ToHex();
        }
        
        public string GetComment(string torrentfile)
        {
            
             return MonoTorrent.Torrent.Load(torrentfile).Comment;
        }

        public string GetTorrentName(string torrentfile)
        {

            return MonoTorrent.Torrent.Load(torrentfile).Name;
        }

        public TorrentFile[] GetTorrentFiles(string torrentfile)
        {

            return MonoTorrent.Torrent.Load(torrentfile).Files;
        }

        public long GetTorrentSize(string torrentfile)
        {

            return MonoTorrent.Torrent.Load(torrentfile).Size;
        }
    }
}
