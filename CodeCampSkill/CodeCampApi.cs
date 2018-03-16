using System.Text;
using System.Threading.Tasks;
using RestHelper;

namespace CodeCampster
{
    public class Speaker
    {
        public string FullName { get; set; }

        public string Company { get; set; }

        public string Title { get; set; }

        public string Bio { get; set; }

        public Session[] Sessions { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{FullName} is {Title} at {Company}.");

            if (Sessions?.Length == 1)
            {
                sb.AppendLine($"He has one session: {Sessions[0].Name}.");
            }
            else if (Sessions?.Length > 1)
            {
                sb.AppendLine($"He has {Sessions.Length} sessions:");
                foreach (var session in Sessions)
                {
                    sb.AppendLine(session.Name);
                }
            }

            return sb.ToString();
        }
    }

    public class Session
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }

    public class CodeCampApi
    {
        public async Task<Speaker> GetSpeaker(string speakerName)
        {
            var api = new RestApi("https://www.orlandocodecamp.com/api/");
            var speaker = await api.Get<Speaker>("speaker", new QueryParam("speakerName", speakerName));
            return speaker;
        }
    }
}