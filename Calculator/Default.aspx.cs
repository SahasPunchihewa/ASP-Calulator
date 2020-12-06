using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.WebServiceSoapClient s = new ServiceReference1.WebServiceSoapClient();

        Double answer = 0.0;
        String select = DropDownList1.SelectedValue;

        if (select.Equals("Add")
        {
            answer = s.add(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
        }
        else if (select.Equals("Sub")
        {
            answer = s.sub(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
        }
        else if (select.Equals("Mul")
        {
            answer = s.mul(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
        }
        else if (select.Equals("Div")
        {
            answer = s.div(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
        }
        Label4.Text = answer.ToString();
    }
}