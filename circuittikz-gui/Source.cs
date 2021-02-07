using System.Drawing;

namespace circuittikz_gui
{
    public class Source : CircuitElement
    {
        public Source(Point startCoords, Point endCoords, string voltage, string type, string unit = "", bool reversed = false) : base(startCoords, endCoords)
        {
            S = new Quantity(type, voltage, unit);
            if (reversed)
                S.reverse();
        }
        public Quantity S { get; }
        public override string getTeX()
        {
            return S.reversed ? $"\\draw({endCoords.X},{endCoords.Y})to[{S.type}={S.value}{getOptArgs()}]({startCoords.X},{startCoords.Y});":
                $"\\draw({startCoords.X},{startCoords.Y})to[V={S.value}{getOptArgs()}]({endCoords.X},{endCoords.Y});";
        }
        public override string getDebugInfo()
        {
            return $"{S.type}={S.value}\nReversed={S.reversed}\n" + base.getDebugInfo();
        }
    }
}
