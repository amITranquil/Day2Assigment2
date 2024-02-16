

IPersonManager customerManager = new CustomerManager();
customerManager.Add();

IPersonManager employeeManager = new EmployeeManager();
employeeManager.Update();

ProjectManager projectManager = new ProjectManager();
projectManager.Add(new InternManager());

interface IPersonManager
{
    void Add();
    void Update();
   // void Remove();
}

class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Müşteri Ekledin!");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri Güncelledin!");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Personel Ekledin!");
    }

    public void Update()
    {
        Console.WriteLine("Personel Güncelledin!");
    }


}
class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer Ekledin!");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer Güncelledin!");
    }
}
class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}