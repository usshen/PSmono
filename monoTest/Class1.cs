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
    }
}
