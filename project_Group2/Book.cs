namespace project_Group2
{
    public class Book
    {
        private int Id;
        private string Title;
        private string Author;
        private bool IsAvailable = true;
        public Book(int id, string title, string author)
            {
                Id = id;
                Title = title;
                Author = author;
            }
        public override string ToString()
            {
                return $" the id of Book is:{Id} and his title :{Title} and his author{Author} ";
            }
    }
}
