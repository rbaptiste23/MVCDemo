namespace MVCDemo2
{
    public interface IVehicle
    {
        string Color { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        int Year { get; set; }

        string Break();
        string Drive();
    }
}