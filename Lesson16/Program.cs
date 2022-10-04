using System;

namespace Lesson16
{
    class Program
    {

        public static int _value;
        public static int _valueProp { get; set; }

        static void Main(string[] args)
        {
            CommonBow _bow = new CommonBow();
            Console.WriteLine(BaseWeapon.GetNameLastObject());

            Axe _axe = new Axe();
            Console.WriteLine(BaseWeapon.GetNameLastObject());
            
            var r = CommonBow.GetName();

            _value = 10;
            _valueProp = 5;
        }
    }
}
