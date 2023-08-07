using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
   private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

        public IActionResult Index()
    {
        // instancias do tipo clientes
        Cliente cliente1 = new Cliente(01, "juliana o. bairros", "857.032.950-41", "julianabairros49@gmail.com", "cissa");
        Cliente cliente2 = new Cliente(02, "jonas o. bairros", "039.618.250-09", "jonasbairros@gmail.com", "Bola");
        Cliente cliente3 = new Cliente(03, "Maria o. bairros", "800.777.920-50", "Mariabairro9@gmail.com", "Torrada");
        Cliente cliente4 = new Cliente(04, "jaqueline o. bairrosda silva", "933.622.400-03", "jaquelinebairros@gmail.com", "Cacau");
        Cliente cliente5 = new Cliente(05, "Tiago queirroz", "911.702.988-00", "Tiagoqueiroz@gmail.com", "Tuco");

        // lista de clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);     
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);   

            ViewBag.listaClientes = listaClientes;
            
            
            


        // instancias do tipo fornecedor e atribui os fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Bootspet INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");


        // lista de fornecedores                                       
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);  
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3); 
        listaFornecedores.Add(fornecedor4);   
        listaFornecedores.Add(fornecedor5); 

            ViewBag.listaFornecedores = listaFornecedores;

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
