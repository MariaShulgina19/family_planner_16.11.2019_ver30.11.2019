using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_planner_16._11._2019
{
    class ACTIVITY

    {
        public int _activityID { get; set; }
        public string _activityName { get; set; }
        public string _classname { get; set; }
        public DateTime _activityDay { get; set; }
        public DateTime _acticityStartTime { get; set; }
        public DateTime _acticityEndTime { get; set; }
        public DateTime _activityDuration { get; set; } //int changes to DateTime

        

        static int _amountOfactivities = 1;

        public ACTIVITY(string activityName)
        {
            _activityName = activityName;
            _activityID = _amountOfactivities;
            _amountOfactivities++;
        }

        public string GiveClassName() //return class name to know what to create 
        { return "activity"; }
        

        

        /*public void Duration()
        {
            _activityDuration = (int.Parse(_acticityEndTime.ToString()) - int.Parse(_acticityStartTime.ToString()));
            //it gives 0
        }
        */
    }
}
