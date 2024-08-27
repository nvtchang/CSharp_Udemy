var medicalAppointment = new MedicalAppointment("John Smith", new DateTime(2023, 3, 4));

//simply reschedule
medicalAppointment.Reschedule(new DateTime(2023, 7, 5));


class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine(
            "Appointment will take place on" + medicalAppointment.GetDate());
    }
}
class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        patientName = patientName;
        _date = date;
    }

    public DateTime GetDate() => _date;

    //public MedicalAppointment(string patientName)
    //{
    //    _patientName = patientName;
    //    _date = DateTime.Now.AddDays(7);
    //} ugly code

    //public MedicalAppointment(string patientName) : this(patientName, 7)
    //{
        
    //}

    //optional parameter
    public MedicalAppointment(string patientName, int daysFromNow = 7)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    public void Reschedule(DateTime date)
    {
        _date = date;
        //After reschedule, we want to print data
        var printer = new MedicalAppointmentPrinter();
        printer.Print(this);
    }

    public void Reschedule(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    //public void Reschedule(int monthsToAdd, int daysToAdd)
    //{
    //    _date = new DateTime(_date.Year, 
    //        _date.Month + monthsToAdd, 
    //        _date.Day + daysToAdd);
    //}

}