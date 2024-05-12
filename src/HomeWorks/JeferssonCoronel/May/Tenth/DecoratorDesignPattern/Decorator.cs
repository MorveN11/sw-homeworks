namespace HomeWorks.JeferssonCoronel.May.Tenth.DecoratorDesignPattern
{
    public abstract class WindowComponent(string description)
    {
        protected string _description = description;

        public virtual string DisplayWindow()
        {
            return _description;
        }

        public abstract double GetCost();
    }

    public class PlainWindow() : WindowComponent("Plain Window")
    {
        public override double GetCost()
        {
            return 100.0;
        }
    }

    public abstract class WindowDecoratorBase(WindowComponent decoratedWindow, string description)
        : WindowComponent(description)
    {
        protected WindowComponent _decoratedWindow = decoratedWindow;

        public override string DisplayWindow()
        {
            return _decoratedWindow.DisplayWindow() + ", " + _description;
        }
    }

    public class WindowWithScrollbar(WindowComponent decoratedWindow)
        : WindowDecoratorBase(decoratedWindow, "Scrollbar")
    {
        public override double GetCost()
        {
            return _decoratedWindow.GetCost() + 20.0;
        }
    }

    public class WindowWithBorder(WindowComponent decoratedWindow) : WindowDecoratorBase(decoratedWindow, "Border")
    {
        public override double GetCost()
        {
            return _decoratedWindow.GetCost() + 15.0;
        }
    }

    public class WindowWithShadow(WindowComponent decoratedWindow) : WindowDecoratorBase(decoratedWindow, "Shadow")
    {
        public override double GetCost()
        {
            return _decoratedWindow.GetCost() + 25.0;
        }
    }

    internal static class Program
    {
        static void Main(string[] args)
        {
            WindowComponent plainWindow = new PlainWindow();
            Console.WriteLine(plainWindow.DisplayWindow() + " - Cost: $" + plainWindow.GetCost());

            WindowComponent windowWithScrollbar = new WindowWithScrollbar(plainWindow);
            Console.WriteLine(windowWithScrollbar.DisplayWindow() + " - Cost: $" + windowWithScrollbar.GetCost());

            WindowComponent windowWithBorderAndShadow = new WindowWithBorder(new WindowWithShadow(plainWindow));
            Console.WriteLine(windowWithBorderAndShadow.DisplayWindow() + " - Cost: $" + windowWithBorderAndShadow.GetCost());
        }
    }
}

