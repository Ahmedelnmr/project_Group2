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
