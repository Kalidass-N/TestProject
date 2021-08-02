using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public interface IPageInterface
    {
        void LaunchURL(string url);
        void EnterUsername(string username);
        void EnterPassword(string password);
        void ClickLogin();
        string GetErrorMessage();
    }
}
