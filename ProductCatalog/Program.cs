using System;

Product[] p = new Product[3]
{
    new Electronics("노트북", 1500000, 24),
    new Clothing("청바지", 89000, "M"),
    new Food("우유", 3500, "2026-06-15")
};

Console.WriteLine("=== 상품 카탈로그 ===");
foreach(Product product in p)
{
    Console.WriteLine(product);
    Console.WriteLine(product.GetDescription());
}
