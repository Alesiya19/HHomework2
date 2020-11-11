using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.animal
{
   abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Vid { get; set; }
        public string Сapability { get; set; }
        public Animal(string name, int age, string vid, string capability)
        {
            Name = name;
            Age = age;
            Vid = vid;
            Сapability = capability;
        }
        public override string ToString()
        {
            return String.Format($"{"Вид: "}{Vid} {", Имя: "} { Name}{", Возраст: "} { Age}{", Способности: "} {Сapability}");
        }
    }
}
