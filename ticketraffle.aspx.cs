using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2_N01318294_ServerControls
{
    public partial class ticketraffle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    ticketSummary.InnerHtml += "";

                    int tickets = Convert.ToInt32(ticketNumber.Text);
                    double cost = 0.25;
                    int i;


                    //ticketSummary.InnerHtml += "You recieved a bundle of " + (tickets/tickets) + "! " + "Thats " + (i+1) + "tickets." + "<br/>";

                    //formulating the input tickets under 50
                    if (tickets < 51)
                    {
                        //bundeling the tickets individually and printing the summary
                        for (i = 1; i <= tickets; i++)
                        {
                            ticketSummary.InnerHtml += "You recieved a bundle of 1! " + "Thats " + (i) + " ticket(s)." + "<br/>";
                        }

                        //printing the total cost
                        ticketSummary.InnerHtml += "Your total ticket(s) is " + tickets + "and your cost is $" + (tickets * cost) + "cad.";
                    }

                    //formulating the input tickets from 51 to 150
                    else if (tickets >= 51 && tickets <= 150)
                    {
                        //bundeling the tickets indivisually and printing the summary
                        for (i = 2; i <= tickets; i += 2)
                        {
                            
                            ticketSummary.InnerHtml += "You recieved a bundle of 2! " + "Thats " + (i) + " ticket(s)!" + "<br/>";
                            
                        }
                        
                        //checking the leftover ticket
                        ticketSummary.InnerHtml += "Your leftover is " + (tickets%2) + "Thats " + (i -= 1) + " ticket(s)!" + "<br/>";
                        
                        //printing the total cost
                        ticketSummary.InnerHtml += "Your total ticket(s) is " + tickets + "and your cost is $" + (tickets * cost) + "cad.";
                    }

                    //formulating the input tickets under 151 to 300
                    else if (tickets >= 151 && tickets <= 300)
                    {
                        //bundeling the tickets indivisually and printing the summary
                        for (i = 3; i <= tickets; i += 3)
                        {
                            ticketSummary.InnerHtml += "You recieved a bundle of 3! " + "Thats " + (i) + " ticket(s)!" + "<br/>";
                        }

                        //checking the leftover ticket
                        ticketSummary.InnerHtml += "Your leftover is " + (tickets % 3) + "Thats " + (i -= 2) + " ticket(s)!" + "<br/>";

                        //printing the total cost
                        ticketSummary.InnerHtml += "Your total ticket(s) is " + tickets + "and your cost is $" + (tickets * cost) + "cad.";
                    }

                    //formulating the input tickets under more than 300
                    else
                    {
                        for (i = 5; i <= tickets; i += 5)
                        {
                            ticketSummary.InnerHtml += "You recieved a bundle of 5! " + "Thats " + (i) + " ticket(s)." + "<br/>";
                        }

                        //checking the leftover ticket
                        ticketSummary.InnerHtml += "Your leftover is " + (tickets % 3) + "Thats " + (i -= 4) + " ticket(s)!" + "<br/>";

                        //printing the total cost
                        ticketSummary.InnerHtml += "Your total ticket(s) is " + tickets + "and your cost is $" + (tickets * cost) + "cad.";
                    }

                }
            }
        }
    }
}