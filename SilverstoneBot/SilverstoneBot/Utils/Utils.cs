using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverstoneBot.Utils
{
    public class Utils
    {


    }

    public class Competitor
    {
        public string DriverNumber { get; set; }
        public string DriverName { get; set; }

        public string Team { get; set; }

        public string CarThumbnail { get; set; }

        public int HardNumber { get; set; }

        public int MediumNumber { get; set; }

        public int SoftNumber { get; set; }
    }

    static class Competitors
    {
        public static List<Competitor> GetCompetitors()
        {
            List<Competitor> competitors = new List<Competitor>();

            competitors.Add(new Competitor()
            {
                DriverName = "Hamilton",
                DriverNumber = "44",
                Team = "Mercedes",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-mercedes-80x20.png",
                HardNumber = 1,
                MediumNumber = 5,
                SoftNumber = 7
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Rosberg",
                DriverNumber = "6",
                Team = "Mercedes",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-mercedes-80x20.png",
                HardNumber = 1,
                MediumNumber = 5,
                SoftNumber = 7
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Vettel",
                DriverNumber = "5",
                Team = "Ferrari",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-ferrari-80x20.png",
                HardNumber = 2,
                MediumNumber = 3,
                SoftNumber = 8
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Raikkonen",
                DriverNumber = "7",
                Team = "Ferrari",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-ferrari-80x20.png",
                HardNumber = 2,
                MediumNumber = 3,
                SoftNumber = 8
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Massa",
                DriverNumber = "19",
                Team = "Williams",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-williams-80x20.png",
                HardNumber = 1,
                MediumNumber = 5,
                SoftNumber = 7
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Bottas",
                DriverNumber = "77",
                Team = "Williams",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-williams-80x20.png",
                HardNumber = 1,
                MediumNumber = 5,
                SoftNumber = 7
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Ricciardo",
                DriverNumber = "3",
                Team = "Red Bull",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-red-bull-80x20.png",
                HardNumber = 2,
                MediumNumber = 4,
                SoftNumber = 7
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Verstappen",
                DriverNumber = "33",
                Team = "Red Bull",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-red-bull-80x20.png",
                HardNumber = 2,
                MediumNumber = 4,
                SoftNumber = 7
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Hulkenberg",
                DriverNumber = "27",
                Team = "Force India",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-force-india-80x20.png",
                HardNumber = 3,
                MediumNumber = 4,
                SoftNumber = 6
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Perez",
                DriverNumber = "11",
                Team = "Force India",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-force-india-80x20.png",
                HardNumber = 3,
                MediumNumber = 4,
                SoftNumber = 6
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Magnussen",
                DriverNumber = "20",
                Team = "Renault",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-renault-80x20.png",
                HardNumber = 1,
                MediumNumber = 5,
                SoftNumber = 7
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Palmer",
                DriverNumber = "30",
                Team = "Renault",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-renault-80x20.png",
                HardNumber = 1,
                MediumNumber = 5,
                SoftNumber = 7
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Kvyat",
                DriverNumber = "26",
                Team = "Toro Rosso",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-toro-rosso-80x20.png",
                HardNumber = 2,
                MediumNumber = 3,
                SoftNumber = 8
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Sainz",
                DriverNumber = "55",
                Team = "Toro Rosso",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-toro-rosso-80x20.png",
                HardNumber = 2,
                MediumNumber = 3,
                SoftNumber = 8
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Ericsson",
                DriverNumber = "9",
                Team = "Sauber",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-sauber-80x20.png",
                HardNumber = 1,
                MediumNumber = 3,
                SoftNumber = 9
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Nasr",
                DriverNumber = "12",
                Team = "Sauber",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-sauber-80x20.png",
                HardNumber = 1,
                MediumNumber = 3,
                SoftNumber = 9
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Alonso",
                DriverNumber = "14",
                Team = "McLaren",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-mclaren-80x20.png",
                HardNumber = 1,
                MediumNumber = 5,
                SoftNumber = 7
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Button",
                DriverNumber = "22",
                Team = "McLaren",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-mclaren-80x20.png",
                HardNumber = 1,
                MediumNumber = 5,
                SoftNumber = 7
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Wehrlein",
                DriverNumber = "94",
                Team = "Manor",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-manor-80x20.png",
                HardNumber = 1,
                MediumNumber = 5,
                SoftNumber = 7
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Haryanto",
                DriverNumber = "88",
                Team = "Manor",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-manor-80x20.png",
                HardNumber = 1,
                MediumNumber = 5,
                SoftNumber = 7
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Grosjean",
                DriverNumber = "8",
                Team = "Haas",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-haas-80x20.png",
                HardNumber = 2,
                MediumNumber = 4,
                SoftNumber = 7
            });

            competitors.Add(new Competitor()
            {
                DriverName = "Gutierrez",
                DriverNumber = "21",
                Team = "Haas",
                CarThumbnail = "https://msteams-silverstonebot.azurewebsites.net/CarThumbnails/2016-lineup-haas-80x20.png",
                HardNumber = 1,
                MediumNumber = 5,
                SoftNumber = 7
            });

            return competitors;
        }
    }
}