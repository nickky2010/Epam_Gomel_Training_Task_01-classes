namespace Task2.Models
{
    class PhysicalMaterial
    {
        public string Name { get; set ; }
        public double Density { get; set ; }
        public PhysicalMaterial()
        {
            Name = null;
            Density = 0;
        }
        public PhysicalMaterial(string name, double density)
        {
            Name = name;
            Density = density;
        }
        public override string ToString()
        {
            return (Name+";"+Density);
        }
    }
}
