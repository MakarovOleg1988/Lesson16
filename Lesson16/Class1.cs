using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson16
{

    public class RareType
    {
        public void Choosetype()
        {
            Dictionary<int, string> _rareWeapon = new Dictionary<int, string>();
            _rareWeapon.Add(1, "Simple");
            _rareWeapon.Add(2, "Legendary");
        }
    }

    public class BaseWeapon : RareType
    {
        protected float _power;
        protected float _range;

        public BaseWeapon()
        {
            _self = this;
        }

        public static BaseWeapon _self;

        public static string GetNameLastObject()
        {
            return _self.GetType().Name;
        }

        static BaseWeapon()
        {
            Console.WriteLine("BaseWeapon");
        }
    }
    class CommonBow: BaseWeapon
    {
        public static string GetName()
        {
            return "Weapon";
        }

        static CommonBow()
        {
            Console.WriteLine("CommonBow");
        }
    }

    class Axe: BaseWeapon
    { 
    
    }
}
