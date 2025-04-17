using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;
public class CourseController : Controller{

public IActionResult Index()
{
     var kurs =new Course();  //Course modelinin içindeki bilgileri doldur.
    kurs.Id=1;
    kurs.Title="Aspnet kursu";
    kurs.Description="Güzel bir kurs";
    return View(kurs);  //kurs objesini view üzerinde görüntülemek için parantez içine yazdık.
   
}
public IActionResult List()
{
    var kurslar = new List<Course>()
    {
        new Course () {Id=1, Title ="aspnet kursu", Description="Güzel bir krs"},
         new Course () {Id=2, Title ="php kursu", Description="Güzel bir krs"},
          new Course () {Id=3, Title ="djngo kursu", Description="Güzel bir krs"},
    };
     return View(kurslar);   
}

}