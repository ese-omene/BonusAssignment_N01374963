using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment_N01374963
{
    public partial class WeeklyCalendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var message = "";
           


            string[] weekDays;
            weekDays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            for (var i = 1; i < 32; i++)
            {



                if (work_days.SelectedValue == "monday" && weekDays[i % 7] == "Monday")
                {
                    message += "October " + i + " is a " + weekDays[i % 7] + " and...you have to work" + "<br>";
                }

                if (work_days.SelectedValue == "tuesday" && weekDays[i % 7] == "Tuesday")
                {
                    message += "October" + i + "is a" + weekDays[i % 7] + "and...you have to work" + "<br>";
                }

                if (work_days.SelectedValue == "wednesday" && weekDays[i % 70] == "Wednesday")
                {
                    message += "October" + i + "is a " + weekDays[i % 7] + "and...you have to work " + "<br>";
                }

                if (work_days.SelectedValue == "thursday" && weekDays[i%7] == "Thursday")
                {
                    message += "October" + i + "is a" + weekDays[i % 7] + "and...you have to work" + "<br>";
                }

                if (work_days.SelectedValue == "friday" && weekDays[i%7] == "Friday")
                {
                    message += "October" + i + "is a " + weekDays[i % 7] + "and...you have to work" + "<br>";
                }

                if (work_days.SelectedValue == "saturday" && weekDays[i%7] == "Saturday")
                {
                    message += "October" + i + "is a " + weekDays[i % 7] + "and...you have to work" + "<br>";
                }

                if (work_days.SelectedValue == "sunday" && weekDays [i%7] == "Sunday")
                {
                    message += "October " + i + "is a" + weekDays[i % 7] + "and...you have to work" + "<br>";
                }
                else {
                    message += "October " + i + " is a " + weekDays[i % 7] + "<br>";
                }



            }
            


            october.InnerHtml = message ;
           

          


            }

        }
    }





