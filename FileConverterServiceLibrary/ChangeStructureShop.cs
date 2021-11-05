using System;
using System.Linq;
using FileConverterServiceLibrary.Clothes;

namespace FileConverterServiceLibrary
{
    public static class ChangeStructureShop
    {
        public static Shop ChangeForJson(Shop shop)
        {
            Shop newShop = new Shop();
            newShop.Categories = new Category[3];
            for (int i = 0; i < newShop.Categories.Length; i++)
            {
                newShop.Categories[i] = new Category();
            }
            newShop.Categories[0].CategoryId = 0;
            newShop.Categories[0].NameCategory = "cost less than 2000";
            newShop.Categories[1].CategoryId = 1;
            newShop.Categories[1].NameCategory = "cost between 2000 and 3000";
            newShop.Categories[2].CategoryId = 2;
            newShop.Categories[2].NameCategory = "cost more than 3000";
            foreach (var t in newShop.Categories)
            {
                t.Clotheses = new Clothes.Clothes[0];
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
            Shop newShop = new Shop();
            newShop.Categories = new Category[]
            {
                new() { NameCategory = "T_shirt", CategoryId = 0 },
                new() { NameCategory = "Sweatshirt", CategoryId = 1 },
                new() { NameCategory = "Pant", CategoryId = 2 }, new() { NameCategory = "Short", CategoryId = 3 },
                new() { NameCategory = "Shirt", CategoryId = 4 }, new() { NameCategory = "Polo", CategoryId = 5 }
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
