using System.Text.RegularExpressions;

namespace App19._11.Entities
{
    internal class City
    {
        public string cityName {  get; set; }
        public string countryName { get; set; }
        public int population { get; set; }
        public string phoneCode { get; set; }
        public string districts { get; set; }

        public City()
        {
            cityName = "";
            countryName = "";
            population = 0;
            phoneCode = "";
            districts = "";
        }

        public string Print()
        {
            return $"Місто: {cityName}\nКраїна: {countryName}\nНаселення: {population}\nКод телефона: {phoneCode}\n Район: {districts}";
        }

    }
}
