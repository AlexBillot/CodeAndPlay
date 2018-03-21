using System.Threading;


namespace TrainingCodeAndPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            // On instancie l'API
            Api api = new Api();

            #region Appel test 

            // Appel test 
            var pong = api.GetPong();

            #endregion

            #region Recuperation de l'id d'equipe

            // Recuperation de l'id d'equipe

            string nomEquipe = "Peon'sOpera";
            string mdpDuel = "DuelàMort!";
            //string mdpEpic = "EpicOuEquipe?";
            string idEquipeDuel = api.GetIdEquipeDuel(nomEquipe, mdpDuel);

            System.Console.WriteLine(idEquipeDuel);

            #endregion

            #region Creation de la partie

            // Creation de la partie
            string levelBot = "1";
            api.CreerPartieDuel(levelBot, idEquipeDuel);

            //Recuperation de l'id de la partie
            string idPartie = api.GetIdPartieDuel(idEquipeDuel);

            System.Console.WriteLine(idPartie);

            #endregion

            #region Recuperation du statut de la partie

            // Recuperation du statut de la partie
            //string statutPartie = api.Getstatus(idPartie,idEquipeDuel);


            // Recuperation du plateau de jeu
            //string plateau = api.GetPlateau(idPartie);

            bool exit = false;
            string plateau;
            string lastCoup;
            int tour = 1;

            BotDuel bot = new BotDuel();

            while (!exit)
            {
                string statutPartie = api.Getstatus(idPartie, idEquipeDuel);
                System.Console.WriteLine(statutPartie);
                int milliseconds = 2000;
                Thread.Sleep(milliseconds);

                switch (statutPartie)
                {
                    case "OUI":
                        plateau = api.GetPlateau(idPartie);
                        lastCoup = api.GetLastCoup(idPartie);
                        bot.ListCoup.Add(tour, lastCoup);
                        //bot.Jouer(); //TODO
                        tour += 1;

                        System.Console.WriteLine(plateau);
                        //System.Console.WriteLine(lastCoup);
                        System.Console.Read();

                        break;
                    case "NON":
                        //Ce n'est pas à nous de jouer, on attend.
                        break;
                    case "GAGNE":
                        System.Console.WriteLine("Vous avez gagné la partie");
                        exit = true;
                        break;
                    case "PERDU":
                        System.Console.WriteLine("Vous avez perdu la partie");
                        exit = true;
                        break;
                    case "ANNULE":
                        System.Console.WriteLine("Match null !");
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
            #endregion



            //System.Console.Read();

        }
    }
}
