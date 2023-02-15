using Newtonsoft.Json;
using System.Runtime.CompilerServices;

UsingEnumerations();
UsingAStruct();

void UsingAStruct()
{
    Employee employee;
    employee.Name = "Bethany";
    employee.Wage = 1250;
    employee.Work();
}

Console.ReadLine();

static void UsingEnumerations()
{
    EmployeeType employeeType = EmployeeType.Manager;
    StoreType storeType = StoreType.Seating;
    int baseWage = 1000;

    CalculateWage(baseWage, employeeType, storeType);
}

static void CalculateWage(int baseWage, EmployeeType employeeType, StoreType storeType)
{
    int calculatedWage = 0;

    if (employeeType == EmployeeType.Manager)
    {
        calculatedWage = baseWage * 3;
    }
    else 
    {
        calculatedWage *= 2;
    }
    if (storeType == StoreType.FullPieRestaurant)
    {
        calculatedWage += 500;
    }
    Console.WriteLine($"The calculated wage is {calculatedWage}");
}

struct Employee
{
    public string Name;
    public int Wage;

    public void Work()
    {
        Console.WriteLine($"{Name} is now doing work!");
    }
}
enum EmployeeType
{
    Sales,
    Manager,
    Research,
    StoreManager,
}
enum StoreType
{
    PieCorner = 10,
    Seating = 20,
    FullPieRestaurant = 100,
    Undefined = 99
}