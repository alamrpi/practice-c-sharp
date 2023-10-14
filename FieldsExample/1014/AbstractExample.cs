namespace FieldsExample._1014
{
    public class AbstractExample
    {
        private readonly IFlyingVehicle vehicle;

        public AbstractExample(IFlyingVehicle vehicle)
        {
            this.vehicle = vehicle;
        }
        public void Display()
        {
            var student = new Student();
            var car = new Car();
            vehicle.GetBrandName();
            vehicle.CountFan();
        }
    }
}
