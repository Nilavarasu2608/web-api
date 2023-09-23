
using web_api.models;

namespace web_api.Data_Transfer_Objects_DTO
{
    public class AddCharacterDto
    {
        public String? Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intellignece { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}