using Amazon.DynamoDBv2.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiClase.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    public static List<Productos> listap = new List<Productos>();



    [HttpGet("[Action]")]
    public List<Productos> Get()
    {
        return listap;
    }

    [HttpPost("[Action]")]
    public void add(Productos producto)
    {
       listap.Add(producto);    
    }

}

public class Productos
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } = string.Empty;

  
}
