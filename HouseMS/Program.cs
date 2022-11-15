using HouseMS.Models;
using HouseMS.Services;

class Result
{
    static void Main()
    {
        
        PersonServices personService = new PersonServices();
        DoorServices doorServices = new DoorServices();
        personService.Display();
        doorServices.Display();
    }
}