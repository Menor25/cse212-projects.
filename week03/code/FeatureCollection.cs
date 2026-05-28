public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public string Type { get; set; }
    public List<FeatureCollection> Features { get; set; }

    public class Geometry
    {
        public string Type { get; set; }
        public List<double> Coordinates { get; set; }
    }

    public class Properties
    {
        public double Mag { get; set; }
        public string Place { get; set; }
    }
}