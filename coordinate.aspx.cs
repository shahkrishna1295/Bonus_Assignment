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
                    //eraseing any previous information
                    quadrantInfo.InnerHtml = "";

                    //assigning the variables to the user input 
                    int X_Value = Convert.ToInt32(x_value.Text);
                    int Y_Value = Convert.ToInt32(y_value.Text);

                    if(X_Value > 0 && Y_Value > 0)
                    {
                        quadrantInfo.InnerHtml += "(" + X_Value + "," + Y_Value + ")" + "falls in Quadrant I." ;
                    }
                    else if (X_Value > 0 && Y_Value < 0)
                    {
                        quadrantInfo.InnerHtml += "(" + X_Value + "," + Y_Value + ")" + "falls in Quadrant II.";
                    }
                    else if (X_Value <0 && Y_Value < 0)
                    {
                        quadrantInfo.InnerHtml += "(" + X_Value + "," + Y_Value + ")" + "falls in Quadrant III.";
                    }
                    else if (X_Value < 0 && Y_Value > 0)
                    {
                       quadrantInfo.InnerHtml += "(" + X_Value + "," + Y_Value + ")" + "falls are in Quadrant IV.";
                    }
                    else if (X_Value == 0 && Y_Value == 0)
                    {
                        quadrantInfo.InnerHtml += "(" + X_Value + "," + Y_Value + ")" + "falls in no quadrant.";
                    }
                    else
                    {
                        quadrantInfo.InnerHtml += "Invalid Input";
                    }
                }
            }

        }
    }
}