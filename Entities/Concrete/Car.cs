using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Car : Entity<int>
    {
     
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string CarState { get; set; }
        public int Kilometer { get; set; }
        [Range(20, int.MaxValue, ErrorMessage = "Araba 20 yaşından fazla olamaz.")]
        public int ModelYear { get; set; }
        public string Plate { get; set; }
        public Car()
        {

        }

        public Car(int colorId, int modelId, string carState, int kilometer, int modelYear, string plate)
        {
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            ModelYear = modelYear;
            Plate = plate;
        }
    }
}