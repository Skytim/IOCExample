namespace IOCExample
{
    public class Mine
    {
        private readonly IAunt _aunt;
        public Mine(IAunt aunt)
        {
            _aunt = aunt;
        }

        public void Room()
        {
            _aunt.Swapping();
        }
    }
}