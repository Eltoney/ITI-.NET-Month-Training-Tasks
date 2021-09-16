namespace Shapes
{
    class shape
    {
        int dim1, dim2;

        public int Dim1
        {

            set
            {
                if (value > 0)
                {
                    dim1 = value;
                }
                else
                {
                    System.Console.WriteLine("side length must be a positive number");
                }
            }
            get { return dim1; }
        }
        public int Dim2
        {
            set
            {
                if (value > 0)
                {
                    dim1 = value;
                }
                else
                {
                    System.Console.WriteLine("side length must be a positive number");
                }
            }
            get { return dim2; }
        }


        public shape(int _dim1, int _dim2)
        {
            Dim1 = _dim1;
            Dim2 = _dim2;
        }
    }
}