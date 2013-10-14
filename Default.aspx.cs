using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Linq.Dynamic;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BindGridDynamic();
    }

    void BindGridTypeSafe()
    {
        NorthwindDataContext northwind = new NorthwindDataContext();

        var query = from p in northwind.Products
                    where p.CategoryID == 3 && p.UnitPrice > 3
                    orderby p.SupplierID
                    select p;

        GridView1.DataSource = query;
        GridView1.DataBind();
    }

    void BindGridDynamic()
    {
        NorthwindDataContext northwind = new NorthwindDataContext();

        var query = northwind.Products
                             .Where("CategoryID = 3 AND UnitPrice > 3")
                             .OrderBy("SupplierID");

        GridView1.DataSource = query;
        GridView1.DataBind();
    }
}
