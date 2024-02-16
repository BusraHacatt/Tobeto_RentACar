namespace Business.Request.Fuel
{
    public class AddFuelRequest
    {
        public string Name { get; set; }
        public AddFuelRequest(string name)
        {
            Name = name;
        }
    }
}