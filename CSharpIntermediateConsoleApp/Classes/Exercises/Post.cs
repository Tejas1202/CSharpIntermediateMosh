using System;

namespace CSharpIntermediateConsoleApp.Classes.Exercises
{
    class Post
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime AskedOn { get; }
        public int Votes { get; private set; }

        public Post(string title, string description)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
                throw new ArgumentNullException("title or description cannot be null or empty or whitespace");

            this.Title = title;
            this.Description = description;
            AskedOn = DateTime.Now;
        }

        public void UpVote()
        {
            Votes ++;
        }

        public void DownVote()
        {
            Votes --;
        }

    }
}
