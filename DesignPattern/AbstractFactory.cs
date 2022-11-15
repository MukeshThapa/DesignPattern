using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class AbstractFactory
    {
        //It is a Creational Design Pattern which solves problem while creating the objects.
        //It provides a factory and using the factory we request another factory to create the related objects instead of individual creating

        public AbstractFactory()
        {
            Console.WriteLine("Creating Tesla objects");

            VehicleComany tesla = new TeslaCompany();
            IBike teslabike =  tesla.GetBike();
            Icar teslaCar = tesla.GetIcar();

            //teslaCar.Manufacture();

            Console.WriteLine("Creating Tata objects");

            VehicleComany tata = new TataCompany();
            IBike tatabike = tata.GetBike();
            Icar tatacar = tata.GetIcar();

            Console.ReadLine();
        }



    }

    public abstract class VehicleComany
    {
        public abstract Icar GetIcar();
        public abstract IBike GetBike();

    }

    public class TeslaCompany : VehicleComany
    {
        public override IBike GetBike()
        {
            return new TeslaBike();
        }

        public override Icar GetIcar()
        {
            return new TeslaCar();
        }
    }



    public class TataCompany : VehicleComany
    {
        public override IBike GetBike()
        {
            return new TataBike();
        }

        public override Icar GetIcar()
        {
            return new TataCar();
        }
    }



    public class TataCar : Icar
    {
        public void Manufacture() {

            Console.WriteLine("TataCar");
        }
     }

    public class TataBike : IBike
    {
        public void Manufacture() {
            Console.WriteLine("Tata Bike");
        }
    }

    public class TeslaCar : Icar
    {
        public void Manufacture() {
            Console.WriteLine("Tesla Car");
        }
    }

    public class TeslaBike : IBike
    {
        public void Manufacture() {

            Console.WriteLine("Tesla Car");
        }
    }


    public interface Icar {
     // public void  Manufacture();

    }
    public interface IBike { }

}
