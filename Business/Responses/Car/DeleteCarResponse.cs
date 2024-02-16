namespace Business.Responses.Car
{
    public class DeleteCarResponse
    {
        public DeleteCarResponse(int ıd, int colorId, int modelId, string carState, int kilometer, int modelYear, string plate, DateTime deletedAt)
        {
            Id = ıd;
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            ModelYear = modelYear;
            Plate = plate;
            DeletedAt = deletedAt;
        }

        public int Id { get; set; }
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string CarState { get; set; }
        public int Kilometer { get; set; }
        public int ModelYear { get; set; }
        public string Plate { get; set; }
        public DateTime DeletedAt { get; set; }
        public DeleteCarResponse()
        {

        }
    }
}
