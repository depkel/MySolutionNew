namespace MyLandingPage.Models
{
    public class MyApplications
    {
        public int MyAppId { get; set; }
        public string? MyApplicationName { get; set; }
        public string? MyAppUrl { get; set; }
        public bool? IsActive { get; set; }
        public string IconCss { get; set; } = "";
        public bool OpenInNewTab { get; set; } = false;
        public string Description { get; set; } = "";
         public string ColorClass { get; set; } = "bg-light";
    
    }
}