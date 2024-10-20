using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronoLog
{
    internal class ProgramData
    {

        // for testing purposes
        private string testingEmail;
        private string testingPassword;

        // date data

        private string month;
        private int year;
        private int day;

        // timer data
        private DateTime usageTimeStart;
        private DateTime usageTimeEnd;

        // setters and getters 
        public DateTime UsageTimeStart
        {

            get
            {
                return usageTimeStart;
            }
            set
            {
                usageTimeStart = value;
            }
        }
        public DateTime UsageTimeEnd
        {

            get
            {
                return usageTimeEnd;
            }
            set
            {
                usageTimeEnd = value;
            }

        }
        public string Month
        {

            get
            {
                return month;
            }
            set
            {

                month = value;
            }
        }
        public int Year
        {

            get
            {
                return year;
            }
            set
            {

                year = value;
            }
        }
        public int Day
        {

            get
            {

                return day;
            }
            set
            {

                day = value;
            }
        }

    }

        }
 
        

 
 