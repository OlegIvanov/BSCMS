﻿
namespace BSCMS.Presentation
{
    public interface ISignInView
    {
        string Username { get; }
        string Password { get; }
        string AuthenticationError { set; }
    }
}
