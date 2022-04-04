using System;
using System.Collections.Generic;
using System.Text;

namespace _123
{
    abstract class Rasteniya // абстрактный класс растения
    {
        public abstract void ShowDerevo(); // абстрактный метод, вывод
        public abstract double ShowBuy(); // абстрактный метод, предназначенный для покупки необходимого дерева
        public abstract void ShowLife(); // абстрактный метод, отображающий благоприятность среды для дерева

    }
    class Trees : Rasteniya // базовый класс tress(деревья) на основе абстрактного класса растения
    {
        public string result;   // поле, возвращающее результат, каккое дерево хочет купить // какое хочет продать
        public string sreda; // поле, необходимое для ответа пользователя (используется в методе ShowLife)
        public int obsheeder; // целочисленное поле, которое содержит в себе число с актуальным количеством на складе в базовом классе - деревьев, а в производном - сосен


        public override void ShowDerevo() // переопределенный метод, выводящий какое дерево было приобретено
        {

            Console.WriteLine("Какое дерево хотите приобрести?");
            result = Console.ReadLine();
            Console.WriteLine("Теперь у вас есть - " + result + "Поздравляем с приобретением!!!");
        }
        public override void ShowLife() // метод, определяющий благоприятность проживания дерева (если дерево получает солнце, то благоприятно, иначе неблагоприятно)
        {

            
            Console.WriteLine("\nОпределяем благоприятность среди проживания ваших деревьев");
            Console.WriteLine("Скажите, есть ли доступ к солнцу у вашего дерева?");
            Console.WriteLine("Ответ - да или нет");
            sreda = Convert.ToString(Console.ReadLine());
            if (sreda == "Да" || sreda == "да" || sreda == "дА" || sreda == "ДА")
            {
                Console.WriteLine("Отлично. Среда благоприятная для дерева");
            }
            else if (sreda == "Нет" || sreda == "НЕТ" || sreda == "НеТ" || sreda == "нЕт" || sreda == "нет")
            {
                Console.WriteLine("Очень плохо. Посоветуем пересадить ваше дерево на видное солнце место, иначе оно умрет");
            }
            else
            {
                Console.WriteLine("Мы не понимаем вас, повторите еще раз");
            }
            
        }

        public override double ShowBuy() // переопределенный метод возвращающий результат. 
            // высчитывает текущее количество на складе. и смотрит желаемая покупка (переменная buy) больше текущего, выводит соответствущее сообщение
            // иначе из общего количество выводится желаемое для покупки. после выводится остаток на складе и количество приобретенного
        {        
            Console.WriteLine("Всего на складе" + obsheeder + " деревьев");
            Console.WriteLine("Сколько деревьев вы хотите приобрести?");
            int BUY = Convert.ToInt32(Console.ReadLine());
            if (BUY > obsheeder)
            {
                Console.WriteLine("Извините, мы не можем предоставить столько деревьев");
                Console.WriteLine("Актуальное количество указано ниже");
                return BUY;

                
            }
            else
            {
                return obsheeder -= BUY;
                Console.WriteLine("Вы купили - " + BUY);
                Console.WriteLine("На складе осталось " + obsheeder);
            }

           

        }

    }
    class Sosna : Trees
{
        public override double ShowBuy() // переопредееленный метод, 
        {

            Console.WriteLine("\nВсего на складе " + obsheeder + " сосен");
            Console.WriteLine("Сколько сосен вы хотите приобрести?");
            int BUY = Convert.ToInt32(Console.ReadLine());
            if (BUY > obsheeder)
            {
                Console.WriteLine("Извините, мы не можем предоставить столько сосен");
                Console.WriteLine("Актуальное количество указано - " +obsheeder);
                return BUY;


            }
            else
            {
                
                Console.WriteLine("Вы купили - " + BUY + "сосен");
                obsheeder -= BUY;
                Console.WriteLine("На складе осталось " +obsheeder);
                return obsheeder;

            }
        }
            
        new public void ShowDerevo()
        {


            Console.WriteLine("\nКакое дерево вы хотите продать?");
            result = Console.ReadLine();
            Console.WriteLine("Очень жаль расставаться с " + result + ". Мы будем ухаживать за ним. Не волнуйтесь.");
        }
        public void ShowKolvoMest()
        {
            int mesto;
            double obsheuchastok;
            int tekush;
            Console.WriteLine("\nНа участке предусмотрено 50 мест для деревьев");
            obsheuchastok = 50;
            tekush = 29;
            Console.WriteLine("Сколько дерьвеев вы хотите посадить?");
            mesto = Convert.ToInt32(Console.ReadLine());
            if (mesto + tekush > obsheuchastok)
            {
                Console.WriteLine("На данный момент, участок заполнен");

            }
            else
            {
                Console.WriteLine("Участок свободен. Можете заниматься рассадой");
            }




        }

    }
}
