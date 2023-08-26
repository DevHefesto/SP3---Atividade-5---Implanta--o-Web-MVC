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
        // Instâncias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Pedro Macedo", "242.160.770-13", "grisha3348@uorak.com", "Doralice");
        Cliente cliente2 = new Cliente(02, "Lorenzo Macedo", "385.383.400-00", "lorenzo_macedo@gmail.com", "Max");
        Cliente cliente3 = new Cliente(03, "Vicente Carvalho", "663.314.380-09", "vicente_carvalho@hotmail.com", "Hefesto");
        Cliente cliente4 = new Cliente(04, "Aline Barros", "370.101.010-27", "aline_barros@outlook.com", "Harry");
        Cliente cliente5 = new Cliente(05, "Lívia Saraiva", "294.281.150-10", "lívia_saraiva@protonmail.com", "Bob");

        // Lista de Clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        // Instâncias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "racao Animal", "61.701.467/0001-53", "luizabatista44@bol.com.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "Pelos & Pets racao", "70.052.312/0001-24", "alciabraga.souza65@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "gato Fiel Amigo", "59.700.129/0001-55", "jliocsarbarros59@yahoo.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "cachorro Casa dos Pets", "34.503.190/0001-81", "joaquimpereira_carvalho@live.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "papagaio Pet Care", "12.130.265/0001-93", "cecliaalbuquerque.melo@gmail.com");

        // Lista de Fornecedores e atribui os fornecedores
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
