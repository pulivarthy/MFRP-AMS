using System;
using System.Collections.Generic;
using DEL;
using System.Data.SqlClient;

namespace DAL
{
    public class Customer_Policy_RegDAL : IDAL<Customer_Policy_Reg>
    {
        SqlConnection sqlcon = new SqlConnection(DAL.Properties.Settings1.Default.ConStr);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        bool IDAL<Customer_Policy_Reg>.Save(Customer_Policy_Reg ad)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = " Customer_policysp @Customer_id='"+ad.Customer_id+"',@Policy_name='" + ad.Policy_name + "' ,@Policy_company='" + ad.Policy_company + "',@Date_of_booking='" + ad.Date_of_booking + "',@Sum_assured=" + ad.Sum_assured + ",@Payment_mode='" + ad.Payment_mode + "',@Agent_id="+ad.Agent_Id+",@Date_of_birth='" + ad.Date_of_birth + "',@Height=" + ad.Height + ",@Weight=" + ad.Weight + ",@Identification_mark='" + ad.Identification_mark + "',@Nominee_name='" + ad.Nominee_name + "',@Nominee_relationship='" + ad.Nominee_relationship + "',@Nominee_date_of_birth='" + ad.Nominee_date_of_birth + "',@Contact_no=" +ad.Contact_no+ "";
                if (sqlcon.State == System.Data.ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlcon.Close();
            }
        }

        Customer_Policy_Reg IDAL<Customer_Policy_Reg>.GetById(Object empobj)
        {
            Customer_Policy_Reg ad = new Customer_Policy_Reg();
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "select * from Customer_Policy_Reg where @Customer_id=" + empobj + "";
                if (sqlcon.State == System.Data.ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    ad.Customer_id = Convert.ToInt32(dr["Customer_id"]);
                    ad.Policy_name = (dr["Policy_name"].ToString());
                    ad.Policy_company = (dr["Policy_company"].ToString());
                    ad.Date_of_booking = DateTime.ParseExact(dr["Date_of_booking"].ToString(), "MM-dd-yyyy", null);
                    ad.Sum_assured = Convert.ToInt32(dr["Sum_assured"]);
                    ad.Payment_mode = (dr["Payment_mode"].ToString());
                    ad.Agent_Id = Convert.ToInt32(dr["Agent_Id"]);
                    ad.Date_of_birth = DateTime.ParseExact(dr["Date_of_birth"].ToString(), "MM-dd-yyyy", null);
                    ad.Height = Convert.ToInt32(dr["Height"]);
                    ad.Weight = Convert.ToInt32(dr["Weight"]);
                    ad.Identification_mark = (dr["Identification_mark"].ToString());
                    ad.Nominee_name = (dr["Nominee_name"].ToString()); ;
                    ad.Nominee_relationship = (dr["Nominee_relationship"].ToString());
                    ad.Nominee_date_of_birth = DateTime.ParseExact(dr["Nominee_date_of_birth"].ToString(), "MM-dd-yyyy", null);
                    ad.Contact_no = Convert.ToInt32(dr["Contact_no"]);

                }
                dr.Close();
                return ad;
            }
            catch (Exception ex)
            {
                return ad;
            }
            finally
            {
                sqlcon.Close();
            }
        }

        bool IDAL<Customer_Policy_Reg>.Delete(Customer_Policy_Reg dl)
        {
            return false;
        }
        bool IDAL<Customer_Policy_Reg>.Update(Customer_Policy_Reg up)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "Customer_Policy_Regupd @Policy_name='" + up.Policy_name + "' ,@Policy_company='" + up.Policy_company + "',@Date_of_booking='" + up.Date_of_booking + "',@Sum_assured='" + up.Sum_assured + "',@Payment_mode=" + up.Payment_mode + "',@Date_of_birth='" + up.Date_of_birth + "',@Height='" + up.Height + "',@Weight='" + up.Weight + "',@Identification_mark='" + up.Identification_mark + "',@Nominee_name='" + up.Nominee_name + "',@Nominee_relationship='" + up.Nominee_relationship + "',@Nominee_date_of_birth='" + up.Nominee_date_of_birth + "',@Contact_no='" + up.Contact_no + "'";
                if (sqlcon.State == System.Data.ConnectionState.Closed)
                {
                    sqlcon.Open();

                }
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
            finally
            {
                sqlcon.Close();
            }

        }
        public Customer_Policy_Reg GetPoilcyDetailsByAppointId(object AppointId)
        {
            Customer_Policy_Reg ad = new Customer_Policy_Reg();
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = " Appointmentsp @AppointmentId=" + AppointId + "";
                if (sqlcon.State == System.Data.ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    ad.Customer_id = Convert.ToInt32(dr["Customer_id"]);
                    ad.Policy_name = (dr["Policy_name"].ToString());
                    ad.Policy_company = (dr["Policy_company"].ToString());
                    ad.Date_of_booking = DateTime.ParseExact(dr["Date_of_booking"].ToString(), "MM-dd-yyyy", null);
                    ad.Sum_assured = Convert.ToInt32(dr["Sum_assured"]);
                    ad.Payment_mode = (dr["Payment_mode"].ToString());
                    ad.Agent_Id = Convert.ToInt32(dr["Agent_Id"]);
                    ad.Date_of_birth = DateTime.ParseExact(dr["Date_of_birth"].ToString(), "MM-dd-yyyy", null);
                    ad.Height = Convert.ToInt32(dr["Height"]);
                    ad.Weight = Convert.ToInt32(dr["Weight"]);
                    ad.Identification_mark = (dr["Identification_mark"].ToString());
                    ad.Nominee_name = (dr["Nominee_name"].ToString()); ;
                    ad.Nominee_relationship = (dr["Nominee_relationship"].ToString());
                    ad.Nominee_date_of_birth = DateTime.ParseExact(dr["Nominee_date_of_birth"].ToString(), "MM-dd-yyyy", null);
                    ad.Contact_no = Convert.ToInt32(dr["Contact_no"]);

                }
                dr.Close();
                return ad;
            }
            catch (Exception ex)
            {
                return ad;
            }
            finally
            {
                sqlcon.Close();
            }
        }


    }
}
