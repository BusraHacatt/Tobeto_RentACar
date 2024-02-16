namespace Business.Request.Car
{
    public class UpdateCarRequest
    {
        public UpdateCarRequest(int colorId, int modelId, string carState, int kilometer, string plate, int ıd)
        {
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            Plate = plate;
            Id = ıd;
        }
        public int Id { get; set; }
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string CarState { get; set; }
        public int Kilometer { get; set; }
        public string Plate { get; set; }
    }
}