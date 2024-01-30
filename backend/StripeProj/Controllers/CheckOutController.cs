using Microsoft.AspNetCore.Mvc;

namespace StripeProj.Controllers;

public class CheckOutController : Controller
{
  public IActionResult Index()
  {
    List<ProductEntity> productList = new List<ProductEntity>();

    productList = new List<ProductEntity>
    {
      new ProductEntity
      {
        productList="Tommy Hilfiger",
        Rate=1500,
        Quantity=2,
        ImagePath = "img/Image1.png"
      },
      new ProductEntity
       {
        productList="TimeWear",
        Rate=1000,
        Quantity=1,
        ImagePath = "img/Image2.png"
      }
    };
    return view(productList);
  }
}
