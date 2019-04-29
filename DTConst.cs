using System;
namespace custom_date_time
{
    public static class DTConst
    {
        /**
         * IN SEC
         */
        public static readonly int SECOND = 1000;
        public static readonly int MINUTE = 60000;
        public static readonly int HOUR = 3600000;
        public static readonly int DAY = 86400000;

        public static readonly int[] MONTHS = new int[12] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        /**
         * DAY OF THE WEEK
         * 01011970 = THURSDAY shift 4
         */
        
         public static string dayOfTheWeek(int day){
             int weekday = (int)(day%7 + 3);
             if (weekday>7){
                 weekday = (int)(weekday%7);
             }
             switch (weekday)
             {
                 case 1 : 
                    return "MONDAY";
                 case 2 : 
                    return "TUESDAY";
                 case 3 : 
                    return "WEDNESDAY";
                 case 4 : 
                    return "THURSDAY";
                 case 5 : 
                    return "FRIDAY";
                 case 6 : 
                    return "SATURDAY";
                 case 7 : 
                    return "SUNDAY";
                default:
                    return "ERROR: NO SUCH DAY EXISTS"+weekday+"/"+day;

             }

         }

        /**
         * MONTH OF THE YEAR
         */

         public static string monthOfTheYear(int month){
             switch (month)
             {
                 case 1 : 
                    return "JANUARY";
                 case 2 : 
                    return "FEBRUARY";
                 case 3 : 
                    return "MARCH";
                 case 4 : 
                    return "APRIL";
                 case 5 : 
                    return "MAY";
                 case 6 : 
                    return "JUNE";
                 case 7 : 
                    return "JULE";
                 case 8 : 
                    return "AUGUST";
                 case 9 : 
                    return "SEPTEMBER";
                 case 10 : 
                    return "OCTOBER";
                 case 11 : 
                    return "NOVEMBER";                                                                                
                 case 12 : 
                    return "DECEMBER";                    
                default:
                    return "ERROR: NO SUCH MONTH FOUND";

             }

         }

         
         

        
    }
}