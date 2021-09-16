namespace complex
{
    class complexNumber
    {
        int real, img;

        public int Real
        {
            get
            {
                return this.real;
            }
            set
            {
                this.real = value;
            }
        }

        public int Img
        {
            get
            {
                return this.img;
            }
            set
            {
                this.img = value;
            }
        }


        public complexNumber Add(complexNumber a)
        {
            complexNumber ans = new complexNumber();
            ans.real = a.real + this.real;
            ans.img = a.img + this.img;
            return ans;
        }


        public complexNumber subtract(complexNumber a)
        {
            complexNumber ans = new complexNumber();
            ans.real = a.real - this.real;
            ans.img = a.img - this.img;
            return ans;
        }

        public complexNumber multiplay(complexNumber a)
        {
            complexNumber ans = new complexNumber();
            ans.real = a.real * this.real - a.img * this.img;
            ans.img = a.real * this.img + a.real * this.img;
            return ans;
        }

        public complexNumber conjucate()
        {
            complexNumber ans = new complexNumber();
            ans.real = this.real;
            ans.img = -1 * this.img;
            return ans;
        }
        public complexNumber divide(complexNumber a)
        {
            complexNumber ans = new complexNumber();
            int dem = a.real * a.real + a.img * a.img;
            int numReal = a.real * this.real + a.img + this.img;
            int numImg = this.img * a.real - this.real * a.img;
            ans.real = numReal / dem;
            ans.img = numImg / dem;
            return ans;
        }

        public void printNumber()
        {
            System.Console.WriteLine($"your number is: {real} + {img}i");
        }
    }
}