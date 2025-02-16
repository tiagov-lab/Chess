using Chess;

namespace ChessTests;

[TestClass]
public class CoordinateTests
{
    [TestMethod]
    public void Test_ChessCoordinate_BottomLeftSquareIsA1()
    {
        // Arrange
        var TestCoordinate = new Coordinate(1,1);
        var CorrectName = "a1";

        // Act
        var InputName = TestCoordinate.name;

        // Assert
        Assert.AreEqual(CorrectName, InputName);
    }

    [TestMethod]
    public void Test_ChessCoordinate_BottomRightSquareIsH1()
    {
        // Arrange
        var TestCoordinate = new Coordinate(8, 1);
        var CorrectName = "h1";

        // Act
        var InputName = TestCoordinate.name;

        // Assert
        Assert.AreEqual(CorrectName, InputName);
    }

    [TestMethod]
    public void Test_ChessCoordinate_UpperLeftSquareIsA8()
    {
        // Arrange
        var TestCoordinate = new Coordinate(1,8);
        string CorrectName = "a8";

        // Act
        var InputName = TestCoordinate.name;

        // Assert
        Assert.AreEqual(CorrectName, InputName);
    }

    [TestMethod]
    public void Test_ChessCoordinate_UpperRightSquareIsH8()
    {
        // Arrange
        var TestCoordinate = new Coordinate(8,8);
        var CorrectName = "h8";

        // Act
        var InputName = TestCoordinate.name;

        // Assert
        Assert.AreEqual(CorrectName, InputName);
    }
}
