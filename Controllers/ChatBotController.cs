using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Dialogflow.V2;
using Google.Protobuf;
using System.IO;
using System.Text;

namespace OwlOProjectA.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ChatBotController : ControllerBase
    {
        private static readonly JsonParser jsonParser = new JsonParser(JsonParser.Settings.Default.WithIgnoreUnknownFields(true));
        

		[HttpPost]
		public async Task<ContentResult> DialogAction()
        {
			WebhookRequest request;
			using (var reader = new StreamReader(Request.Body))
            {
				request = jsonParser.Parse<WebhookRequest>(reader);

            }
			if (request.QueryResult.Action == "signup")
            {

            }
            WebhookResponse response = new WebhookResponse
            {
                FulfillmentText = "Test Fulfillment text"
            };
            string responseJson = response.ToString();
            return Content(responseJson, "application/json");
        }
	}
}
