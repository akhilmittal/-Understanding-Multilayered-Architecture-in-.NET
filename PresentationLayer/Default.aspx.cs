using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using Common;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        StudentBLL studentBLL = new StudentBLL();
        StudentEntity studentEntity=new StudentEntity();
        studentEntity.StudentID=5;
        DataTable dTable = new DataTable();
        try
        {
            dTable = studentBLL.GetStudentBelow5(studentEntity);
            grdStudent.DataSource = dTable;
            grdStudent.DataBind();
        }
        catch (ApplicationException applicationException)
        {
            lblError.Text = applicationException.Message;
        }
        

    }
}
