namespace Shapes
{
    public class ShapesScale
    {
        public double GetScale(ICanGetScale canGetScale)
        {
           return canGetScale.GetScale();
        }
    }
}