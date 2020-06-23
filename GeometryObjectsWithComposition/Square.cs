using System;
using System.Collections.Generic;
using System.Text;

using Windows.Foundation;

namespace GeometryObjectsWithComposition {

    public class Square {

        private Rectangle rect;

        public void Perimeter() {
            rect.Perimeter();
        }

        public void Area() {
            rect.Area();
        }

        public Square(int s) {
            rect = new Rectangle(s, s);
        }
    }
}
