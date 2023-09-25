
using CalendarApp.Entities;

Meeting meeting= new Meeting()
{
    Title = "Title", 
    Details = "Details",
    StartTime= DateTime.Now,
    EndTime= DateTime.Now,
    Guests = new() {"guest1" , "guest2" },
};

Todo Todo= new Todo() 
{ 
    Title= "Title",
    Details = "Details",
    StartTime= DateTime.Now,
    EndTime= DateTime.Now ,
    Importance="HIGH"
};