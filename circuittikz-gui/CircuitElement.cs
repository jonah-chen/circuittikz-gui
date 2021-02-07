using System;
using System.Collections.Generic;
using System.Drawing;

namespace circuittikz_gui
{
    public struct Quantity
    {
        public Quantity(string type, string value, string unit)
        {
            this.reversed = false;
            this.type = type;
            if (unit.Length > 0)
                this.value = $"\\SI{{{value}}}{{{unit}}}";
            else
                this.value = $"${value}$";
        }
        public string type { get; } // the type of the optional argument (i.e. voltage, current)
        public string value { get; } // the value
        public bool reversed { get; set; } // if the direction is opposing the orientation of the circuit
        public void reverse() { reversed = !reversed; } // flips the quantity (i.e. current direction)

    }
    public abstract class CircuitElement
    {
        /* Types of inputs the user can provide */
        public const int INTEGER = 9543153;
        public const int DECIMAL = 3254364;
        public const int STRING = 46924513;
        public static Point NULL = new Point(-69, -69);
        public static Point ZERO = new Point(0, 0);

        /* Given a string provided by the user "value", check the type of the string */
        public static int checkType(string value)
        {
            int points = 0;
            foreach (char c in value)
            {
                if ((c == '.' && ++points > 1) || (c < '0' || c > '9'))
                    return STRING;
            }
            if (points == 1)
                return DECIMAL;
            return INTEGER;
        }
        public Point startCoords { get; set; } // the starting point of the circuit element
        public Point endCoords { get; set; } // the ending point of the circuit element
        public List<Quantity> Q { get; protected set; } // the auxiliary quantities for the circuit element
        public CircuitElement(Point startCoords, Point endCoords) // default constructor
        {
            this.startCoords = startCoords;
            this.endCoords = endCoords;
            Q = new List<Quantity>();
        }

        /* Takes an type and value entered by the user and appends as the right type to the quantities list */
        public void addQuantity(string type, string value, string unit) { Q.Add(new Quantity(type, value, unit)); }

        /* Retrieves the string with all the optional arguments */
        public string getOptArgs()
        {
            string optArgs = "";
            foreach (Quantity q in Q)
                optArgs += q.reversed ? $",{q.type}<={q.value}" : $",{q.type}>={q.value}";
            return optArgs;
        }

        /* Method to retrive the latex code to draw this element */
        public abstract string getTeX();

        /* Debug method to print info */
        public virtual string getDebugInfo()
        {
            string debugInfo = "AUX:\n";
            foreach (Quantity q in Q)
                debugInfo += $"{q.type}+{q.value}\n";
            return debugInfo;
        }

        /* Prints the debug info to the Console */
        public void printDebugInfo()
        {
            Console.WriteLine($"[{DateTime.Now:hh:mm:ss.fff}]{getDebugInfo()}");
        }
    }

    public class NullCircuit : CircuitElement
    {
        public NullCircuit() : base(CircuitElement.NULL, CircuitElement.NULL) { }
        public override string getTeX()
        {
            Console.WriteLine("Trying to get LaTeX code from nothing.");
            throw new NotImplementedException();
        }
    }
}
