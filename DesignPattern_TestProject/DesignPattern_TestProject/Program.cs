namespace DesignPattern_TestProject 
{
    #region Strategy Design Pattern
    public interface VehicalFeature
    {
        void drive();
    }
    public class Sports : VehicalFeature
    {
        void VehicalFeature.drive()
        {
            Console.WriteLine("Sports Car");
        }
    }
    public class Normal : VehicalFeature
    {
        void VehicalFeature.drive()
        {
            Console.WriteLine("Normal Car");
        }
    }
    public class Vehical
    {
        VehicalFeature vehicalFeature;
        public Vehical(VehicalFeature vehicalFeature)
        {
            this.vehicalFeature = vehicalFeature;
        }
        public void Drive()
        {
            vehicalFeature.drive();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehical v1 = new Vehical(new Sports());
            Vehical v2 = new Vehical(new Normal());
            v1.Drive();
            v2.Drive();
        }
    } 
    #endregion
}