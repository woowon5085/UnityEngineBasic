using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace 키워드
// 특정 이름으로 접근 

namespace ClassObjectInstance
{
    internal class Orc
    {
  
        public string Name;
        public int Age;
        public double Height;
        public double Weight;
        public char Gender; 

        public void SayMyName()
        {
            Console.WriteLine($"내 이름은 {Name}\n");
        }

        public void SayMyInfo()
        {
            Console.WriteLine("이름 : " + Name);
            Console.WriteLine($"나이 : {Age}세");
            Console.WriteLine("키 : " + Height);
            Console.WriteLine("몸무게 : " + Weight);
            Console.WriteLine("성별 : " + Gender);
            Console.WriteLine();
        }            
    }
}
