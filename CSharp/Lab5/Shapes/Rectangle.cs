namespace Shapes
{
    class rectangle : shape
    {
        public rectangle(int l, int w) : base(l, w) { }


        public int getArea()
        {
            return Dim1 * Dim2;
        }
    }
}