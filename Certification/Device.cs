using System.ComponentModel.Design;

namespace Certification
{
    public abstract class Device : System.Object

    {
        public Device(string name, string model)
        {
            this.Name = name;
            this.Model = model;
        }

        public string Name { get; private set; }
        public string Model { get; private set; }
    }
}