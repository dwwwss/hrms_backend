﻿namespace hrms_backend
{
    public class EmailConfiguration
    {
    public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }
        public bool EnableSsl { get; set; }
        public string FromEmail { get; set; }
        public string FromDisplayName { get; set; }
    }

}
