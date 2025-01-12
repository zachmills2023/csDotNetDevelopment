// See https://aka.ms/new-console-template for more information

class Program
{
    public static string concat()
    {
        string name = "Zachariah Mills";
        string location = "Idaho";
        DateTime currentDate = DateTime.Now;

        string formattedDate = currentDate.ToString("MM/dd/yyyy");

        string interpolMessage = $"My name is {name} and I am living in {location} and today is {formattedDate}. Thanks.";

        return interpolMessage;
    }

    public static int christmasCountdown()
    {
        DateTime currentDate = DateTime.Now;
        DateTime christmasDate = new DateTime(currentDate.Year, 12, 25);
        TimeSpan daysDiff = christmasDate - currentDate;
        int days = daysDiff.Days;

        return days;
    }

    static void Main()
    {
        Console.WriteLine(concat());
        Console.WriteLine($"There are {christmasCountdown()} days left until Christmas!");

        double width, height, woodLength, glassArea;
        string widthString, heightString;

        // Provide appropriate text labels for input
        Console.WriteLine("Enter the width of the window:");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);

        Console.WriteLine("Enter the height of the window:");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " + woodLength + " feet");
        Console.WriteLine("The area of the glass is " + glassArea + " square metres");

        // Pause the console
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

