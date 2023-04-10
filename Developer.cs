 class Developer
    {
    public string Name;
    public string Surname;
    public int Age;
    public int Salary;
    public string Position;
    

    public void GetFullInfo()
    {
        Console.WriteLine($"{this.Name}, {this.Surname},{this.Age}, {this.Salary},{this.Position}");
    }



    public Developer(string Name, string Surname, int Age, int Salary, string Position)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
        this.Salary = Salary;
        this.Position = Position;

    }
    
    }


    

    