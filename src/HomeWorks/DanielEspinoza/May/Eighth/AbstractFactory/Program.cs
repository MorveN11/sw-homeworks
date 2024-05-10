namespace AbstractFactory
{
       class Program {
        static void Main(){
            UIFactory factory = new MacUIFactory();

            Client client= new();

            client.createUI(factory);
        }


        class Client{
            public void createUI(UIFactory factory){
                ITextBox textBox = factory.CreateTextBox();
                textBox.OnWrite();
                IButton button = factory.CreateButton();
                button.OnClick();
            }
        }

        interface UIFactory {
            IButton CreateButton();
            ITextBox CreateTextBox();
        }


        class WindowsUIFactory : UIFactory {
            public IButton CreateButton() {
                return new WindowsButton();
            }
            public ITextBox CreateTextBox() {
                return new WindowsTextBox();
            }
        }


        class MacUIFactory : UIFactory {
            public IButton CreateButton() {
                return new MacButton();
            }
            public ITextBox CreateTextBox() {
                return new MacTextBox();
            }
        }

        interface IButton{
            void OnClick();
        }

        class WindowsButton : IButton
        {
            public void OnClick()
            {
                Console.WriteLine("Windows Button Clicked");
            }
        }

        class MacButton : IButton{
            public void OnClick()
            {
                Console.WriteLine("Mac Button Clicked");
            }
        }




        interface ITextBox{
            void OnWrite();
        }

        class WindowsTextBox : ITextBox{
            public void OnWrite(){
                Console.WriteLine("Windows TextBox Is Being Used");
            }
        }


        class MacTextBox : ITextBox{
            public void OnWrite(){
                Console.WriteLine("Mac TextBox Is Being Used");
            }
        }
    }

}
