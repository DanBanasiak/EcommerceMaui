using Ecommerce.Models;

namespace Ecommerce.Data
{
    public static class ShoesData
    {
        public static List<Shoes> ShoesList => new()
        {
            new Shoes
            {
                Name = "Air Max 90",
                Brand = "Nike",
                Description = "The Nike Air Max 90 stays true to its OG roots with its iconic Waffle outsole, stitched overlays and classic, color-accented TPU plates. Retro colors celebrate the first generation while Max Air cushioning adds comfort to your journey.",
                Size = 40,
                Price = 120
            },
            new Shoes
            {
                Name = "Classic Leather",
                Brand = "Reebok",
                Description = "The Reebok Classic Leather is a timeless style that's perfect for casual wear. The soft leather upper provides a comfortable fit, while the die-cut EVA midsole cushions each step. The rubber outsole offers durability and traction.",
                Size = 45,
                Price = 75
            },
            new Shoes
            {
                Name = "Old Skool",
                Brand = "Vans",
                Description = "The Vans Old Skool is a classic skate shoe that's perfect for casual wear. The canvas and suede upper provides a comfortable fit, while the padded collar offers support and flexibility. The rubber outsole offers durability and traction.",
                Size = 8,
                Price = 60
            }
        };

    }
}
