using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{
    
    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public double add(double num1,double num2)
    {
        double total = num1 + num2;
        return total;
    }
    [WebMethod]
    public double sub(double num1, double num2)
    {
        double subt = num1 - num2;
        return subt;
    }
    [WebMethod]
    public double mul(double num1, double num2)
    {
        double multiply = num1 * num2;
        return multiply;
    }
    [WebMethod]
    public double div(double num1, double num2)
    {
        double divi = num1 / num2;
        return divi;
    }

}
