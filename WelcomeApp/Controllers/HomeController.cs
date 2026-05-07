using WelcomeApp.Data; 

namespace WelcomeApp.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        bool isDbConnected = _context.Database.CanConnect();
        ViewBag.DbStatus = isDbConnected 
            ? "Kết nối SQL Server thành công!" 
            : "`Kết nối SQL Server thất bại. Hãy kiểm tra lại tên Server trong appsettings.json";
            
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}