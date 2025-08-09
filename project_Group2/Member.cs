namespace project_Group2
{
    public class Member
    {
        public int Id;
        public string Name;
        public int[] borrowed_books;
        public int count;
        public Member(int id, string name)
        {
            Id = id;
            Name = name;
            borrowed_books = new int[5] ;
            count = 0;
        }
        
        public override string ToString()
        {
            return $"ID : {Id} Name is : {Name} borrowed_books : {count}";
        }
    }
}
