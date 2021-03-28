using System;
namespace jokeApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public String jokeQuestion { get; set; }
        public String jokeAnswer { get; set; }
        public Joke()
        {
        }
    }
}
