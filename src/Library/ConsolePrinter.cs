namespace Full_GRASP_And_SOLID.Library;

using System;

public static class ConsolePrinter
{
    // Por SRP la responsabilidad de imprimir debe estar en una clase apartada,
    // ya que la impresión puede cambiar por motivos externos a la estructura
    // de una receta.
    public static void PrintRecipe(Recipe recipe)
    {
        Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
        foreach (Step step in recipe.GetSteps())
        {
            Console.WriteLine(
                $"{step.Quantity} de '{step.Input.Description}' "
                    + $"usando '{step.Equipment.Description}' durante {step.Time}"
            );
        }
    }
}
