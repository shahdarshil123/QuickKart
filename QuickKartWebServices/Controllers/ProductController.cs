using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuickKartDataAccessLayer;
using QuickKartDataAccessLayer.Models;
using QuickKartWebServices.Models;

[Route("api/product")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly QuickKartRepository _repository;
    private readonly IMapper _mapper;
    public ProductController(QuickKartRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet]
    public JsonResult GetProducts()
    {
        List<Product> products = new List<Product>();
        try
        {
            // Fetch data from the repository
            List<Products> productList = _repository.GetProducts();
            //Console.WriteLine($"Number of products fetched: {productList.Count}");

            // Map to API model using AutoMapper
            products = _mapper.Map<List<Product>>(productList);
        }
        catch (Exception ex)
        {
            // Log the exception (optional)
            Console.WriteLine($"Error: {ex.Message}");
            products = null;
        }
        return new JsonResult(products);
    }

    [HttpGet("{id}", Name = "Get")]
    public JsonResult GetProduct(string productId)
    {
        Product product = null;
        try
        {
            product = _mapper.Map<Product>(_repository.GetProductDetails(productId));
        }
        catch (Exception ex)
        {
            product = null;
        }
        return new JsonResult(product);
    }

}