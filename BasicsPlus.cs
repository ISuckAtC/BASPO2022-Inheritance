class Animal
{
    protected string color;
    protected int age;
    public string name;
    protected Animal? parent;

    public Animal(string color, int age, string name)
    {
        this.color = color;
        this.age = age;
        this.name = name;
    }

    public virtual Animal ProduceOffspring(string name)
    {
        Animal child = new Animal(color, 0, name);
        child.parent = this;
        return child;
    }
    public virtual void Bathe()
    {
        Console.WriteLine(name + " is now all clean!");
    }
}

class Cat : Animal
{
    protected string pattern;
    public Cat(string color, int age, string name, string pattern) : base(color, age, name)
    {
        this.pattern = pattern;
    }

    public override void Bathe()
    {
        Console.WriteLine(name + " fights back viciously!");
        base.Bathe();
    }
    public override Animal ProduceOffspring(string name)
    {
        return new Cat(color, 0, name, pattern);
    }
}

interface IOwned
{
    string Owner {get;}
    void ChangeOwner(string owner);
}

class PetCat : Cat, IOwned
{
    private string owner;

    public PetCat(string color, int age, string name, string pattern, string owner) : base(color, age, name, pattern)
    {
        this.owner = owner;
    }

    public string Owner {get {return owner;}}

    public void ChangeOwner(string owner)
    {
        this.owner = owner;
    }
    public void ChangePattern(string pattern)
    {
        this.pattern = pattern;
    }

    public void DumpInfo()
    {
        Console.WriteLine(name + " is a cat, its fur is " + color + " and the pattern is " + pattern + ". It's owned by " + owner + (parent == null ? " and it has no parent" : (" and it's parent is " + parent.name)));
    }
}


// This one is borrowed from https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract 
abstract class Shape
{
    public abstract float GetArea();
    public abstract float GetCircumference();

}

class Circle : Shape
{
    public override float GetArea()
    {
        throw new NotImplementedException();
    }

    public override float GetCircumference()
    {
        throw new NotImplementedException();
    }
}

class Rectangle : Shape
{
    public override float GetArea()
    {
        throw new NotImplementedException();
    }

    public override float GetCircumference()
    {
        throw new NotImplementedException();
    }
}