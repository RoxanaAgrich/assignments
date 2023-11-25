using builder;

//IPizzaBuilder builder = new PizzaBuilder();
var director = new PizzaDirector(new PizzaBuilder());
var pizza = director.GetPizzaChilli();// Pizza
Console.WriteLine($"pizza size = {pizza.Size}"+ $"pizza perperoi = {pizza.Perperoni}");