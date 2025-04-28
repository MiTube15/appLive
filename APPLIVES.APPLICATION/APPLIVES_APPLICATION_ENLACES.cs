using APPLIVE.ENTITIES;

namespace APPLIVES.APPLICATION
{
    public class APPLIVES_APPLICATION_ENLACES : APPLIVE_APPLICATION
    {

        private readonly List<APPLIVES_ENLACES> _streams = new List<APPLIVES_ENLACES>
        {
           new APPLIVES_ENLACES { ChannelName = "ESPN", Url = "https://la12hd.com/vivo/canales.php?stream=espn" },
new APPLIVES_ENLACES { ChannelName = "ESPN2", Url = "https://la12hd.com/vivo/canales.php?stream=espn2" },
new APPLIVES_ENLACES { ChannelName = "ESPN3", Url = "https://la12hd.com/vivo/canales.php?stream=espn3" },
new APPLIVES_ENLACES { ChannelName = "ESPN4", Url = "https://la12hd.com/vivo/canales.php?stream=espn4" },
new APPLIVES_ENLACES { ChannelName = "ESPN5", Url = "https://la12hd.com/vivo/canales.php?stream=espn5" },
new APPLIVES_ENLACES { ChannelName = "ESPN6", Url = "https://la12hd.com/vivo/canales.php?stream=espn6" },
new APPLIVES_ENLACES { ChannelName = "ESPN7", Url = "https://la12hd.com/vivo/canales.php?stream=espn7" },
new APPLIVES_ENLACES { ChannelName = "DSports", Url = "https://la12hd.com/vivo/canales.php?stream=dsports" },
new APPLIVES_ENLACES { ChannelName = "DSports 2", Url = "https://la12hd.com/vivo/canales.php?stream=dsports2" },
new APPLIVES_ENLACES { ChannelName = "DSports Plus", Url = "https://la12hd.com/vivo/canales.php?stream=dsportsplus" },
new APPLIVES_ENLACES { ChannelName = "GOLTV", Url = "https://la12hd.com/vivo/canales.php?stream=goltv" },
new APPLIVES_ENLACES { ChannelName = "VTV Plus", Url = "https://la12hd.com/vivo/canales.php?stream=vtvplus" },
new APPLIVES_ENLACES { ChannelName = "ECDF LigaPro", Url = "https://la12hd.com/vivo/canales.php?stream=ecdf_ligapro" },
new APPLIVES_ENLACES { ChannelName = "Fox Sports", Url = "https://la12hd.com/vivo/canales.php?stream=foxsports" },
new APPLIVES_ENLACES { ChannelName = "Fox Sports 2", Url = "https://la12hd.com/vivo/canales.php?stream=foxsports2" },
new APPLIVES_ENLACES { ChannelName = "Fox Sports 3", Url = "https://la12hd.com/vivo/canales.php?stream=foxsports3" },
new APPLIVES_ENLACES { ChannelName = "TNT Sports", Url = "https://la12hd.com/vivo/canales.php?stream=tntsports" },
new APPLIVES_ENLACES { ChannelName = "ESPN Premium", Url = "https://la12hd.com/vivo/canales.php?stream=espnpremium" },
new APPLIVES_ENLACES { ChannelName = "TyC Sports", Url = "https://la12hd.com/vivo/canales.php?stream=tycsports" },
new APPLIVES_ENLACES { ChannelName = "TyC Internacional", Url = "https://la12hd.com/vivo/canales.php?stream=tycinternacional" },
new APPLIVES_ENLACES { ChannelName = "Telefe", Url = "https://la12hd.com/vivo/canales.php?stream=telefe" },
new APPLIVES_ENLACES { ChannelName = "TV Pública", Url = "https://la12hd.com/vivo/canales.php?stream=tvpublica" },
new APPLIVES_ENLACES { ChannelName = "GOLPERU", Url = "https://la12hd.com/vivo/canales.php?stream=golperu" },
new APPLIVES_ENLACES { ChannelName = "Liga 1 Max", Url = "https://la12hd.com/vivo/canales.php?stream=liga1max" },
new APPLIVES_ENLACES { ChannelName = "Movistar", Url = "https://la12hd.com/vivo/canales.php?stream=movistar" },
new APPLIVES_ENLACES { ChannelName = "Win Sports+", Url = "https://la12hd.com/vivo/canales.php?stream=winsportsplus" },
new APPLIVES_ENLACES { ChannelName = "Win Sports 2", Url = "https://la12hd.com/vivo/canales.php?stream=winsports2" },
new APPLIVES_ENLACES { ChannelName = "Win Sports", Url = "https://la12hd.com/vivo/canales.php?stream=winsports" },
new APPLIVES_ENLACES { ChannelName = "Fox Sports MX", Url = "https://la12hd.com/vivo/canales.php?stream=foxsportsmx" },
new APPLIVES_ENLACES { ChannelName = "Fox Sports 2 MX", Url = "https://la12hd.com/vivo/canales.php?stream=foxsports2mx" },
new APPLIVES_ENLACES { ChannelName = "Fox Sports 3 MX", Url = "https://la12hd.com/vivo/canales.php?stream=foxsports3mx" },
new APPLIVES_ENLACES { ChannelName = "Fox Sports Premium", Url = "https://la12hd.com/vivo/canales.php?stream=foxsportspremium" },
new APPLIVES_ENLACES { ChannelName = "TUDN MX", Url = "https://la12hd.com/vivo/canales.php?stream=tudn_mx" },
new APPLIVES_ENLACES { ChannelName = "ESPN MX", Url = "https://la12hd.com/vivo/canales.php?stream=espnmx" },
new APPLIVES_ENLACES { ChannelName = "ESPN2 MX", Url = "https://la12hd.com/vivo/canales.php?stream=espn2mx" },
new APPLIVES_ENLACES { ChannelName = "ESPN3 MX", Url = "https://la12hd.com/vivo/canales.php?stream=espn3mx" },
new APPLIVES_ENLACES { ChannelName = "ESPN4 MX", Url = "https://la12hd.com/vivo/canales.php?stream=espn4mx" },
new APPLIVES_ENLACES { ChannelName = "Caliente TV", Url = "https://la12hd.com/vivo/canales.php?stream=calientetv" },
new APPLIVES_ENLACES { ChannelName = "Azteca 7", Url = "https://la12hd.com/vivo/canales.php?stream=azteca7" },
new APPLIVES_ENLACES { ChannelName = "Canal 5", Url = "https://la12hd.com/vivo/canales.php?stream=canal5" },
new APPLIVES_ENLACES { ChannelName = "TVC Deportes", Url = "https://la12hd.com/vivo/canales.php?stream=tvc_deportes" },
new APPLIVES_ENLACES { ChannelName = "Azteca Deportes", Url = "https://la12hd.com/vivo/canales.php?stream=azteca_deportes" },
new APPLIVES_ENLACES { ChannelName = "HiSports", Url = "https://la12hd.com/vivo/canales.php?stream=hisports" },
new APPLIVES_ENLACES { ChannelName = "Sky Sports LaLiga", Url = "https://la12hd.com/vivo/canales.php?stream=sky_sports_laliga" },
new APPLIVES_ENLACES { ChannelName = "Sky Bundesliga MX", Url = "https://la12hd.com/vivo/canales.php?stream=sky_bundesliga_mx" },
new APPLIVES_ENLACES { ChannelName = "Fox Deportes", Url = "https://la12hd.com/vivo/canales.php?stream=foxdeportes" },
new APPLIVES_ENLACES { ChannelName = "ESPN Deportes", Url = "https://la12hd.com/vivo/canales.php?stream=espndeportes" },
new APPLIVES_ENLACES { ChannelName = "TUDN", Url = "https://la12hd.com/vivo/canales.php?stream=tudn" },
new APPLIVES_ENLACES { ChannelName = "Univision", Url = "https://la12hd.com/vivo/canales.php?stream=univision" },
new APPLIVES_ENLACES { ChannelName = "Fox Sports 1 USA", Url = "https://la12hd.com/vivo/canales.php?stream=foxsports1_usa" },
new APPLIVES_ENLACES { ChannelName = "Fox Sports 2 USA", Url = "https://la12hd.com/vivo/canales.php?stream=foxsports2_usa" },
new APPLIVES_ENLACES { ChannelName = "Universo", Url = "https://la12hd.com/vivo/canales.php?stream=universo" },
new APPLIVES_ENLACES { ChannelName = "BeIN Sports ES", Url = "https://la12hd.com/vivo/canales.php?stream=beinsportes" },
new APPLIVES_ENLACES { ChannelName = "UniMás", Url = "https://la12hd.com/vivo/canales.php?stream=unimas" },
new APPLIVES_ENLACES { ChannelName = "BeIN Xtra Español", Url = "https://la12hd.com/vivo/canales.php?stream=beinsport_xtra_espanol" },
new APPLIVES_ENLACES { ChannelName = "ESPN USA", Url = "https://la12hd.com/vivo/canales.php?stream=espn_usa" },
new APPLIVES_ENLACES { ChannelName = "ESPN2 USA", Url = "https://la12hd.com/vivo/canales.php?stream=espn2_usa" },
new APPLIVES_ENLACES { ChannelName = "ESPN Deportes USA", Url = "https://la12hd.com/vivo/canales.php?stream=espn_deportes_usa" },
new APPLIVES_ENLACES { ChannelName = "DAZN 1 ES", Url = "https://la12hd.com/vivo/canales.php?stream=dazn1_es" },
new APPLIVES_ENLACES { ChannelName = "DAZN 2 ES", Url = "https://la12hd.com/vivo/canales.php?stream=dazn2_es" },
new APPLIVES_ENLACES { ChannelName = "DAZN 3 ES", Url = "https://la12hd.com/vivo/canales.php?stream=dazn3_es" },
new APPLIVES_ENLACES { ChannelName = "DAZN LaLiga", Url = "https://la12hd.com/vivo/canales.php?stream=dazn_laliga" },
new APPLIVES_ENLACES { ChannelName = "LaLiga TV Bar", Url = "https://la12hd.com/vivo/canales.php?stream=laligatv_bar" },
new APPLIVES_ENLACES { ChannelName = "Vamos", Url = "https://la12hd.com/vivo/canales.php?stream=vamos" },
new APPLIVES_ENLACES { ChannelName = "Movistar LaLiga", Url = "https://la12hd.com/vivo/canales.php?stream=movistar_laliga" },
new APPLIVES_ENLACES { ChannelName = "Movistar Liga de Campeones", Url = "https://la12hd.com/vivo/canales.php?stream=movistar_liga_de_campeones" },
new APPLIVES_ENLACES { ChannelName = "Movistar Deportes", Url = "https://la12hd.com/vivo/canales.php?stream=movistar_deportes" },
new APPLIVES_ENLACES { ChannelName = "Movistar Plus+", Url = "https://la12hd.com/vivo/canales.php?stream=movistar_plus" },
new APPLIVES_ENLACES { ChannelName = "Gol Play", Url = "https://la12hd.com/vivo/canales.php?stream=gol_play" },
new APPLIVES_ENLACES { ChannelName = "Eurosport 1 ES", Url = "https://la12hd.com/vivo/canales.php?stream=eurosport1_es" },
new APPLIVES_ENLACES { ChannelName = "Eurosport 2 ES", Url = "https://la12hd.com/vivo/canales.php?stream=eurosport2_es" },
new APPLIVES_ENLACES { ChannelName = "Canal+ Sport 1", Url = "https://la12hd.com/vivo/canales.php?stream=canalplus_sport1" },
new APPLIVES_ENLACES { ChannelName = "Canal+ Sport 2", Url = "https://la12hd.com/vivo/canales.php?stream=canalplus_sport2" },
new APPLIVES_ENLACES { ChannelName = "Canal+ Sport 3", Url = "https://la12hd.com/vivo/canales.php?stream=canalplus_sport3" },
new APPLIVES_ENLACES { ChannelName = "Canal+ Foot", Url = "https://la12hd.com/vivo/canales.php?stream=canalplus_foot" },
new APPLIVES_ENLACES { ChannelName = "Canal+ Liga de Campeones", Url = "https://la12hd.com/vivo/canales.php?stream=canalplus_liga_de_campeones" },
new APPLIVES_ENLACES { ChannelName = "Canal+ Liga", Url = "https://la12hd.com/vivo/canales.php?stream=canalplus_liga" },
new APPLIVES_ENLACES { ChannelName = "RMC Sport 1", Url = "https://la12hd.com/vivo/canales.php?stream=rmc_sport1" },
new APPLIVES_ENLACES { ChannelName = "RMC Sport 2", Url = "https://la12hd.com/vivo/canales.php?stream=rmc_sport2" },
new APPLIVES_ENLACES { ChannelName = "RMC Sport Live", Url = "https://la12hd.com/vivo/canales.php?stream=rmc_sport_live" },
new APPLIVES_ENLACES { ChannelName = "BeIN Sports FR 1", Url = "https://la12hd.com/vivo/canales.php?stream=beinsports_fr1" },
new APPLIVES_ENLACES { ChannelName = "BeIN Sports FR 2", Url = "https://la12hd.com/vivo/canales.php?stream=beinsports_fr2" },
new APPLIVES_ENLACES { ChannelName = "BeIN Sports FR 3", Url = "https://la12hd.com/vivo/canales.php?stream=beinsports_fr3" },
new APPLIVES_ENLACES { ChannelName = "Eleven 1 BE", Url = "https://la12hd.com/vivo/canales.php?stream=eleven1_be" },
new APPLIVES_ENLACES { ChannelName = "Eleven 2 BE", Url = "https://la12hd.com/vivo/canales.php?stream=eleven2_be" },
new APPLIVES_ENLACES { ChannelName = "Eleven 3 BE", Url = "https://la12hd.com/vivo/canales.php?stream=eleven3_be" },
new APPLIVES_ENLACES { ChannelName = "Eleven Pro League 1 BE", Url = "https://la12hd.com/vivo/canales.php?stream=elevenpro1_be" },

        };
        public  List<APPLIVES_ENLACES> GetAllStreams()
        {
            return _streams;
        }

        public APPLIVES_ENLACES GetStreamByChannel(string channelName)
        {
            return _streams.FirstOrDefault(s => s.ChannelName.ToLower() == channelName.ToLower());
        }
    }
}
