using Alexa.NET;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace HelloCodeCamp
{
    public class Function
    {
        public SkillResponse FunctionHandler(SkillRequest input, ILambdaContext context)
        {
            var logger = context.Logger;
            var requestType = input.GetRequestType();

            if (requestType == typeof(Alexa.NET.Request.Type.LaunchRequest))
            {
                logger.Log("Launch Request");
            }

            var speech = new Alexa.NET.Response.SsmlOutputSpeech();
            speech.Ssml = "<speak>Hello, Code Camp!</speak>";

            var finalResponse = ResponseBuilder.Tell(speech);
            return finalResponse;        
        }      
    }
}
