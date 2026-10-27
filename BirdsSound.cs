class Birds
{
    string name;
    public Birds(string name)
    {
        this.name = name;
        Console.WriteLine("Birds - Constructor");
        Console.WriteLine("Bird Name: " + name);
    }

    public void make_sound()
    {
        Console.WriteLine("Bird makes sound");
    }
}

class Parrot : Birds
{
    public Parrot(string name) : base(name)
    {
        Console.WriteLine("Parrot - Constructor");
        Console.WriteLine("Parrot Name: " + name);
    }

    public void make_sound()
    {
        base.make_sound();
        Console.WriteLine("ParrotParrot!!");
    }
}

class Sparrow : Birds
{
    public Sparrow(string name) : base(name)
    {
        Console.WriteLine("Sparrow - Constructor");
        Console.WriteLine("Sparrow Name: " + name);
    }

    public void make_sound()
    {
        base.make_sound();
        Console.WriteLine("SparrowSparrow!!");
    }
}

class BirdsSound
{
    public static void Main(string[] args)
    {
        Parrot obj = new Parrot("Parakeet");
        Sparrow obj2 = new Sparrow("Cuckoo");
        obj.make_sound();
    }
}