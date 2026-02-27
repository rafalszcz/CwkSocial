public class BasicInfo
{
    private BasicInfo() { }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string EmailAddress { get; private set; }
    public string Phone { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public string CurrentCity { get; private set; }

    public static BasicInfo Create(string firstName, string lastName, string email, DateTime dob, string phone = null, string currentCity = null)
    {
       

        return new BasicInfo
        {
            FirstName = firstName,
            LastName = lastName,
            EmailAddress = email,
            DateOfBirth = dob,
            Phone = phone,
            CurrentCity = currentCity
        };
    }
}