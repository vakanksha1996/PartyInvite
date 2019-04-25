using System;

public class Class1
{

    int a;
	public Class1(int a)
	{
   
    
        Console.WriteLine("base class consturctor"+a);
    }

	

}
class B : Class1
{
    int b;
    public B(int b){

    Console.WriteLine("derived class constructor"+b);
}
}

public class main
{
    static void Main()
    {
        B b = new B(5);
    }
}