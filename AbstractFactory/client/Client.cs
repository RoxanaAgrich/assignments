using AbstractFactory.Factory_Abstract;
using AbstractFactory.Products.Abstract;
namespace AbstractFactory.client
{
    public class Client
    {
        private readonly IAnimal _animal;
        private readonly IFood _food;
        private readonly IToy _toy;
    public Client(IFactory get_information)
        {
            _animal = get_information.Creative_Animal();
            _food = get_information.GetFood();
            _toy = get_information.GetToy();
        }
    }
}
