class Circle : I2Dshape
{
    public Circle(double r)
    {
        radius = r;
    }
    protected double radius;
    public virtual double GetArea() => Math.PI * radius * radius;
    public virtual double GetPerimeter() => 2 * Math.PI * radius;
}