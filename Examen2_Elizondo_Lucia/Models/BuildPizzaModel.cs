using System.Collections.Generic;


namespace Examen2_Elizondo_Lucia.Models
{
    public class BuildPizzaModel
    {

        string Size { get; set; }

        string Sauce { get; set; }

        string Cheese { get; set; }

        List<string> Ingredients { get; set; }
    }
}