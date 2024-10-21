namespace Encapsulatıon
{
    public class Car
    {
        public Car(string brand, string model, string colour, int numberofDoors)
        {
            Brand = brand;
            Model = model;
            Colour = colour;
            NumberofDoors = numberofDoors;
        }
        public void DisplayCarInfo()
        {
            Console.WriteLine("Marka: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Renk: " + Colour);
            Console.WriteLine("Kapı Sayısı:" + NumberofDoors);
        }

        private string _brand;
        private string _model;
        private string _colour;
        private int _NumberofDoors;

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public string Colour
        {
            get
            {
                return _colour;
            }
            set
            {
                _colour = value;
            }
        }
        public int NumberofDoors
        {
            get
            {
                return _NumberofDoors;

            }
            set
            {
                if (value == 2 || value == 4)
                {

                    _NumberofDoors = value;

                }
                else
                {
                    Console.WriteLine($"Hatalı bir giriş yaptınız.Kapı sayısı sadece 2 veya 4 olabilir.Girilen değer:{value}");
                    _NumberofDoors = -1;
                }


            }
        }
    }

}
