namespace project_Group2
{
    public class Library
    {
        Book[] books;
        int books_count;
        Member[] members;
        int members_count;
        public Library()
        {
            books = new Book[20];
            members = new Member[20];
            books_count = 0;
            members_count = 0;
        }
//-------------AddBook------------------//
         public void AddBook(Book book)
             {
                  
                 if (books_count >= books.Length)
                 {
                     Console.WriteLine("your library is full of books");
                 }
               
                 else
                 {
                     if (books_count != 0)
                     {
                         for (int i = 0; i < books_count; i++)
                         {
                             if (books[i].Equals(book))
                             {
                                 Console.WriteLine("the id of book should be unique");
                                 return;
                             }
                         }
                     }
                     books[books_count] = book;
                     Console.WriteLine("Book added sucessfully");
                     books_count++;
            
                 }
             }
//-------------RemoveBook------------------//
             public void RemoveBook(int id)
             {
                 int index = FindBooks(id);
                 if (index == -1)
                 {
                     Console.WriteLine("the book is not found");
            
                 }
                 else
                 {
                     if (!books[index].IsAvailable)
                     {
                         Console.WriteLine("The book is borrowed ");
                         return;
            
                     }
                     books[index] = books[books_count-1];
                     books[books_count-1] = null;
                     books_count--;
                     Console.WriteLine("Book deleted sucessfully");
            
                 }
            
             }
//-----------------FindBooks---------------------//
         public int FindBooks(int id)
         {
             for (int i = 0; i < books_count; i++)
             {
                 if (books[i].Id ==id)
                 {
                     return i;
                 }
        
             }
             return -1;
        
        
         }
                // Add Member
        public void AddMember(Member member)
        {
            if (members_count >= members.Length)
            {
                Console.WriteLine("your library is full of members");
            }
            else
            {
                members[members_count] = member;
                Console.WriteLine("member added successfully");
                members_count++;
            }
        }
    }
}
