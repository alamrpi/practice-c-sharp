using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1008
{
    public class Car
    {
        public static string ManufacturedBy;
        public string _shopName;
        public string brandName;
        private string model;

        public Car() {
            _shopName = "Abdullah Motors";
        }
        public Car(string brandName, string model)
        {
            this.brandName = brandName;
            this.model = model;
        }

        public Car(string shopName, string brandName, string model):this(brandName, model)
        {
            this._shopName = shopName;
        }

        static Car()
        {
            ManufacturedBy = "Japan";
        }
    }
}
