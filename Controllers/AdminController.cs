using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace Charity_Management_System.Controllers
{    
    public class AdminController : Controller
    {       
        public IActionResult Index(string username = "", string Password = "")
        {
            try
            {
                var checkAdmin = JsonConvert.DeserializeObject<adminSessionInfo>(HttpContext.Session.GetString("SessionAdmin"));
                
                return View("~/Views/Admin/index.cshtml");
            }
            catch (Exception)
            {

                if (username == null && Password == null)
                {
                    return View("~/Views/Home/login.cshtml");
                }

                SqlConnection con = new SqlConnection("Data Source=Ali-Shahid;Initial Catalog=CharityManagement;Integrated Security=True");
                con.Open();

                SqlCommand command = new SqlCommand("SELECT AN_UserName, AN_Password , AN_Name FROM Admin WHERE AN_UserName = @A AND AN_Password = @B", con);
                command.Parameters.AddWithValue("@A", username);
                command.Parameters.AddWithValue("@B", Password);


                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                con.Close();

                if (dataSet.Tables[0].Rows.Count == 1)
                {
                    string adminid = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
                    string pas = dataSet.Tables[0].Rows[0].ItemArray[1].ToString();
                    string name = dataSet.Tables[0].Rows[0].ItemArray[2].ToString();

                    if (adminid == username && pas == Password)
                    {
                        
                        
                        var adminSession = new adminSessionInfo();
                        adminSession.adminUserName = adminid;
                        adminSession.adminPassword = pas;
                        adminSession.adminName = name;
                        ViewData["adminName"] = name;
                        HttpContext.Session.SetString("SessionAdmin", JsonConvert.SerializeObject(adminSession));


                        return View("~/Views/Admin/index.cshtml");
                    }
                    else
                        return View("~/Views/Home/login.cshtml");
                }
                else
                    return View("~/Views/Home/login.cshtml");
            }
           
        }


        public IActionResult approve_valunteer()
        {
            try
            {
                var checkAdmin = JsonConvert.DeserializeObject<adminSessionInfo>(HttpContext.Session.GetString("SessionAdmin"));
                ViewData["adminName"] = checkAdmin.adminName;
            }
            catch(Exception)
            {
                return View("~/Views/Home/login.cshtml");
            }
            
            
            return View();
        }
        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return View("~/Views/Home/login.cshtml");
        }

        
        public IActionResult viewCases()       
        {
            try
            {
                var checkAdmin = JsonConvert.DeserializeObject<adminSessionInfo>(HttpContext.Session.GetString("SessionAdmin"));
                ViewData["adminName"] = checkAdmin.adminName;
            }
            catch (Exception)
            {
                return View("~/Views/Home/login.cshtml");
            }
            return View();
        }

        public IActionResult viewDonation()
        {
            try
            {
                var checkAdmin = JsonConvert.DeserializeObject<adminSessionInfo>(HttpContext.Session.GetString("SessionAdmin"));
                ViewData["adminName"] = checkAdmin.adminName;
            }
            catch (Exception)
            {
                return View("~/Views/Home/login.cshtml");
            }
            return View();
        }

        public IActionResult viewDonee()
        {
            try
            {
                var checkAdmin = JsonConvert.DeserializeObject<adminSessionInfo>(HttpContext.Session.GetString("SessionAdmin"));
                ViewData["adminName"] = checkAdmin.adminName;
            }
            catch (Exception)
            {
                return View("~/Views/Home/login.cshtml");
            }
            return View();
        }

        public IActionResult viewValunteer()
        {
            try
            {
                var checkAdmin = JsonConvert.DeserializeObject<adminSessionInfo>(HttpContext.Session.GetString("SessionAdmin"));
                ViewData["adminName"] = checkAdmin.adminName;
            }
            catch (Exception)
            {
                return View("~/Views/Home/login.cshtml");
            }
            return View();
        }

        public IActionResult del_volunteer(string id)
        {
            SqlConnection con = new SqlConnection("Data Source=Ali-Shahid;Initial Catalog=CharityManagement;Integrated Security=True");
            con.Open();

            SqlCommand command = new SqlCommand("DELETE FROM Volunteer WHERE V_Id = @A", con);
            command.Parameters.AddWithValue("@A", id);

            if (command.ExecuteNonQuery() > 0)
                con.Close();
           
            
            try
            {
                var checkAdmin = JsonConvert.DeserializeObject<adminSessionInfo>(HttpContext.Session.GetString("SessionAdmin"));
                ViewData["adminName"] = checkAdmin.adminName;
            }
            catch (Exception)
            {
                return View("~/Views/Home/login.cshtml");
            }
            return View("~/Views/Admin/approve_valunteer.cshtml");
        }

        public IActionResult app_volunteer(string id)
        {
            SqlConnection con = new SqlConnection("Data Source=Ali-Shahid;Initial Catalog=CharityManagement;Integrated Security=True");
            con.Open();

            SqlCommand command = new SqlCommand("UPDATE Volunteer SET V_IsApproved = 1 WHERE V_Id =  @A", con);
            command.Parameters.AddWithValue("@A", id);

            if (command.ExecuteNonQuery() > 0)
                con.Close();


            try
            {
                var checkAdmin = JsonConvert.DeserializeObject<adminSessionInfo>(HttpContext.Session.GetString("SessionAdmin"));
                ViewData["adminName"] = checkAdmin.adminName;
            }
            catch (Exception)
            {
                return View("~/Views/Home/login.cshtml");
            }
            return View("~/Views/Admin/approve_valunteer.cshtml");

        }

        public IActionResult DonationRequest()
        {
            try
            {
                var checkAdmin = JsonConvert.DeserializeObject<adminSessionInfo>(HttpContext.Session.GetString("SessionAdmin"));
                ViewData["adminName"] = checkAdmin.adminName;
            }
            catch (Exception)
            {
                return View("~/Views/Home/login.cshtml");
            }
            return View();
        }

        public IActionResult app_done_req(string id)
        {
            SqlConnection con = new SqlConnection("Data Source=Ali-Shahid;Initial Catalog=CharityManagement;Integrated Security=True");
            con.Open();

            SqlCommand command = new SqlCommand("UPDATE DonationAcceptor SET DA_Isdeserving = 1 WHERE DA_Id =  @A", con);
            command.Parameters.AddWithValue("@A", id);

            if (command.ExecuteNonQuery() > 0)
                con.Close();

            try
            {
                var checkAdmin = JsonConvert.DeserializeObject<adminSessionInfo>(HttpContext.Session.GetString("SessionAdmin"));
                ViewData["adminName"] = checkAdmin.adminName;
            }
            catch (Exception)
            {
                return View("~/Views/Home/login.cshtml");
            }
            return View("~/Views/Admin/donationRequest.cshtml");

        }

        public IActionResult donationSave()
        {
            try
            {
                var checkAdmin = JsonConvert.DeserializeObject<adminSessionInfo>(HttpContext.Session.GetString("SessionAdmin"));
                ViewData["adminName"] = checkAdmin.adminName;
            }
            catch (Exception)
            {
                return View("~/Views/Home/login.cshtml");
            }
            return View();
        }

        public IActionResult save_done_give(string id, string _Amount)
        {
            SqlConnection con = new SqlConnection("Data Source=Ali-Shahid;Initial Catalog=CharityManagement;Integrated Security=True");
            con.Open();

            SqlCommand command = new SqlCommand("INSERT INTO DonationGiven (DA_Id, DA_Amount) VALUES (@da_id, @da_amount)", con);
            command.Parameters.AddWithValue("@da_id", id);
            command.Parameters.AddWithValue("@da_amount", _Amount);

            if (command.ExecuteNonQuery() > 0)
                con.Close();

            try
            {
                var checkAdmin = JsonConvert.DeserializeObject<adminSessionInfo>(HttpContext.Session.GetString("SessionAdmin"));
                ViewData["adminName"] = checkAdmin.adminName;
            }
            catch (Exception)
            {
                return View("~/Views/Home/login.cshtml");
            }
            return View("~/Views/Admin/index.cshtml");

        }

        public IActionResult add_case (string title, string amount, string category, string description)
        {
            SqlConnection con = new SqlConnection("Data Source=Ali-Shahid;Initial Catalog=CharityManagement;Integrated Security=True");
            con.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Cases (C_Title,  C_Amount_Require,  C_Desceiption, C_Type) " +
                "VALUES (@c_title, @c_amount_require,  @c_desceiption, @c_type)", con);
            command.Parameters.AddWithValue("@c_title", title);
            command.Parameters.AddWithValue("@c_amount_require", amount);
            command.Parameters.AddWithValue("@c_desceiption", description);
            command.Parameters.AddWithValue("@c_type", category);

            if (command.ExecuteNonQuery() > 0)
                con.Close();

            try
            {
                var checkAdmin = JsonConvert.DeserializeObject<adminSessionInfo>(HttpContext.Session.GetString("SessionAdmin"));
                ViewData["adminName"] = checkAdmin.adminName;
            }
            catch (Exception)
            {
                return View("~/Views/Home/login.cshtml");
            }
            return View("~/Views/Admin/index.cshtml");
        }

        public IActionResult updateCase(string id)
        {
            ViewData["id"] = id;
            try
            {
                var checkAdmin = JsonConvert.DeserializeObject<adminSessionInfo>(HttpContext.Session.GetString("SessionAdmin"));
                ViewData["adminName"] = checkAdmin.adminName;
            }
            catch (Exception)
            {
                return View("~/Views/Home/login.cshtml");
            }
            return View();
        }

        public IActionResult upd_case(string id, string title, string amountRequire, string category, string description, string amountCollected, string isComplete)
        {
            SqlConnection con = new SqlConnection("Data Source=Ali-Shahid;Initial Catalog=CharityManagement;Integrated Security=True");
            con.Open();

            string cmd;
            if (isComplete == "Yes")
                cmd = "UPDATE Cases SET C_Title = @c_title,	C_Amount_Require = @amou_require,	C_Amount_collected = @amou_coll, C_Desceiption = @desc,	C_Type = @c_type,	V_IsCompleted = 1 WHERE C_Id = @c_id";
            else
                cmd = "UPDATE Cases SET C_Title = @c_title,	C_Amount_Require = @amou_require,	C_Amount_collected = @amou_coll, C_Desceiption = @desc,	C_Type = @c_type,	V_IsCompleted = 0 WHERE C_Id = @c_id";

            SqlCommand command = new SqlCommand(cmd, con);
            command.Parameters.AddWithValue("@c_id", id);
            command.Parameters.AddWithValue("@c_title", title);
            command.Parameters.AddWithValue("@amou_require", amountRequire);
            command.Parameters.AddWithValue("@amou_coll", amountCollected);
            command.Parameters.AddWithValue("@desc", description);
            command.Parameters.AddWithValue("@c_type", category);
            

            if (command.ExecuteNonQuery() > 0)
                con.Close();

            try
            {
                var checkAdmin = JsonConvert.DeserializeObject<adminSessionInfo>(HttpContext.Session.GetString("SessionAdmin"));
                ViewData["adminName"] = checkAdmin.adminName;
            }
            catch (Exception)
            {
                return View("~/Views/Home/login.cshtml");
            }
            return View("~/Views/Admin/index.cshtml");
            
        }
    }
}
