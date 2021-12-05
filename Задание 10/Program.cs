using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle(35,24,48);
            angle.ToRadians();
            
            Console.ReadKey();
        }

        class Angle
        {
            float gradus;
            float min;
            float sec;

            //Проверка крректности введных данных для градусов
            public float Gradus
            {
                
                set
                {
                    if (value > 0)
                    {
                        gradus = value;
                    }
                    else
                    {
                        Console.WriteLine("Угол не может быть отрицательным");
                    }

                }
                get
                {
                    return gradus;
                }
            }

            //Проверка крректности введных данных для минут
            public float Min
            {
                
                set
                {
                    if (value > 0 && value <60)
                    {
                        min = value;
                    }
                    else
                    {
                        Console.WriteLine("Количество минут в угле не может отрицательным или больше 60");
                    }

                }
                get
                {
                    return min;
                }
            }
            //Проверка крректности введных данных для секунд
            public float Sec
            {
                
                set
                {
                    if (value > 0 && value <60)
                    {
                        sec = value;
                    }
                    else
                    {
                        Console.WriteLine("Количество секунд в угле не может отрицательным или больше 60");
                    }

                }
                get
                {
                    return sec;
                }
            }

            public Angle(float gradus, float min, float sec)
            {
                Gradus = gradus;
                Min = min;
                Sec = sec;
            }
            public void ToRadians()
            {
                Console.Write("Исходный угол: ");
                Console.Write("{0} градусов ",Gradus);
                Console.Write("{0} минут ",Min);
                Console.WriteLine("{0} секунд ",Sec);
                double rad = ((Gradus * 3600 + Min * 60 + Sec) * Math.PI) / (180 * 3600);
                Console.WriteLine("Угол измеряемый в радианах равен: {0:F2} радиан.", rad);
            }


        }
    }
}
