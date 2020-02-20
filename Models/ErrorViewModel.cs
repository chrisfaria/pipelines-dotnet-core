using System;

namespace pipelines_dotnet_core.Models
{
    public class ErrorViewModel
    {
        public string RequestIdx { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}