using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Name"] = "Arciaga, Lloyd Nathaniel T.";
        ViewData["Introduction"] = "I am a dedicated college student navigating the vast world of technology. " +
            "While I might describe myself as having an average aptitude for coding and " +
            "analytical thinking, I make up for it with a strong passion for " +
            "problem-solving, continuous learning, and hands-on development. " +
            "I am constantly working to expand my skill set by transforming complex " +
            "ideas into functional applications, turning academic concepts into " +
            "real-world solutions, and continuously challenging myself to learn new " +
            "technologies. " +
            "" +
            "Welcome to my portfolio, where I share my journey, personal growth, and " +
            "the projects I have created along the way. I hope my work reflects not " +
            "only what I have learned, but also my commitment to becoming a better developer every day.";

        return View();
    }

    public IActionResult About()
    {
        ViewData["AboutMe"] = "Hi, I'm Arciaga, Lloyd Nathaniel T., " + 
            "a 21-year-old college student who appreciates the simple things in life, including a classic color palette " + 
            "of grey and black. My educational journey has been a unique adventure, " +
            "beginning with my graduation from Tunasan Annex High School and I also have a " +
            "2 years maritime experience. " +
            "" +
            "As time went on, I discovered that my true passion lies in technology. " +
            "This realization led me to the Lyceum of Alabang, where I am currently " +
            "pursuing a Bachelor's degree in Information Technology. My diverse " +
            "educational background has shaped my adaptability, broadened my " +
            "perspective, and strengthened my determination to succeed in the " +
            "ever-evolving field of technology." +
            "" +
            "Outside of academics, I enjoy spending my free time listening to music, " +
            "playing video games, and coding. These hobbies allow me to unwind while " +
            "continuously developing my creativity, analytical thinking, and " +
            "problem-solving abilities." +
            "" +
            "Looking ahead, my goal is to begin my career as an IT Support Specialist, " +
            "where I can build a strong technical foundation, gain valuable " +
            "real-world experience, and continue learning. With dedication and " +
            "perseverance, I aspire to grow into more advanced technical roles and " +
            "contribute meaningfully to the ever-changing world of information " +
            "technology.";

        return View();
    }

    public IActionResult Skills()
    {
        return View();
    }

    public IActionResult Projects()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}