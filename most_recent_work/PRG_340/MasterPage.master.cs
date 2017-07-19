using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnViewAllStudents_Click(object sender, EventArgs e)
    {
        ContentPlaceHolder cphMain = null;
        try
        {
            cphMain = (ContentPlaceHolder)Master.FindControl("cphMain");
        }
        catch (Exception ex)
        {
            Response.Write("Exception = " + ex.Message);
        }
        finally
        {
            if (cphMain != null)
            {
                Table tblStudent = new Table();
                tblStudent.ID = "tblStudent";

                // Table is added dynamically in a content place holder
                //ContentPlaceHolder content = (ContentPlaceHolder)this.Master.FindControl("cphMain");
                cphMain.Controls.Add(tblStudent);
                TableRow tRow = new TableRow();
                tblStudent.Rows.Add(tRow);

                TableCell tCell = new TableCell();

                tCell.Text = "Text";
                tRow.Cells.Add(tCell);
            }
        }
    }
}
