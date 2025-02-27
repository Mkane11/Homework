// written by Mamoutou kane
// date: 02/16/2025
using System;

class SimulasSoup
{
    enum SoupType { Soup, Stew, Gumbo }
    enum MainIngredient { Mushrooms, Chicken, Carrots, Potatoes }
    enum Seasoning { Spicy, Salty, Sweet }

    static void Main()
    {
        (SoupType type, MainIngredient ingredient, Seasoning seasoning) soup;

        soup.type = GetEnumValue<SoupType>("Enter soup type (Soup, Stew, Gumbo): ");
        soup.ingredient = GetEnumValue<MainIngredient>("Enter main ingredient (Mushrooms, Chicken, Carrots, Potatoes): ");
        soup.seasoning = GetEnumValue<Seasoning>("Enter seasoning (Spicy, Salty, Sweet): ");

        Console.WriteLine($"\nSimula is preparing: {soup.seasoning} {soup.ingredient} {soup.type}");
    }

    static T GetEnumValue<T>(string prompt) where T : struct, Enum
    {
        T result;
        do
        {
            Console.Write(prompt);
        } while (!Enum.TryParse(Console.ReadLine(), true, out result));
        return result;
    }
}
