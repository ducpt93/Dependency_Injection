# Depnedency Injection

DI is a technique in which an object recives other objects that it depends on via using Abstraction(Inject)

Using this technique helps to reduce the dependent between objects

DI is one form of Inverion of control pattern (Depedency inversion Priciple)

HOW MANY WAYS TO INJECT A OBJECT TO ANOTHER OBJECTS?

1. Throught CONTRUCTOER Injection
   	 Public LapTop(ICpu cpu)
   	 {
		Cpu = cpu;
   	 }
2. Property Injecttion
   	 private ICpu  _cpu
    	public ICpu Cpu
   	{
     	  get {return _cpu;}
       	set {_cpu = value;}
    	}
3. Method Injection
	Public ICpu Cpu {get; private set;}
 	Public void SetDI(ICpu cpu)
	{
	   Cpu = cpu;




}

# DI Container(IoC)


# Advantages
-Reduce the dependent between modules
-The code is easy to maintain, easy to replace the module
-It's easy to test and write Unit Test
-Easily see the relationships between modules (Since dependencies are all injected into the constructor)

# Disadvantages
-The DI concept is quite "undigested", new developers will have difficulty learning
-Using the interface can sometimes be difficult to debug, as it is not known exactly which module is called
-Objects are all initialized, which can reduce performance
-Increased code complexity