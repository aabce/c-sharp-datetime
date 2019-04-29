using System;

namespace custom_date_time
{

    // tested https://www.epochconverter.com/

    class Program
    {
        static void Main(string[] args)
        {
            string str="";

            Aion datetime = new Aion(1330493365000);// Human time (GMT): Wednesday, February 29, 2012 5:29:25 AM
            str = datetime.getDateTime();
            Console.WriteLine(str);

            Aion datetime1 = new Aion(1456705401000);// Human time (GMT): Monday, February 29, 2016 12:23:21 AM
            str = datetime1.getDateTime();
            Console.WriteLine(str);

            Aion datetime2 = new Aion(1555846442000);// Human time (GMT): Sunday, April 21, 2019 11:34:02 AM
            str = datetime2.getDateTime();
            Console.WriteLine(str);

        }
    }
}
