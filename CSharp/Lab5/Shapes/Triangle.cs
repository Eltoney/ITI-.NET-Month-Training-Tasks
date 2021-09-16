namespace Shapes
{
    class triangle : shape
    {
        public triangle(int l, int w) : base(l, w) { }


        public int getArea()
        {
            return (Dim1 * Dim2) / 2; ;
        }
    }
}