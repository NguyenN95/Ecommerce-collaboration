using Ecommerce.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.ShopProduct;

public class ProductsController : BaseApiController
{
    private readonly List<Product> ListProduct = new(){
         new Product{
            ID = 1,
            Name = "Shirt",
            Img = "https://www.mrporter.com/variants/images/3633577411310824/in/w2000_q60.jpg",
            Price = 50,
            QuantitySold = 5,
            Status = true
        },
        new Product{
            ID = 2,
            Name = "Pants",
            Img = "https://bizweb.dktcdn.net/100/438/408/files/cargo-pants-yodyvn.jpg?v=1670222023662",
            Price = 95,
            QuantitySold = 1,
            Status = true
        },
        new Product{
            ID = 3,
            Name = "Polo Shirt",
            Img = "https://oldsailor.com.vn/vnt_upload/product/10_2022/13c3a4af1039d7678e2816.jpg",
            Price = 70,
            QuantitySold = 1,
            Status = true
        },
        new Product{
            ID = 4,
            Name = "Jeans",
            Img = "https://www.arket.com/content/dam/P11/images/campaigns/2023/23109-arketjeans/fits/ARKETJEANS_W_CLOUD_WIDE_RIGID_SIZE_27_0081.jpg",
            Price = 120,
            QuantitySold = 1,
            Status = true
        },
        new Product{
            ID = 5,
            Name = "Shorts",
            Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSLoKmMwANH3Bj4VonduTxDRxdri5WVWGoLJr3e04vcOjJcs1npvBWTOR7nFhId_Okkzow&usqp=CAU",
            Price = 30,
            QuantitySold = 1,
            Status = true
        },
        new Product{
            ID = 6,
            Name = "Vest",
            Img = "https://www.anphuoc.com.vn/Data/Sites/1/Product/3777/vest-pie0192_1-2.jpg",
            Price = 250,
            QuantitySold = 1,
            Status = true
        },
    };

    [HttpGet]
    public IActionResult ShowAll()
    {
        return Ok(ListProduct);
    }
    [HttpGet("id")]
    public IActionResult GetByID(int id)
    {
        var product = ListProduct!.FirstOrDefault(x => x.ID == id);
        return Ok(product);
    }
    [HttpPost]
    public IActionResult Create(int id, string name, int price)
    {
        Product Product = new Product{
            ID = id,
            Name = name,
            Price = price,
            QuantitySold = 0,
            Status = true, 
        };
        ListProduct.Add(Product);
        return Ok(Product);
    }
    [HttpPut("id")]
    public IActionResult Edit(int id, string name, int price, bool status)
    {
        var product = ListProduct!.FirstOrDefault(x => x.ID == id);
        if(product != null)
        {
            product.Name = name;
            product.Price = price;
            product.Status = status;
        }
        else{
            return Ok("Product does not exist");
        }
        return Ok(product);
    }
}
