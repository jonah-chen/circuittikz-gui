using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circuittikz_gui
{
    public partial class CircuitTikzGUI : Form
    {


        public CircuitTikzGUI()
        {
            circuitElements = new List<CircuitElement>();
            liveElement = null;
            InitializeComponent();
        }
        private List<CircuitElement> circuitElements; // A list of all circuit elements that will be generated
        private CircuitElement liveElement;

        private void updateCode()
        {
            foreach (CircuitElement elem in circuitElements)
            {
                TeXCode.Text += elem.getTeX() + "\n";
            }
        }






        /* The image of the circuit
         * 1500 x 800 box
         * 
         */
        private void circuitClick(object sender, EventArgs e)
        {
            if (liveElement == null)
            {
                Console.WriteLine("Please select a valid circuit element to draw.");
                return;
            }

            MouseEventArgs me = (MouseEventArgs)e;
            Point coords = me.Location;
            MouseButtons click = me.Button;
            int x;
            int y;
            if (precisionMode.Checked)
            {
                x = coords.X * 30 / Display.Width;
                y = (Display.Height - coords.Y - 1) * 16 / Display.Height;
            }
            else
            {
                x = coords.X * 15 / Display.Width;
                y = (Display.Height - coords.Y - 1) * 8 / Display.Height;
            }

            if (click == MouseButtons.Left)
            {
                if (liveElement.startCoords == CircuitElement.NULL)
                    liveElement.startCoords = new Point(x, y);
                else
                {
                    liveElement.endCoords = new Point(x, y);
                    circuitElements.Add(liveElement);
                    liveElement.printDebugInfo();
                    liveElement = null;
                }
                Console.WriteLine(string.Format("[{2}]You have clicked coords: ({0}, {1})", x, y, DateTime.Now.ToString("hh:mm:ss.fff")));
            }
        }
        

        private void circuitHover(object sender, EventArgs e)
        {
            
        }

        private void printDebug(object sender, EventArgs e)
        {
            Console.WriteLine(precisionMode.Checked);
            updateCode();
            Console.WriteLine("Success");

        }

        private void TeXCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.V:
                    liveElement = new Source(CircuitElement.NULL, CircuitElement.NULL, ValueBox.Text, "V", UnitBox.Text, false);
                    break;
                default:
                    break;
            }
        }

        private void copyToClipboard(object sender, EventArgs e)
        {
            Clipboard.SetText(TeXCode.Text);
        }
    }
}
