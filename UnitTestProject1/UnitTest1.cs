﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpBombDefuser;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Form1 f = new Form1();

        [TestMethod]
        public void TestDangerWire()
        {
            //Start test numbers outside desired range
            int testMin = 10, testMax = 0;
            int numberOfItterations = 1000;
            //make a list to hold DangerWire outputs,  
            List<int> listOfBadWires = new List<int>();
            Wires newWires = new Wires();
            //put n itterations into array,
            for (int i = 0; i < numberOfItterations; i++)
            {
                int thisBadWire = newWires.RandomiseDangerWire();
                listOfBadWires.Add(thisBadWire);

                testMax = listOfBadWires.Max();
                testMin = listOfBadWires.Min();
            }
            //test array max and min
            Assert.AreEqual(1, testMin, "1");
            Assert.AreEqual(6, testMax, "6");
        }

        [TestMethod]
        public void TestCutWire()
        {

            Wires newWires = new Wires();
            Button fakeButton = new Button();
            int buttonNumber = newWires.RandomiseDangerWire();
            
            //test that image starts as null
            Assert.IsTrue(fakeButton.Image==null);
            //call the tested method
            Wires.CutWire(fakeButton,buttonNumber-1);
            //test that image has been changed
            Assert.IsTrue(fakeButton.Image != null);
        }
    }
}
