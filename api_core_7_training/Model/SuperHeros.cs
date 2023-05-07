namespace api_core_7_training.Model
{
    public class SuperHeros
    {
        public Guid ID { get; private set; }
        public string Name { get; private set; }
        public string Vehicle { get; private set; }
        public string Address { get; private set; }

        public SuperHeros(string name, string vehicle, string address)
        {
            ID = Guid.NewGuid();
            Name = name;
            Vehicle = vehicle;
            Address = address;
        }
    }
}
