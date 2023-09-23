using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var familyInfoArray = new[]
        {
           
            new FamilyInfoModel { Name = "Gilbert Llamas Sr.", FamilyId = "77-1217", FamilyAge = "45", FamilyBirthday = "December 13, 1977"},
            new FamilyInfoModel { Name = "Leyneth Llamas", FamilyId = "77-0827", FamilyAge = "46", FamilyBirthday = "August 27, 1977" },
            new FamilyInfoModel { Name = "Glenn Llamas", FamilyId = "97-1018", FamilyAge = "25", FamilyBirthday = "October 18, 1997" },
            new FamilyInfoModel { Name = "Gilbert Llamas", FamilyId = "98-1217", FamilyAge = "24", FamilyBirthday = "December 12, 1998" },
            new FamilyInfoModel { Name = "John Paul Llamas", FamilyId = "21-2163", FamilyAge = "22", FamilyBirthday = "December 08, 2000"},
            new FamilyInfoModel { Name = "Jessica Llamas", FamilyId = "05-0624", FamilyAge = "46", FamilyBirthday = "June 24, 2005" },
            new FamilyInfoModel { Name = "John Gabriel Llamas", FamilyId = "10-0724", FamilyAge = "46", FamilyBirthday = "July 24, 2010" },
            new FamilyInfoModel { Name = "Angelica Mae Llamas", FamilyId = "18-0323", FamilyAge = "46", FamilyBirthday = "March 23, 2018" },
        };

        return View(familyInfoArray);
    }
}
