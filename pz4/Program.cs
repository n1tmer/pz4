
public class Car
{
    private string Mark { get; set; } 
    private int Cilinder { get; set; }
    private int Power { get; set; }  
    public Car(string mark,int cilinder, int power)
    {
        Mark = mark;
        Cilinder = cilinder;
        Power = power;
    }

    

    public void Change(int power)
    {
       Power = power;
        
    }
    static void Main(string[] args)
    {
        Car[] cars = new Car[3];
        cars[0] = new Car("Toyota", 14, 20);
        cars[1] = new Car("Audi", 20, 30);
        cars[2] = new Car("eqwer", 15, 25);
        foreach (Car c in cars)
        {
            c.Change(51);
            
        }
        Console.Read();
        foreach (Lorry l in cars)
        {
            l.ChangeMark("qwer");
        }
    }
    class Lorry : Car
    {
        public Lorry(string mark, int cilinder, int power) : base(mark, cilinder, power)
        {
        }

        public void ChangeMark(string mark)
        {
            Mark = mark;
        }
    }



}

