namespace LinePracticeProblem
{
   

        public void Compare()
        {
            l1 = x2 - x1;
            l2 = y2 - y1;
            int n = (l1.CompareTo(l2));
            if ( n > 0)
            {
                Console.WriteLine("line 1 is Greater than line 2");
            }
            else if ( n < 0 )
            {
                Console.WriteLine("line 2 is Greater than Line 1");
            }
            else 
            {
                Console.WriteLine("Line 1 and Line 2 are equal");
            }
        }

}
  
