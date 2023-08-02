namespace UTimeCoreLibrary
{
    public struct TimePoint
    {
        /// <summary>
        /// TODO 1-4 2023-7-31-20-50
        /// 结构体：TimePoint，用于表示基本时间节点
        /// updated at 2023-8-2-20-31
        /// </summary>
        // 私有变量
        private int year;
        private int month;
        private int day;
        private int hour;
        private int minute;
        private int second;
        //构造函数
        public TimePoint()
        {
            year = 2023;
            month = 7;
            day = 31;
            hour = 20;
            minute = 30;
            second = 31;
        } 
        //索引器
        public int Year { get { return year; } set {  year = value; } }
        public int Month { get { return month; } set { month = value; } }
        public int Day { get { return day; } set { day = value; } }
        public int Hour { get { return hour; } set { hour = value; } }
        public int Minute { get { return minute; } set { minute = value; } }
        public int Second { get { return second; } set { second = value; } }
    }
}