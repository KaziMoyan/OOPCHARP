using System;

class Person {
    private string name;
    private int age;

    // Property for 'name'
    public string Name {
        get { return name; }
        set {
            if (value.Length == 2) {
                name = value;
            } else {
                Console.WriteLine("Name must be exactly 2 characters long.");
            }
        }
    }

    // Property for 'age'
    public int Age {
        get { return age +3; }
        set {
            if (value > 17) {
                age = value;
            } else {
                Console.WriteLine("Age must be greater than 17.");
            }
        }
    }
}

class Test {
    public static void Main(string[] args) {
        Person p1 = new Person();
        
        // Attempting to set name and age
        p1.Name = "M";   // This will trigger the validation and not set the name
        p1.Age = 25;     // This will set the age

        // Display the current values
        Console.WriteLine($"Name={p1.Name}, Age={p1.Age}");

        // Creating a new Person object and setting values
        Person p2 = new Person();
        p2.Name = "AP";  // This will set the name because it has exactly 2 characters
        p2.Age = 20;     // This will set the age

        // Display the current values
        Console.WriteLine($"Name={p2.Name}, Age={p2.Age}");
    }
}
