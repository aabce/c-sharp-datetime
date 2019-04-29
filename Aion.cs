using System;

namespace custom_date_time
{
    public class Aion{

        private int YEAR = 1970;
        private int MONTH = 0;
        private double DAY = 0;
        private string WEEKDAY = "";
        private double HOUR = 0;
        private double MIN = 0;
        private double SEC = 0;
        private double MSEC = 0;
        private long msecs = 0; 
        private double rem_msec = 0; // ostatok msec 
    
    public Aion(long msec){
        msecs = msec;
        run();
    }

    private void run(){
        DAY = msecs/DTConst.DAY+1; //+1 potomuchto s 1 yanvarya
        DAY = Math.Floor(DAY);

        WEEKDAY = DTConst.dayOfTheWeek((int)DAY);

        rem_msec = msecs%DTConst.DAY;
        rem_msec = Math.Floor(rem_msec);

        initDate();    // cherez obwee kolichestvo dney ishem Y:M:D
        initTime();    // cherez ostato msec ishem H:M:S:m
        correctDate(); // kostyl ili kastyl 
    }

    private void correctDate(){
        if (MONTH==2 && isLeapYear()){
            MONTH--;
            DAY = DTConst.MONTHS[MONTH]+1;
        }
    }
    private void initDate(){
        double  days = DAY;
        while ((days -= DTConst.MONTHS[MONTH])>0){

            if(MONTH==1 && isLeapYear()){
                days -= 1;//+1 potomuchto visokosnyi god 
            }
            
            MONTH++;
            if (MONTH>11){
                MONTH=0;
                YEAR++;
            }       
            DAY=days;         
        }

    }

    public bool isLeapYear(){
        return ((YEAR%4==0 && YEAR%100!=0) || YEAR%400==0) ? true : false;
    }

    private void initTime(){
        HOUR = rem_msec/DTConst.HOUR;
        HOUR = Math.Floor(HOUR);
        rem_msec=rem_msec%DTConst.HOUR;

        MIN = rem_msec/DTConst.MINUTE;
        MIN = Math.Floor(MIN);
        rem_msec=rem_msec%DTConst.MINUTE;

        SEC  = rem_msec/DTConst.SECOND;
        SEC  = Math.Floor(SEC);
        MSEC = rem_msec%DTConst.SECOND;
    }

    //geters
    public int getYEAR(){
        return YEAR;
    }

    public int getMONTH(){
        return MONTH+1;//potomuchto month nachinaetsya s 0
    }

    public double getDAY(){
        return DAY;
    }

    public double getHOUR(){
        return HOUR;
    }

    public double getMINUTE(){
        return MIN;
    }

    public double getSECOND(){
        return SEC;
    }

    public double getMSEC(){
        return MSEC;
    }

    // dateFormats

    public string getDateTime(){
        return String.Format("{0}-{1}-{2} {3}:{4}:{5}:{6} DAY:{7} IS_LEAP_YEAR:{8}", YEAR, DTConst.monthOfTheYear(getMONTH()), DAY, HOUR, MIN, SEC, MSEC, WEEKDAY, isLeapYear());
    }

    public string getDate(){
        return String.Format("{0}-{1}-{2}", YEAR, MONTH, DAY);
    }

    public string getTime(){
        return String.Format("{0}:{1}:{2}:{3}",HOUR, MIN, SEC, MSEC);
    }
    }
}