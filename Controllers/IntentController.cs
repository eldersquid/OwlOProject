using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Dialogflow.V2;
using Google.Apis.Auth.OAuth2;
using System.IO;
using System.Reflection;
using Google.Apis.Dialogflow.v3beta1;
using Newtonsoft.Json;
using Google.Apis.Dialogflow.v3beta1.Data;
using System.Collections;

namespace OwlOProjectA.Controllers
{
    public class IntentController : Controller
    {


        [HttpPost]
        public ActionResult DetectIntent(string query)
        {
            
            var sessionID = new Guid();
            string credential_path = @"./credentials/owlprojectchatbot.json";
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credential_path);
            var client = SessionsClient.Create();
            
            var response = client.DetectIntent(
                session : SessionName.FromProjectSession("owlprojectchatbot-smog", sessionID.ToString()),
                queryInput: new QueryInput(){
                    
                    Text = new TextInput()
                    {
                        Text = query, LanguageCode = "en-US"
                    }
                    
                }
                );
            var queryResult = response.QueryResult;
            
            
            Console.WriteLine($"Query text: {queryResult.QueryText}");
            if (queryResult.Intent != null)
            {
                Console.WriteLine($"Intent detected: {queryResult}");
                Console.WriteLine($"Intent detected: {queryResult.Intent.DisplayName}");
            }
            Console.WriteLine($"Intent confidence: {queryResult.IntentDetectionConfidence}");
            Console.WriteLine($"Fulfillment text: {queryResult.FulfillmentText}");
            Console.WriteLine();


            return Json(new { answer = queryResult.FulfillmentText.ToString() });
        }

        
        public string CreateIntent()
        {

            var sessionID = new Guid();
            string credential_path = @"./credentials/owlprojectchatbot.json";
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credential_path);
            var project = "projects/owlprojectchatbot-smog/agent";
            var client = IntentsClient.Create();

            
            

            var intent = new Intent();

            CreateIntentRequest createIntent = new CreateIntentRequest
            {
                Parent = project,
                Intent = intent,
                IntentView = IntentView.Full
            };

            intent.DisplayName = "Test";
            var newIntent = client.CreateIntent(createIntent);

            
            
            
           
            
            //var newIntentID = newIntent.Result.Name;
            //var getIntent = client.GetIntentAsync(project + "/" + newIntentID);
            return newIntent.ToString();







            //return Json(new { answer = queryResult.FulfillmentText.ToString() });
            
        }

        public List<Intent> ViewIntents()
        {
            string credential_path = @"./credentials/owlprojectchatbot.json";
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credential_path);
            var project = "projects/owlprojectchatbot-smog/agent";
            var client = IntentsClient.Create();


            ListIntentsRequest listIntent = new ListIntentsRequest
            {
                Parent = project,
                IntentView = IntentView.Full
            };

            


           
            var intents = client.ListIntents(listIntent);

            

            List<Intent> intentList = new List<Intent>();



            foreach (Intent item in intents)
            {
                
                intentList.Add(item);
                
            }

            return intentList;
            


        }

        public void DeleteIntent(string name)
        {
            string credential_path = @"./credentials/owlprojectchatbot.json";
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credential_path);
            var project = "projects/owlprojectchatbot-smog/agent/";
            var client = IntentsClient.Create();
            string path = project + "intents/" + name;
            client.DeleteIntent(path);

           



        }


        public WebhookResponse PostWH([FromBody] string requestString)
        {
            var requestParser = new Google.Protobuf.JsonParser(
              Google.Protobuf.JsonParser.Settings.Default.WithIgnoreUnknownFields(true));
            WebhookRequest webhookRequest = requestParser.Parse<WebhookRequest>(requestString);
            WebhookResponse webhookResponse = new WebhookResponse();
            webhookResponse.FulfillmentText = webhookRequest.ToString();
            return webhookResponse;
        }

      
        public GoogleCloudDialogflowV2WebhookResponse Post(GoogleCloudDialogflowV2WebhookRequest obj)
        {
            string credential_path = @"./credentials/owlprojectchatbot.json";
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credential_path);
            
               
                string Question = string.Empty;

                switch (obj.QueryResult.Intent.DisplayName)
                {
                    case "General Query":
                        Question = obj.QueryResult.Parameters["Question"].ToString();
                        break;
                }

                var response = new GoogleCloudDialogflowV2WebhookResponse()
                {
                    FulfillmentText = $"The stock at {Question} is valuing Rs. 31 Lakhs \n And consists of items such as slatwall, grid and new pillar. The detailed list of the same has been email to you",
                    Source = "API.AI"
                };
                return response;
            
           
        }


    }
}
