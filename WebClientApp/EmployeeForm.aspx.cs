using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DataAccessLib;

namespace WebClientApp
{
    public partial class EmployeeForm : System.Web.UI.Page
    {

        DataAccess objds;
        private decimal taxRule;

        protected void Page_Load(object sender, EventArgs e)
        {
            objds = new DataAccess();
            if (!IsPostBack)
            {
                loadData();
            } 
             
        }

        void loadData()
        {
            lstename.DataSource = objds.GetData();
            lstename.DataValueField = "EmpNo";
            lstename.DataTextField = "EmpName";
            lstename.DataBind();
            gdvemp.DataSource = objds.GetData();
            gdvemp.DataBind();
        }

        protected void new_Click(object sender, EventArgs e)
        {
            eno.Text = "";
            ename.Text = "";
            sal.Text = "";
            dname.Text = "";
            desig.Text = "";
        }

        protected void save_Click(object sender, EventArgs e)
        {
            EmployeeInfo Emp = (EmployeeInfo)ViewState["Emp"];
            if (Emp == null)
            {
                var emp = new EmployeeInfo()
                {
                    EmpName = ename.Text,
                    Salary = Convert.ToInt32(sal.Text),
                    DeptName = dname.Text,
                    Designation = desig.Text
                };
                eno.Text = objds.Create(emp).EmpNo.ToString();
                loadData();
            }
            if (Emp != null)
            {
                Emp.EmpName = ename.Text;
                Emp.Salary = Convert.ToInt32(sal.Text);
                Emp.DeptName = dname.Text;
                Emp.Designation = desig.Text;

                var res = objds.Update(Emp.EmpNo, Emp);
                if (res)
                {
                    msg.Text = "Updated Successfully";
                    loadData();
                }
                else
                {
                    msg.Text = "Updated is not Successful";
                }
            }

            var Tax = this.taxRule * Convert.ToDecimal(sal.Text);
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            EmployeeInfo Emp = (EmployeeInfo)ViewState["Emp"];
            if (Emp != null)
            {
                var res = objds.Delete(Emp.EmpNo);
                if (res)
                {
                    msg.Text = "Deleted Successfully";
                    loadData();
                }
                else
                {
                    msg.Text = "Delete is Unsuccessful";
                }
            }
            else
            {
                msg.Text = "Please Select Record to be deleted";
            }
        }

        protected void lstename_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = lstename.SelectedItem.Value;

            var Employee = objds.GetData(Convert.ToInt32(id));
            eno.Text = Employee.EmpNo.ToString();
            ename.Text = Employee.EmpName;
            sal.Text = Employee.Salary.ToString();
            dname.Text = Employee.DeptName;
            desig.Text = Employee.Designation;

            ViewState["Emp"] = Employee;

        }

        protected void gettax_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = objds.GetEmpTax();
            GridView1.DataBind();
        }   
    }
}