using Xunit;

namespace Shapes.Tests
{
    public class ShapesTest
    {
        private Triangle _triangle;
        private Circle _circle;

        public ShapesTest()
        {
            _triangle = new Triangle(3, 4, 5);
            _circle = new Circle(1);
        }
        [Fact]
        public void Test()
        {
            ShapesScale shapesScale = new ShapesScale();
            Assert.Equal(Math.Sqrt(((3 + 4 + 5) / 2) * (((3 + 4 + 5) / 2) - 3) * (((3 + 4 + 5) / 2) - 4) * (((3 + 4 + 5) / 2) - 5)), shapesScale.GetScale(_triangle));
            Assert.Equal(Math.Sqrt(((3 + 4 + 5) / 2) * (((3 + 4 + 5) / 2) - 3) * (((3 + 4 + 5) / 2) - 4) * (((3 + 4 + 5) / 2) - 5)), _triangle.GetScale());
            Assert.Equal(Math.PI * 1 * 1, _circle.GetScale());
            Assert.Equal(Math.PI * 1 * 1, shapesScale.GetScale(_circle));
        }
        [Fact]
        public void StraighTest()
        {
            Assert.True(_triangle.IsStraight());
            Assert.False((new Triangle(4, 5, 6)).IsStraight());
        }
    }
}