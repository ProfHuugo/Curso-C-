namespace Course.Entities
{
    class Comment
    {
        public string Text { get; set; } = string.Empty;

        public Comment()
        {

        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}