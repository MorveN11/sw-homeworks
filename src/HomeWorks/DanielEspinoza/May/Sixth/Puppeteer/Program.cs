using System;
using System.Collections.Generic;

namespace Puppeteer
{

    public interface IPuppet{
        void Speak(string text);
        void Jump();
        void Run();
        void Crouch();
        void CastSpell();
    }

    public class Fluffy : IPuppet
    {
        public void Speak(string text)
        {
            Console.WriteLine($"{text},  he said in a soft and fluffy tone");
        }

        public void Jump()
        {
            Console.WriteLine("Fluffy bounces lightly, his fluffy arms waving");
        }

        public void Run()
        {
            Console.WriteLine("Fluffy skips joyfully, his fluffy legs moving swiftly");
        }

        public void Crouch()
        {
            Console.WriteLine("Fluffy bends down gracefully, his fluffy body swaying");
        }

        public void CastSpell()
        {
            Console.WriteLine("Fluffy waves his fluffy arms in a magical gesture");
        }
    }


   public class Rocky : IPuppet
    {
        public void Speak(string text)
        {
            Console.WriteLine($"{text},  he said with a rocky voice");
        }

        public void Jump()
        {
            Console.WriteLine("Rocky hops up and down on his sturdy feet");
        }

        public void Run()
        {
            Console.WriteLine("Rocky moves his arms and legs swiftly, pretending to run");
        }

        public void Crouch()
        {
            Console.WriteLine("Rocky bends his knees and lowers his body close to the ground");
        }

        public void CastSpell()
        {
            Console.WriteLine("Rocky gestures with his hands, mimicking a magical incantation");
        }
    }



    public class Puppeteer
    {

        private IPuppet? puppet;


        public void SetPuppet(IPuppet puppet)
        {
            this.puppet = puppet;
        }

        public void HandlePuppet()
        {
            if (puppet != null){
                puppet.Jump();
                puppet.Run();
                puppet.Crouch();
                puppet.CastSpell();
                puppet.Speak("Hello World!");
            }else{
                Console.WriteLine("No puppet set");
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {   Puppeteer puppeteer = new Puppeteer();

            puppeteer.SetPuppet(new Fluffy());
            puppeteer.HandlePuppet();

            puppeteer.SetPuppet(new Rocky());
            puppeteer.HandlePuppet();


        }
    }
}


