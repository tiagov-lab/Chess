using Chess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTests
{
    [TestClass]
    public class CoordinateExtendTests
    {
        [TestMethod]
        public void OffsetTestX()
        {
            // Arrage
            var inputCoordinate = new Coordinate(1, 1);
            var sumCoordinate = new Coordinate(1, 2);
            var expectedCoordinate = new Coordinate(1, 3);

            // Act
            var resultCoordinate = CoordinateExtension.Offset(inputCoordinate, sumCoordinate);

            // Assert
            Assert.AreEqual(expectedCoordinate, resultCoordinate);
        }

        [TestMethod]
        public void OffsetTestY()
        {
            // Arrage
            var inputCoordinate = new Coordinate(1, 1);
            var sumCoordinate = new Coordinate(2, 1);
            var expectedCoordinate = new Coordinate(3, 1);

            // Act
            var resultCoordinate = CoordinateExtension.Offset(inputCoordinate, sumCoordinate);

            // Assert
            Assert.AreEqual(expectedCoordinate, resultCoordinate);
        }
    }
}
