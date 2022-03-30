using System;

namespace PublisherPortal.ViewModels;

public class ErrorViewModel
{
    public string Message { get; internal set; }

    public Exception Exception { get; internal set; }

    public bool ShowException { get; internal set; }
}