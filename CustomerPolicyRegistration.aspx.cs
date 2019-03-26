using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DEL;
using BLL;

namespace AMC
{
    public partial class CustomerPolicyRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlCustApp.DataSource = SqlDataSource1;
                ddlCustApp.DataTextField = "Name";
                ddlCustApp.DataValueField = "Customer_Id";
                ddlCustApp.DataBind();
                ddlCustApp.Items.Insert(0, "--SELECT--");
            }

        }

        //protected void RadioButtonExistingcustomer1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (RadioButtonExistingcustomer1.Checked == true)
        //    {
        //        txtPolicyName.Visible = false;
        //        txtPolicyCompany.ReadOnly = true;
        //        txtDobooking.ReadOnly = true;
        //        txtsumAssured.ReadOnly = true;
        //        txtPaymentMode.ReadOnly = true;
        //        txtAgentid.ReadOnly = true;
        //        txtDob.ReadOnly = true;
        //        txtHeight.ReadOnly = true;
        //        txtWeight.ReadOnly = true;
        //        txtIdentificationMarks.ReadOnly = true;
        //        txtNomineeName.ReadOnly = true;
        //        txtNomineeRelationship.ReadOnly = true;
        //        txtNomineedob.ReadOnly = true;
                


        //    }
        //    else if(RadioButtonExistingcustomer2.Checked==true)
        //    {
        //       Customer_Policy_Reg custreg=new Customer_Policy_Reg();
        //       Customer_Policy_RegBLL custregbll = new Customer_Policy_RegBLL();
        //       custreg.Policy_name = txtPolicyName.Text;
        //       custreg.Policy_company = txtPolicyCompany.Text;
        //       custreg.Date_of_booking = DateTime.ParseExact(txtDobooking.Text, "yyyy-MM-dd", null);
        //       custreg.Sum_assured = long.Parse(txtsumAssured.Text);
        //       custreg.Payment_mode = txtPaymentMode.Text;
        //       custreg.Agent_Id = long.Parse(txtAgentid.Text);
        //       custreg.Date_of_birth = DateTime.ParseExact(txtDob.Text, "yyyy-MM-dd", null);
        //       custreg.Height = double.Parse(txtHeight.Text);
        //       custreg.Weight = double.Parse(txtWeight.Text);
        //       custreg.Identification_mark = txtIdentificationMarks.Text;
        //       custreg.Nominee_name = txtNomineeName.Text;
        //       custreg.Nominee_relationship = txtNomineeRelationship.Text;
        //       custreg.Nominee_date_of_birth = DateTime.ParseExact(txtNomineedob.Text, "yyyy-MM-dd", null);
        //       custreg.Contact_no = long.Parse(txtContactno.Text);
        //       if (custregbll.Save(custreg))
        //       {
        //           Label.Text = "Saved!";

        //       }
        //       else
        //       {
        //           Label.Text = "Failed!";
        //       }

        //    }

        //}


        protected void RadioButtonExistingcustomer1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void ddlCustApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataSource2.SelectCommand = "select AppointmentId from Customer_app where Customer_id=" + ddlCustApp.SelectedItem.Value + "";
            //ddlAppintId.DataBind();
            Customer_Policy_RegBLL custbll = new Customer_Policy_RegBLL();
           
            //  ddlAppintId.SelectedItem.Text.
            
            ddlAppintId.DataSource = SqlDataSource2;
            ddlAppintId.DataTextField = "AppointmentId";
            ddlAppintId.DataValueField = "AppointmentId";
            ddlAppintId.DataBind();
            ddlAppintId.Items.Insert(0, "--SELECT--");
            //Customer_Policy_Reg cust = custbll.GetPoilcyDetailsByAppointId(Convert.ToInt32(ddlAppintId.SelectedValue));
            //txtPolicyName.Text = cust.Policy_name;
        }

        protected void ddlAppintId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer_Policy_RegBLL custbll=new Customer_Policy_RegBLL();
          Customer_Policy_Reg cust=  custbll.GetPoilcyDetailsByAppointId(Convert.ToInt32(ddlAppintId.SelectedValue ));
          //  ddlAppintId.SelectedItem.Text.
          if (cust.Appointment_id!=null)
          {
              txtPolicyName.Text = cust.Policy_name;
              txtPolicyCompany.Text = cust.Policy_company;
              txtDobooking.Text = cust.Date_of_booking.ToString("MM-dd-yyyy");
              txtsumAssured.Text = cust.Sum_assured.ToString();
              txtPaymentMode.Text = cust.Payment_mode;
              
          }
          else
          {
              Response.Write("<script>alert('This Policy is Not Registered')</script>");
          }
            

        }
    } 
}