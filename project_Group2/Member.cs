namespace project_Group2
{
     public class Member 
     {
         public int ID;
         public string Name;
         public int[] BorrowedBooks;
         public int BorrowCount ;
         public Member(int id , string name)
         {
             ID= id ;
            Name = name ;
            BorrowedBooks = new int[10];
            borrowedCount = 0;
         }
          public override string ToString()
         {
              return $"ID: {ID}, Name: {Name}, Borrowed Books: {BorrowedCount}";
              
         }
         public void MeBorrowBook(int id)
         {
             
             if (BorrowedCount<BorrowedBooks.Length)
             {
                 BorrowedBooks[borrowedCount]=ID ;
                 borrowedCount++;
             }
         }
          public void RetReturnBook(int BookId) 
          {
              int index = -1;
              for(int i= 0; i < BorrowedCount; i++)
              {
                  if (BorrowedBooks[i] ==BookId)
                  {
                      index = i ;
                      break;
                  }
  
              }
              if(index!=-1)
              {
                  for(int i =(int i = index; i < BorrowedCount - 1; i++)
                  {
                       BorrowedBooks[i] = BorrowedBooks[i+1] ;
                  }
                  BorrowedCount--;    
              }
              
          }
         
         
     }
   
}
