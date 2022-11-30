class BaseClass
{
    int x;
    float y;

    public void Method()
    {

    }
    public virtual void VMethod()
    {

    }
    
}

class Subclass : BaseClass
{

}

interface IInterface
{

}

class InterfaceImplementationClass
{
    
}

abstract class AbstractClass
{
    public int a;
    public abstract void AMethod();
}

class ImplementationClass : AbstractClass
{
    public override void AMethod()
    {
        
    }
}