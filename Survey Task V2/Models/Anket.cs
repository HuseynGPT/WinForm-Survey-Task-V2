namespace Survey_Task_V2.Models;

public class Anket
{
    public Anket(string name, string surname, string email, string phoneNumber, DateTime birthDate)
    {
        this.name = name;
        this.surname = surname;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.birthDate = birthDate;
    }

    public string name { get; set; }
    public string surname  { get; set; }
    public string email { get; set; }
    public string phoneNumber { get; set; }
    public DateTime birthDate { get; set; }

    public override string ToString()
    {
        return $"Name: {name}\nSurname: {surname}\nEmail: {email}\nPhone Number: {phoneNumber}\nBirthdate: {birthDate.ToShortDateString()}";
    }


}
