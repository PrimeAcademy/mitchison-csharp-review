// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int age = 44;
float price = 1.99F;
char letter = 'a';
string name = "Kris";

// built-in arrays
int[] numberArray = {1, 2, -4, 3};

string[] stringArray = {"Mitchison", "Ramirez"};
Console.WriteLine("here is my array" + numberArray);

// loops
foreach(string cohort in stringArray) {
    Console.WriteLine(cohort);
}

// .NET gives us a List
// Function/DataType <data type>
List<string> shoeList = new List<string>();
shoeList.Add("Nike");
shoeList.Add("Keds");
shoeList.Add("Crocs");
shoeList.Add("New Balance");
// shoeList[2];

Console.WriteLine(shoeList);
foreach(string shoe in shoeList) {
    Console.WriteLine(shoe);
    // expressions
}

// make instances of markers (variables)
// new creates an instance of a class
Marker redMarker = new Marker();
// redMarker.color = "Red";
redMarker.changeColor("Red"); // .color is private!
Console.WriteLine(redMarker.getColor());


// classes and objects
public class Marker 
{
    
    // properties/fields
    public string material;
    private string color {get; set;}
    public int inkLevel = 100;

    // methods/functions
    // allows us to change a private property
    // setter
    public void changeColor(string newColor) {
        if(newColor != null) {
            this.color = newColor;
        }
    }

    // getter
    public string getColor() {
        return this.color;
    }

} // end class

