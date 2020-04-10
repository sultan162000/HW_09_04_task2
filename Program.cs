using System;

namespace HW_09_04_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player mp = new Player();
            mp.Play();
            mp.stop();

        }
    }
    interface IPlayable{
        void Play();
        void pause();
        void stop();
    }
    interface IRecodable{
        void Record();
        void Pause();
        void Stop();

    }

    class Player : IPlayable, IRecodable{
        public void Play(){
            System.Console.WriteLine("Запуск музыки...");
        }
        
        public void pause(){
            System.Console.WriteLine("Пауза музыки");
        }
        public void stop(){
            System.Console.WriteLine("Стоп музыки");
        }
        public void Record(){
            System.Console.WriteLine("Запись звука");
        }
        public void Pause(){
            System.Console.WriteLine("Пауза записа");
        }
        public void Stop(){
            System.Console.WriteLine("Стоп записа");
        }


    }
}
