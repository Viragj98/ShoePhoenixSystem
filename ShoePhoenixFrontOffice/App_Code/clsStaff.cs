using System;


public class clsStaff
{
    public int StaffID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string PostCode { get; set; }
    public string ContactNo { get; set; }
    public string City { get; set; }
    public string Title { get; set; }
    public string Gender { get; set; }
    public DateTime StartDate { get; set; }
    public Boolean EmployeeStatus { get; set; }

    public bool Find(int staffID)
    {
        // find should return true
        return true;
    }

    public string Valid(string title, string firstName, string lastName, string gender, string emailAddress, string contactNo, string address1, string address2, string postCode, string city, string startDate)
    {
        throw new NotImplementedException();
    }
}