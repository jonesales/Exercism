using System;
using System.Collections.Generic;
using System.Linq;

public enum Allergen
{
    Eggs = 1,   
    Peanuts = 2,   
    Shellfish = 4,   
    Strawberries = 8,   
    Tomatoes = 16,  
    Chocolate = 32,  
    Pollen = 64,  
    Cats = 128  
}

public class Allergies
{
    private readonly int score;
    public Allergies(int mask)
    {
        score = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return List().Contains(allergen);
    }

    public Allergen[] List()
    {
        List<Allergen> allergens = new List<Allergen>();
        foreach (var item in Enum.GetValues(typeof(Allergen)))
        {
            if ((score & (int)item) > 0)
            {
                allergens.Add((Allergen)item);
            }
        }
        return allergens.ToArray();
    }
}