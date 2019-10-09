using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment_N01374963
{
    public partial class CartPlane : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
            {

                Page.Validate();

                if (Page.IsValid)
                {
                    quad_summary.InnerHtml = "";

                    int X_Value = Convert.ToInt32(x_value.Text);
                    int Y_Value = Convert.ToInt32(y_value.Text);

                    if (X_Value < 0 && Y_Value < 0)
                    {
                        quad_summary.InnerHtml += "( " + X_Value + "," + Y_Value + " ) " + "falls in quadrant 3  < br >";
                    }

                    if (X_Value > 0 && Y_Value > 0)
                    {
                        quad_summary.InnerHtml += "( " + X_Value + "," + Y_Value + " ) " + "falls in quadrant 1  <br>";

                    }
                    if (X_Value > 0 && Y_Value < 0)
                    {
                        quad_summary.InnerHtml += "( " + X_Value + "," + Y_Value + " ) " + "falls in quadrant 4  <br>";

                    }
                    if (X_Value < 0 && Y_Value > 0)
                    {
                        quad_summary.InnerHtml += "( " + X_Value + "," + Y_Value + " ) " + "falls in quadrant 2  <br>";
                    }
                    if (X_Value == 0 && Y_Value == 0)
                    {
                        quad_summary.InnerHtml += "( " + X_Value + "," + Y_Value + " ) " + "is not in any quadrant  <br>";
                    }
                }

            }
        }
    }
}