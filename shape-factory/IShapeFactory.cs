namespace Factory.shape_factory
{
    public interface IShapeFactory
    {
        protected Shape CreateShape(string description);
    }
}