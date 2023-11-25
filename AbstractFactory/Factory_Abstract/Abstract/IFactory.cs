using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Factory_Abstract
{
    public interface IFactory
    {
        IAnimal Creative_Animal();
        IFood GetFood();
        IToy GetToy();

    }
}
