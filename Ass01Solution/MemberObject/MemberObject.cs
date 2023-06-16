namespace MemberObject
{
    public class MemberObject
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        // Constructors, additional properties, and methods

        public override string ToString()
        {
            return $"Member{{MemberID={MemberID}, MemberName='{MemberName}', Email='{Email}', Password='{Password}', City='{City}', Country='{Country}'}}";
        }
    }
}