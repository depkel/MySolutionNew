using System;

namespace LandingPage.Models;

public class MyApplications
{
    public int AppId { get; set; }
    public string? ApplicationName { get; set; }
    public string? ApplUrl { get; set; }
    public bool Active { get; set; }
}
