using System;
using System.Windows.Forms;

namespace CSharpBombDefuser

{



    public class Wires
    {

        //Int to hold danger wire ID number
        public int DangerWire { get; set; }

        //Array to hold "Cut"/"Uncut" markers for each wire
        public string[] CutWires = {"Uncut", "Uncut", "Uncut", "Uncut", "Uncut", "Uncut"};

        //method to return a randomised number used to set the Danger Wire
        public int RandomiseDangerWire()
        {
            Random wireChooser = new Random(Guid.NewGuid().GetHashCode());
            int badWire = wireChooser.Next(1, 7);
            //return 6;
            return badWire;
        }

        //Method to compare int values of wireNumber and DangerWire in sent Wires object
        public bool IsDangerWire(int wireNumber, Wires sender)
        {
            //make a fake Wires object to hold values
            Wires fakeWires = sender;
            //compare wireNumber(from button press) to Dangerwire value
            if (wireNumber == fakeWires.DangerWire)
            {
                return true;
            }
            return false;

        }

        //Method to set DangerWire for sending Wires object
        public Wires MakeDangerWire(Wires sender)
        {
            Wires fakeWires = sender;
            int dangerWire = RandomiseDangerWire();
            fakeWires.DangerWire = dangerWire;

            //foreach (Wires fakeWire in fakeWires)
            //    if (fakeWire.WireNumber == dangerWire)
            //    {
            //        fakeWire.IsDangerWire = true;
            //    }
            return fakeWires;
        }

        //Method called when a wire(button) is cut(clicked)
        public static void CutWire(object sender, int wire)
        {
            Button fakeButton = sender as Button;
            //change button#(wire) image to cut.
            fakeButton.Image = Properties.Resources.CutWire;

            //change wire tag to cut
            GameVariables.BombWires.CutWires[wire] = "Cut";

        }
    }
}
        