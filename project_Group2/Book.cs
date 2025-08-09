namespace project_Group2
{
    public class Book
    {
        public  int Id;
        public string Title;
        public string Author;
        public bool IsAvailable = true;
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
          public override bool Equals(object? obj)
          {
              if (obj is Book b)
              {
                  return this.Id == b.Id;
              }
              return false;
          }
    }
}
