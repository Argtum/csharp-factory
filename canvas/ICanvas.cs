namespace Factory.canvas
{
    public enum Color
    {
        Green,
        Red,
        Blue,
        Yellow,
        Pink,
        Black
    }
    
    public interface ICanvas
    {
        public void SetColor(Color color);
        public void DrawLine(form, to);
        public void DrawEllipse(l, t, w, h);
    }
}