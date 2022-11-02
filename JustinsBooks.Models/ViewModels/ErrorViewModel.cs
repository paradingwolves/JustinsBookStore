using System;

namespace JustinsBookStore.Models.ViewModels // Updated the namespace to reflect the added projects
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
