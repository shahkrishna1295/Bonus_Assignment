using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2_N01318294_ServerControls
{
    public partial class coordinate1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    //erasing any previous information
                    quadrantInfo.InnerHtml = "";

                    //gathering the values from the user input 
                    int X_Value = Convert.ToInt32(x_value.Text);
                    int Y_Value = Convert.ToInt32(y_value.Text);


                    //Check for the quadrants 
                    //Comparing inputs for quadrant I(+,+)
                    if(X_Value > 0 && Y_Value > 0)
                    {
                        quadrantInfo.InnerHtml += "(" + X_Value + "," + Y_Value + ")" + "falls in Quadrant I." ;
                    }

                    //Comparing inputs for quadrant II(+,-)
                    else if (X_Value > 0 && Y_Value < 0)
                    {
                        quadrantInfo.InnerHtml += "(" + X_Value + "," + Y_Value + ")" + "falls in Quadrant II.";
                    }

                    //Comparing inputs for quadrant III(-,-)
                    else if (X_Value <0 && Y_Value < 0)
                    {
                        quadrantInfo.InnerHtml += "(" + X_Value + "," + Y_Value + ")" + "falls in Quadrant III.";
                    }

                    //Comparing inputs for quadrant IV(-,+)
                    else if (X_Value < 0 && Y_Value > 0)
                    {
                       quadrantInfo.InnerHtml += "(" + X_Value + "," + Y_Value + ")" + "falls are in Quadrant IV.";
                    }

                    //checking condition for input (0,0)
                    else if (X_Value == 0 && Y_Value == 0)
                    {
                        quadrantInfo.InnerHtml += "(" + X_Value + "," + Y_Value + ")" + "falls in no quadrant.";
                    }

                    //everything else will come here
                    else
                    {
                        quadrantInfo.InnerHtml += "Invalid Input";
                    }
                }
            }

        }
    }
}