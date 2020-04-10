using System;

namespace HW_09_04_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player aimp = new Player();
            IPlayable music = aimp;
            IRecodable dict = aimp;
            aimp.Play();

        }
    }
    interface IPlayable{
        void Play();
        void Pause();
        void Stop();
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
        
        void IPlayable.Pause(){
            System.Console.WriteLine("Пауза музыки");
        }
        void IPlayable.Stop(){
            System.Console.WriteLine("Стоп музыки");
        }
        public void Record(){
            System.Console.WriteLine("Запись звука");
        }
        void IRecodable.Pause(){
            System.Console.WriteLine("Пауза записа");
        }
        void IRecodable.Stop(){
            System.Console.WriteLine("Стоп записа");
        }


    }
}
