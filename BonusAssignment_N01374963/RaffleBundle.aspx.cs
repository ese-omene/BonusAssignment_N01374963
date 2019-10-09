using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment_N01374963
{
    public partial class RaffleBundle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // set bundle sizes 
            // tickets < = 50 equals individual bundels
            //tickets => 51 , tickets <= 150 equals bundles of 2  (divisible by 2)
            // tickets => 151, tickets <= 300 equals bundles of 3 (divisible by 3)
            // tickets => 301 means bundles of 5   (divisible by 5)
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {   //handiling the inputted number of tickets
                    int Ticket_Numbers = Convert.ToInt32(ticket_numbers.Text);

                    if (Ticket_Numbers <= 50)
                    {
                        for (int i = 1; i < Ticket_Numbers; i++)
                        {
                            ticket_summary.InnerHtml += " you've recieved a bundle of 1! " + " that's " + i + " tickets <br>";

                        }
                        decimal price = .25m;

                        decimal Ticket_Total = (Ticket_Numbers * price);
                        ticket_total.InnerHtml = "your total cost is $" + Ticket_Total;
                    }
                    else if (Ticket_Numbers > 51 && Ticket_Numbers < 151)
                    {
                        for (int i = 2; i <= Ticket_Numbers; i = i + 2)
                        {
                            ticket_summary.InnerHtml += "you've recieved a bundle of 2!" + "that's " + i + "tickets<br>";
                        }
                        decimal price = .25m;
                        decimal Ticket_Total = (Ticket_Numbers * price);
                        ticket_total.InnerHtml = "your total cost is $" + Ticket_Total;

                    }
                    else if (Ticket_Numbers > 151 && Ticket_Numbers < 300)
                    {
                        for (int i = 3; i <= Ticket_Numbers; i = i + 3)
                        {
                            ticket_summary.InnerHtml += "you've recieved a bundle of 3!" + "that's" + i + "tickets<br>";
                        }
                        decimal price = .25m;
                        decimal Ticket_Total = (Ticket_Numbers * price);
                        ticket_total.InnerHtml = "your total cost is $" + Ticket_Total;
                    }
                    else if (Ticket_Numbers > 300)
                    {
                        for (int i=5; i<Ticket_Numbers; i=i+5)
                        {
                            ticket_summary.InnerHtml += "you've recieved a bundle of 5! that's " + i + " tickets <br>";
                        }
                        ticket_leftover.InnerHtml += "your leftover is " + (Ticket_Numbers % 5) + " that's " + Ticket_Numbers + " ticket(s)";

                        decimal price = .25m;
                        decimal Ticket_Total = (Ticket_Numbers * price);
                        ticket_total.InnerHtml = "your total cost is $" + Ticket_Total;
                    } else
                    {
                        ticket_summary.InnerHtml += "you didn't buy any tickets";
                    }

                    //                   if (Ticket_Numbers => 51 && Ticket_Numbers <= 150)
                    //                {

                    //              }

                    //           if (Ticket_Numbers => 151 && Ticket_Numbers <= 300)
                    //          {

                    //          }

                    //       if (Ticket_Numbers > 301)
                    //      {

                    //    }

                    // loop through and determin how many ticket are left until there are no tickets left








                }
            }
        }
    }
}