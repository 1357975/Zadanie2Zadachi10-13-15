internal class Program
{
    static void Main(string[] args)
    {
    
        void Zadacha10()
        {
              
            //int number = 456; //456;782;918 вывести десятки трехзначного числа
            Random rand = new Random();
            int number = rand.Next(100,1000);
            Console.WriteLine("Случайное число = " + number);
            int tens;
            tens = (number - (number / 100)*100)/10;
            Console.WriteLine("Вторая цифра = " + tens);
       
        }
        Zadacha10();

        void Zadacha13()
        {
            int number = 645; //645;78;32679 вывести 3-ю цифру или написать, что ее нет
            Console.WriteLine("number = " + number);
            if (number>99)
            {
                while (number>1000)
                {
                    number/=10;
                    //Console.WriteLine(number);
                }
                Console.WriteLine("третья цифра числа = " + number%10);
            }
            else Console.WriteLine("Третьей цифры нет");
                        
        }
        //Zadacha13();

        void Zadacha15()
        {
            //ввести цифру дня недели (6, 7, 1) и проверить является ли он выходным
            Console.WriteLine("Введите цифру дня недели от 1 до 7");
            int number=Convert.ToInt32(Console.ReadLine());
            if (number>=1 && number<=7)
            {
                if (number == 1)
                {
                   Console.WriteLine("1 - это понедельник и не является выходным"); 
                } 
                else if (number == 2)
                {
                   Console.WriteLine("2 - это вторник и не является выходным"); 
                }
                else if (number == 3)
                {
                   Console.WriteLine("3 - это среда и не является выходным"); 
                }
                else if (number == 4)
                {
                   Console.WriteLine("4 - это четверг и не является выходным"); 
                }
                else if (number == 5)
                {
                   Console.WriteLine("5 - это пятница и не является выходным"); 
                }
                else if (number == 6)
                {
                   Console.WriteLine("6 - это суббота и является выходным"); 
                }
                else if (number == 7)
                {
                   Console.WriteLine("7 - это воскресенье и является выходным"); 
                }
            }
            else Console.WriteLine("Цифра не является днем недели");
        }
        //Zadacha15();

    }
}