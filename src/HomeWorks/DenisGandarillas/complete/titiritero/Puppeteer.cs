namespace _titiritero
{

    public class Puppeteer
    {

        private IPuppet? _puppet;

        public void SetPuppet(IPuppet puppet)
        {
            _puppet = puppet;
        }

        public void HandlePuppet()
        {
            _puppet?.Move();
            _puppet?.Speak();
        }

    }

}
