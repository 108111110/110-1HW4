using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1HW4
{
    public partial class DropdownListShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ListItem o_Li = new ListItem("北區", "北區");
                ddl_Area.Items.Add(o_Li);

                o_Li = new ListItem("南區", "南區");
                ddl_Area.Items.Add(o_Li);

                o_Li = new ListItem("基隆", "基隆");
                ddl_Place.Items.Add(o_Li);
                o_Li = new ListItem("台北", "台北");
                ddl_Place.Items.Add(o_Li);
                o_Li = new ListItem("新北", "新北");
                ddl_Place.Items.Add(o_Li);
            }

        }

        protected void ddl_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_Place.Items.Clear();
            ListItem o_Li;
            if (ddl_Area.SelectedValue == "北區")
            {
                o_Li = new ListItem("基隆", "基隆");
                ddl_Place.Items.Add(o_Li);
                o_Li = new ListItem("台北", "台北");
                ddl_Place.Items.Add(o_Li);
                o_Li = new ListItem("新北", "新北");
                ddl_Place.Items.Add(o_Li);
            }
            else
            {
                o_Li = new ListItem("苗栗", "苗栗");
                ddl_Place.Items.Add(o_Li);
                o_Li = new ListItem("台中", "台中");
                ddl_Place.Items.Add(o_Li);
                o_Li = new ListItem("南投", "南投");
                ddl_Place.Items.Add(o_Li);
            }
        }
    }
}