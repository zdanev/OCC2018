using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alexa.NET;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using Amazon.Lambda.Core;
using CodeCampster;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace CodeCampSkill
{
    public static class Prompts
    {
        public static string[] Greetings = new[] 
        { 
            "Welcome to Code Camp!", 
            "Hello, Code Camp!" 
        };

        public static string[] Help = new[] 
        {
            "Ask me about a speaker.",
            "I can help you with speakers and sessions information."
        };

        public static string[] Sorry = new[] 
        {
            "Sorry, I didn't get that.",
            "Sorry, Let's try again."
        };
        
        public static string PickRandom(this string[] options)
        {
            var rnd = new Random();
            return options[rnd.Next(options.Length)];
        }
 }

    public class Function
    {
        public async Task<SkillResponse> FunctionHandler(SkillRequest input, ILambdaContext context)
        {
            var requestType = input.GetRequestType();
            var intentRequest = input.Request as IntentRequest;

            if (requestType == typeof(Alexa.NET.Request.Type.LaunchRequest))
            {
                return ResponseBuilder.Tell(Prompts.Greetings.PickRandom());
            } 
            else if (intentRequest?.Intent.Name == "SpeakerInfo") 
            {
                try
                {
                    var speakerName = intentRequest.Intent.Slots["SpeakerName"].Value;

                    var codeCampApi = new CodeCampApi();
                    var speaker = await codeCampApi.GetSpeaker(speakerName);

                    if (speaker != null)
                    {
                        var info = speaker.ToString();
                        return ResponseBuilder.TellWithCard(info, speaker.FullName, info);
                    }
                }
                catch
                {
                    // ignore, fall back to "sorry"
                }
            }
            else if (intentRequest?.Intent.Name == "AMAZON.HelpIntent") 
            {
                var help = Prompts.Help.PickRandom();
                return ResponseBuilder.TellWithCard(help, "Help", help);
            }

            return ResponseBuilder.Tell(Prompts.Sorry.PickRandom());
         }
    }
}
