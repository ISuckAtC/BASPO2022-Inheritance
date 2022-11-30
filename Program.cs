class Program
{
    public static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();

        animals.Add(new Cat("red", 22, "Charlie", "plain"));
        animals.Add(new PetCat("brown", 10, "Tobias", "striped", "Sara"));
        animals.Add(new PetCat("black", 10, "Tracey", "striped", "Sara"));
        animals.Add(new PetCat("blue", 10, "Timian", "striped", "Sara"));
        animals.Add(new PetCat("yellow", 10, "Brutus", "striped", "Julius"));
        animals.Add(new PetCat("green", 10, "Tarromin", "striped", "Julius"));
        animals.Add(new Animal("blue", 461676, "SmurfDad"));


        animals.Add(animals.First(x => x.name == "Timian").ProduceOffspring("Timianson"));
        
        foreach (Animal a in animals) a.Bathe();


        Animal animal = new Cat("brown", 21, "Fuzzy", "zebra");
        animal.Bathe();
    }
}