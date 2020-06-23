using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryObjectsWithComposition {
    
    public class Rectangle {

        private Quadrillateral quad = new Quadrillateral();

        public void Perimeter() {
            quad.Perimeter();
        }

        public void Area() {
            Console.WriteLine($"{quad.Type}: area is {quad.Side1 * quad.Side2}");
        }

        public Rectangle(int s1, int s2) {
            quad.Side1 = s1;
            quad.Side3 = s1;
            quad.Side2 = s2;
            quad.Side4 = s2;
            quad.Type = "Rect";
        }
    }
}
