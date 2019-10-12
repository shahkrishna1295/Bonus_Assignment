using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2_N01318294_ServerControls
{
    public partial class weeklyCalendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    weekly_summary.InnerHtml = "";
                    
                    //List<string> weekDays = new List<string>();
                    //weekDays.Add("Tuesday");
                    //weekDays.Add("Wednesday");
                    //weekDays.Add("Thursday");
                    //weekDays.Add("Friday");
                    //weekDays.Add("Saturday");
                    //weekDays.Add("Sunday");
                    //weekDays.Add("Monday");

                    int month = 10;
                    DateTime dt = new DateTime(2019, month, 1);
                    int day = 1;
                    
                    //for the month of october
                    while (dt.Month == month )
                    {
                        //weekly_summary.InnerHtml += "Oct " + dt.Day + " is a " + dt.DayOfWeek + "!" + "Time to have fun!" + "<br/>";
                        
                        //gathering the list item selected
                        foreach (ListItem workDays in workdays.Items)
                        {
                            //just to start the day from tuesday
                            //here it skips the first value of the workday list i.e monday
                            if (day == 1 && workDays.Value == "Monday")
                            {
                                continue;
                            }
                            
                            //increment dates
                            if (day <= 31)
                            {
                                //check which day is selected and if selected display as work day 
                                if (workDays.Selected == true)
                                {
                                    weekly_summary.InnerHtml += "Oct " + day + " is a " + workDays.Text + "!" + "Time to work!" + "<br/>";

                                }

                                //print as fun day for not selected days
                                else
                                {
                                    weekly_summary.InnerHtml += "Oct " + day + " is a " + workDays.Text + "!" + "Time to have fun!" + "<br/>";
                                }
                                day += 1;
                            }
                        }                       
                        
                        dt = dt.AddDays(7);
                        
                    }
                    
                }
            }
        }

        
    }
}