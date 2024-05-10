namespace HomeWorks.JeffersonCoronel.May.Seventh.PracticeInClass-Poppets
{
    interface IActions {
        void Move();
        void Communicate();
        void Eat();
        void Drink();
    }

    class Mute : IActions {
        public void Move() {
            Console.WriteLine("The mute moves onto the stage by walking.");
        }

        public void Communicate() {
            Console.WriteLine("And communicates through gestures and raises his hand to say 'hello how are you?'");
        }

        public void Eat() {
            Console.WriteLine("And begins to eat his salad with a fork.");
        }

        public void Drink() {
            Console.WriteLine("And drinks his soda using a straw.");
        }
    }

    class Lame : IActions {
        public void Move() {
            Console.WriteLine("The lame moves onto the stage through a wheelchair.");
        }

        public void Communicate() {
            Console.WriteLine("And communicates by speaking and says 'hello how are you?'");
        }

        public void Eat() {
            Console.WriteLine("And begins to eat his soup with a spoon.");
        }

        public void Drink() {
            Console.WriteLine("And drinks his soda using a glass.");
        }
    }

    class Performance {
        private IActions actions;

        public Performance(IActions actions) {
            this.actions = actions;
        }

        public void InitPerformance() {
            actions.Move();
            actions.Communicate();
            actions.Eat();
            actions.Drink();
        }
    }

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("-- The Lame's Act: ");
            Console.WriteLine();
            Performance lameAct = new Performance(new Lame());
            lameAct.InitPerformance();
            Console.WriteLine();
            Console.WriteLine("-- The Mute's Act: ");
            Console.WriteLine();
            Performance muteAct = new Performance(new Mute());
            muteAct.InitPerformance();
        }
    }
}
