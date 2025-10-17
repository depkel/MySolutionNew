using System;
using LandingPage.Models;

namespace LandingPage.DAL;

public class DataAccessLayer
{
    public List<MyApplications> myApplications()
    {
        List<MyApplications> myApplications1 = new List<MyApplications>();
        myApplications1.Add(new MyApplications() { AppId = 1, ApplicationName = "User Management", ApplUrl = "", Active = true });
        myApplications1.Add(new MyApplications() { AppId = 2, ApplicationName = "Dashboard", ApplUrl = "", Active = true });
        myApplications1.Add(new MyApplications() { AppId = 3, ApplicationName = "Order Management", ApplUrl = "", Active = true });
        
        
        
        return myApplications1;
    }

}
