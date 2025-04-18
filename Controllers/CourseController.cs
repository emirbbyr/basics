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
    kurs.Image="1.jpg";
    return View(kurs);  //kurs objesini view üzerinde görüntülemek için parantez içine yazdık.
   
}
public IActionResult List()
{
    var kurslar = new List<Course>()
    {
        new Course () {Id=1, Title ="aspnet kursu", Description="Güzel bir krs",Image="1.jpg"},
         new Course () {Id=2, Title ="php kursu", Description="Güzel bir krs",Image="1.jpg"},
          new Course () {Id=3, Title ="djngo kursu", Description="Güzel bir krs",Image="1.jpg"},
    };
     return View(kurslar);   
}

}