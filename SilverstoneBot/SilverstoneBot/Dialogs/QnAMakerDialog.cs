using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SilverstoneBot.Dialogs
{
    [Serializable]
    public class QnAMakerDialog : IDialog<object>
    {
        #region QnAMaker keys
        
        public string QnAMakerSubscriptionKey
        {
            get
            {
                return ConfigurationManager.AppSettings["QnAMakerSubscriptionKey"];
            }
        }

        public string QnAMakerKnowledgebaseKey
        {
            get
            {
                return ConfigurationManager.AppSettings["QnAMakerKnowledgebaseKey"];
            }
        }

        #endregion

        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;

            Task<QnAMakerAnswer> ask = QueryQnAMakerAsync(context, activity.Text);

            var answer = await ask;

            var replyMessage = context.MakeMessage();


            //Small amount of smarts about the confidence of the answer
            if (answer.Score == 0)
            {
                replyMessage.Text = "We're very sorry, your question doesn't appear in our knowledge base. Try asking another.";
            }
            else if(answer.Score < 50)
            {
                replyMessage.Text = "We've found an answer which might help: \n\n" + answer.Answer;
            }
            else if (answer.Score >= 50)
            {
                replyMessage.Text = answer.Answer;
            }

            // return our reply to the user
            await context.PostAsync(replyMessage);

            context.Wait(MessageReceivedAsync);
        }


        private async Task<QnAMakerAnswer> QueryQnAMakerAsync(IDialogContext context, string query)
        {

            //Build the URI
            Uri qnaMakerUriBase = new Uri("https://westus.api.cognitive.microsoft.com/qnamaker/v1.0");
            var restEndPoint = new UriBuilder($"{qnaMakerUriBase}/knowledgebases/{this.QnAMakerKnowledgebaseKey}/generateAnswer");

            //Add the question as part of the body
            var content = $"{{\"question\": \"{query}\"}}";

            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Post, restEndPoint.Uri))
                {
                    request.Headers.Add("Ocp-Apim-Subscription-Key", this.QnAMakerSubscriptionKey);
                    request.Content = new StringContent(content, Encoding.UTF8, "application/json");

                    using (var response = client.SendAsync(request).Result)
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            //Cast our answer back to the business object
                            var answer = JsonConvert.DeserializeObject<QnAMakerAnswer>(response.Content.ReadAsStringAsync().Result);
                            return answer;
                        }
                    }
                }
            }

            return null;
        }

    }
}