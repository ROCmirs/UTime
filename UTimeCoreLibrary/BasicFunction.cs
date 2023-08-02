using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTimeCoreLibrary
{
    public class Operator
    {
        /// <summary>
        /// TODO 1-5 2023-8-2-21-20 
        /// 类：Operator，用于进行TimePoint间的基本运算
        /// </summary>
        //变量
        private TimePoint timePointA; 
        private TimePoint timePointB;
        private TimePoint result;
        //判断是否为空TimePoint
        public bool TimePointIsNull(TimePoint timePoint)
        {
            /// <summary>
            /// TODO 1-6 2023-8-2-21-21 
            /// 函数：IsNull，判断TimePoint是否为空
            /// </summary>
            if (timePoint.Year == 0&&timePoint.Month == 0&&timePoint.Hour==0&&timePoint.Minute==0&&timePoint.Second==0)
            {
                return true;
            }
            return false;
        }
        //构造函数
        public Operator(TimePoint TimePointA, TimePoint TimePointB)
        {
            timePointA=TimePointA; 
            timePointB=TimePointB;
        }
        //运算
        /*public TimePoint Add() 
        {
            if (!TimePointIsNull(timePointA))//判断一个TimePoint是否为空
            {
                //若不为空，则进行加法
            }
        }*/
    }
}
