namespace MyCompany.MyGarage.Models
{
    public class Moped : VehicleBase
    {
        /// <summary>
        /// Gets the vehicle type
        /// </summary>
        public override VehicleType Type
        {
            get { return VehicleType.TwoWheel; }
        }
    }
}
