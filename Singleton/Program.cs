using SingletonPattern;

Singleton _SingletonIns01 = Singleton.GetInstance();
_SingletonIns01.SomeMethod();
Singleton _SingletonIns02 = Singleton.GetInstance();

if (_SingletonIns01 == _SingletonIns02)
{
    Console.WriteLine("Both instances are the same. Singleton pattern is working.");
}
else
{
    Console.WriteLine("Singleton pattern failed.");
}