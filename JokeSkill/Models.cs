namespace JokeSkill
{
    class IcndbResponse<T>
    {
        public string Type { get; set; }

        public T Value { get; set; }
    }

    class JokeItem
    {
        public int Id { get; set; }

        public string Joke { get; set; }

        public string[] Categories { get; set;}
    }    
}