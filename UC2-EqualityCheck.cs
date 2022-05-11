namespace LinePracticeProblem
{
    public class Line
    {
        public int x1 = 20, x2 = 40, y1 = 50, y2 = 80;
        public double length;
        public int l1, l2;

        public void Cartesian()
        {
            length = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine(length);
        }

        public void Equality()
        {
            l1 = x2 - x1;
            l2 = y2 - y1;
            if(l1.Equals(l2))
            {
                Console.WriteLine("The given straight lines are identical");
            }
            else
            {
                Console.WriteLine("The given straight lines are not identical");
            }
        }
    }
}
