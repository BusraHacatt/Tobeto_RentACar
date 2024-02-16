namespace Business.Request.Model
{
    public class GetModelListRequest
    {
        //filtreleme
        public int? FilterByBrandId { get; set; }
        public int? FilterByFuelId { get; set; }
        public int? FilterByTransmissionId { get; set; }
    }
}