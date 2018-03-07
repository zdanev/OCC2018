using System.Threading.Tasks;
using Alexa.NET;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace JokeSkill
{
    public class Function
    {
        public SkillResponse FunctionHandler(SkillRequest input, ILambdaContext context)
        {
            var intentRequest = input.Request as IntentRequest;

            if (intentRequest != null && intentRequest.Intent.Name.Equals("JokeIntent"))
            {
                var person = intentRequest.Intent.Slots["Person"]?.Value;

                if (!string.IsNullOrEmpty(person))
                {
                    var joke = GetJoke(person);

                    return ResponseBuilder.Tell(joke);
                }
            }

            return ResponseBuilder.Tell("sorry");
        }

        private string GetJoke(string person)
        {

            using(var icndb = new RestApi("https://api.icndb.com"))
            {
                var task = icndb.Get<IcndbResponse<JokeItem>>("/jokes/random", 
                    new QueryParam("firstName", person),
                    new QueryParam("lastName", " "));

                task.Wait();
            
                return task.Result.Value.Joke;
            }
        }       
    }
}
