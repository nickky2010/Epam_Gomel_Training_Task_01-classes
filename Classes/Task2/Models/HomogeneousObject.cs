namespace Task2.Models
{
    class HomogeneousObject
    {
        public string Name { get; set; }
        public PhysicalMaterial PhysicalMaterial { get; set; }
        public double Volume { get; set; }
        public HomogeneousObject(string name, PhysicalMaterial physicalMaterial, double volume)
        {
            Name = name;
            PhysicalMaterial = physicalMaterial;
            Volume = volume;
        }
        public HomogeneousObject()
        {
            Name = null;
            PhysicalMaterial = null;
            Volume = 0;
        }

        public double GetMass()
        {
            return (PhysicalMaterial.Density * Volume);
        }
        public override string ToString()
        {
            return (Name+";"+PhysicalMaterial+";"+Volume+";"+GetMass());
        }
    }
}
