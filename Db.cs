public record Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class PizzaDB
{
    private static List<Pizza> m_Pizzas = new List<Pizza>()
    {
        new Pizza { Id = 1, Name = "Montemagno, Pizza shaped like a great mountain" },
        new Pizza { Id = 2, Name = "The Galloway, Pizza shaped like a submarine, silent but deadly" },
        new Pizza { Id = 3, Name = "The Noring, Pizza shaped like a Viking helmet, where's the mead" },
    };

    public static List<Pizza> GetPizzas()
    {
        return m_Pizzas;
    }

    public static Pizza? GetPizza(int i_Id)
    {
        return m_Pizzas.SingleOrDefault(pizza => pizza.Id == i_Id);
    }

    public static Pizza CreatePizza(Pizza i_Pizza)
    {
        m_Pizzas.Add(i_Pizza);

        return i_Pizza;
    }

    public static Pizza UpdatePizza(Pizza i_NewPizza)
    {
        Pizza existingPizza = m_Pizzas.FirstOrDefault(pizza => pizza.Id == i_NewPizza.Id);
        
        if (existingPizza != null)
        {
            existingPizza.Name = i_NewPizza.Name;
        }

        return existingPizza;
    }

    public static void RemovePizza(int i_Id)
    {
        Pizza pizzaToRemove = m_Pizzas.FirstOrDefault(pizza => pizza.Id == i_Id);

        if (pizzaToRemove != null)
        {
            m_Pizzas.Remove(pizzaToRemove);
        }
    }
}