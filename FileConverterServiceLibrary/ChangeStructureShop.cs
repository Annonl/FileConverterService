using System;
using System.Linq;
using FileConverterServiceLibrary.Clothes;

namespace FileConverterServiceLibrary
{
    public static class ChangeStructureShop
    {
        public static Shop ChangeForJson(Shop shop)
        {
            var newShop = new Shop
            {
                Categories = new Category[]
                {
                    new() { CategoryId = 0, NameCategory = "cost less than 2000" },
                    new() { CategoryId = 1, NameCategory = "cost between 2000 and 3000" },
                    new() { CategoryId = 3, NameCategory = "cost more than 3000" }
                }
            };
            foreach (var category in newShop.Categories)
            {
                category.Clotheses = Array.Empty<Clothes.Clothes>();
            }
            foreach (var shopCategory in shop.Categories)
            {
                foreach (var shopCategoryClothese in shopCategory.Clotheses)
                {
                    switch (shopCategoryClothese.Cost)
                    {
                        case < 2000:
                            newShop.Categories[0].Clotheses = newShop.Categories[0].Clotheses.Concat(new[] { shopCategoryClothese }).ToArray();
                            break;
                        case >= 2000 and < 3000:
                            newShop.Categories[1].Clotheses = newShop.Categories[1].Clotheses.Concat(new[] { shopCategoryClothese }).ToArray();
                            break;
                        case >= 3000:
                            newShop.Categories[2].Clotheses = newShop.Categories[2].Clotheses.Concat(new[] { shopCategoryClothese }).ToArray();
                            break;
                    }
                }
            }
            return newShop;
        }
        public static Shop ChangeForXml(Shop shop)
        {
            var newShop = new Shop
            {
                Categories = new Category[]
                {
                    new() { NameCategory = "T_shirt", CategoryId = 0 },
                    new() { NameCategory = "Sweatshirt", CategoryId = 1 },
                    new() { NameCategory = "Pant", CategoryId = 2 }, new() { NameCategory = "Short", CategoryId = 3 },
                    new() { NameCategory = "Shirt", CategoryId = 4 }, new() { NameCategory = "Polo", CategoryId = 5 }
                }
            };
            foreach (var newShopCategory in newShop.Categories)
            {
                newShopCategory.Clotheses = Array.Empty<Clothes.Clothes>();
            }
            foreach (var shopCategory in shop.Categories)
            {
                foreach (var shopCategoryClothese in shopCategory.Clotheses)
                {
                    if (shopCategoryClothese.GetType() == typeof(T_shirt))
                        newShop.Categories[0].Clotheses = newShop.Categories[0].Clotheses
                            .Concat(new []{ shopCategoryClothese }).ToArray();
                    else if (shopCategoryClothese.GetType() == typeof(Sweatshirt))
                        newShop.Categories[1].Clotheses = newShop.Categories[1].Clotheses
                            .Concat(new[] { shopCategoryClothese }).ToArray();
                    else if (shopCategoryClothese.GetType() == typeof(Pant))
                        newShop.Categories[2].Clotheses = newShop.Categories[2].Clotheses
                            .Concat(new[] { shopCategoryClothese }).ToArray();
                    else if (shopCategoryClothese.GetType() == typeof(Short))
                        newShop.Categories[3].Clotheses = newShop.Categories[3].Clotheses
                            .Concat(new[] { shopCategoryClothese }).ToArray();
                    else if (shopCategoryClothese.GetType() == typeof(Shirt))
                        newShop.Categories[4].Clotheses = newShop.Categories[4].Clotheses
                            .Concat(new[] { shopCategoryClothese }).ToArray();
                    else if (shopCategoryClothese.GetType() == typeof(Polo))
                        newShop.Categories[5].Clotheses = newShop.Categories[5].Clotheses
                            .Concat(new[] { shopCategoryClothese }).ToArray();
                }
            }
            return newShop;
        }
    }
}
