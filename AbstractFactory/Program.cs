using AbstractFactory.Factory_Abstract;

// IFactory product_1 = new FactoryDog();
IFactory product_1 = new Client(new FactoryCat());


