using Microsoft.Bot.Connector;
using Microsoft.Bot.Connector.Teams;
using Microsoft.Bot.Connector.Teams.Models;
using SilverstoneBot.Utils;
using System.Collections.Generic;
using System.Linq;

namespace SilverstoneBot.Compose
{
    public class ComposeExtension
    {
        private Activity activity;

        public ComposeExtension(Activity activity)
        {
            this.activity = activity;
        }

        public ComposeExtensionResponse CreateComposeExtensionResponse()
        {
            ComposeExtensionResponse response = null;

            var query = activity.GetComposeExtensionQueryData();

            if (query.CommandId == null || query.Parameters == null)
            {
                return null;
            }

            if (query.CommandId == "driversCmd")
            {
                var results = new ComposeExtensionResult()
                {
                    AttachmentLayout = "list",
                    Type = "result",
                    Attachments = new List<ComposeExtensionAttachment>(),
                };


                var competitiors = Utils.Competitors.GetCompetitors();

                var driverName = "Unknown";

                for (int i = 0; i < query.Parameters.Count(); i++)
                {
                    if (query.Parameters[i].Name == "drivers")
                    {
                        driverName = query.Parameters[i].Value.ToString();
                    }
                }


                List<Competitor> result = competitiors.FindAll(x => x.DriverName.ToLower().Contains(driverName.ToLower()));

                if (result != null)
                {
                    foreach (var competitor in result)
                    {
                        var card = GenerateTyreSelectionCard(competitor);

                        var composeExtensionAttachment = card.ToAttachment().ToComposeExtensionAttachment();

                        //This code gets around the bug where 'preview' doesn't work
                        composeExtensionAttachment.ThumbnailUrl = card.Images[0].Url;
                        composeExtensionAttachment.Name = card.Title;

                        results.Attachments.Add(composeExtensionAttachment);
                    }
                }

                response = new ComposeExtensionResponse();
                response.ComposeExtension = results;

                return response;
            }


            return response;
        }


        #region ResultCard

        private ThumbnailCard GenerateTyreSelectionCard(Competitor competitor)
        {
            ThumbnailCard card = new ThumbnailCard()
            {
                Title = competitor.DriverName,
                Subtitle = "#" + competitor.DriverNumber + " " + competitor.DriverName + " - " + competitor.Team,
                Text = "Tyres: Hard: " + competitor.HardNumber.ToString() + " Medium: " + competitor.MediumNumber.ToString() + " Soft: " + competitor.SoftNumber.ToString(),
                Images = new List<CardImage>()
                {
                    new CardImage()
                    {
                        Url = competitor.CarThumbnail,
                    }
                }
            };

            card.Buttons = new List<CardAction>()
            {
                new CardAction("openEntrants", "Entry List", null, "http://www.fia.com/file/44711/download?token=CURV8hE7"),
                new CardAction("openTyres", "Tyre allocation", null, "http://www.fia.com/file/45339/download?token=0t2wTJUq")
            };

            return card;
        }

        #endregion


        
    }

    
}