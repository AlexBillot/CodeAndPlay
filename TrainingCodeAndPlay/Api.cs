using System.IO;
using System.Net;

namespace TrainingCodeAndPlay
{
    public class Api
    {
        public Api()
        {
        }

        public string GetPong()
        {
            System.Net.HttpWebRequest webrequest = (HttpWebRequest)System.Net.WebRequest.Create("http://duel.codeandplay.date/duel-ws/duel/ping");
            webrequest.Method = "GET";

            using (WebResponse response = webrequest.GetResponse()) //It gives exception at this line liek this http://prntscr.com/8c1gye
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }
        }

        public string GetIdEquipeDuel(string nomEquipe, string mdp)
        {
            System.Net.HttpWebRequest webrequest = (HttpWebRequest)System.Net.WebRequest.Create(string.Concat("http://duel.codeandplay.date/duel-ws/duel/player/getIdEquipe/{0}/{1}", nomEquipe, mdp));
            webrequest.Method = "GET";
            using (WebResponse response = webrequest.GetResponse()) //It gives exception at this line liek this http://prntscr.com/8c1gye
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }

        }

        public string CreerPartieDuel(string levelBot, string idEquipe)
        {
            System.Net.HttpWebRequest webrequest = (HttpWebRequest)System.Net.WebRequest.Create(string.Concat("http://duel.codeandplay.date/duel-ws/duel/practice/new/{0}/{1}", levelBot, idEquipe));
            webrequest.Method = "GET";
            using (WebResponse response = webrequest.GetResponse()) //It gives exception at this line liek this http://prntscr.com/8c1gye
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }

        }

        public string GetIdPartieDuel(string idEquipe)
        {
            System.Net.HttpWebRequest webrequest = (HttpWebRequest)System.Net.WebRequest.Create(string.Concat("http://duel.codeandplay.date/duel-ws/duel/practice/next/{0}", idEquipe));
            webrequest.Method = "GET";
            using (WebResponse response = webrequest.GetResponse()) //It gives exception at this line liek this http://prntscr.com/8c1gye
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }

        }

        public string Getstatus(string idPartie, string idEquipe)
        {
            System.Net.HttpWebRequest webrequest = (HttpWebRequest)System.Net.WebRequest.Create(string.Concat("http://duel.codeandplay.date/duel-ws/duel/game/status/{0}/{1}", idPartie, idEquipe));
            webrequest.Method = "GET";
            using (WebResponse response = webrequest.GetResponse()) //It gives exception at this line liek this http://prntscr.com/8c1gye
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }
        }

        public string GetPlateau(string idPartie)
        {
            System.Net.HttpWebRequest webrequest = (HttpWebRequest)System.Net.WebRequest.Create(string.Concat("http://duel.codeandplay.date/duel-ws/duel/game/board/{0}/{1}?format=string", idPartie));
            webrequest.Method = "GET";
            using (WebResponse response = webrequest.GetResponse()) //It gives exception at this line liek this http://prntscr.com/8c1gye
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }

        }

        public string GetLastCoup(string idPartie)
        {
            System.Net.HttpWebRequest webrequest = (HttpWebRequest)System.Net.WebRequest.Create(string.Concat("http://duel.codeandplay.date/test-ws/game/getlastmove/{0}", idPartie));
            webrequest.Method = "GET";
            using (WebResponse response = webrequest.GetResponse()) //It gives exception at this line liek this http://prntscr.com/8c1gye
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }

        }

    }
}
