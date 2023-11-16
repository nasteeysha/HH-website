using OnlineShop.Models;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;

namespace OnlineShop
{
    public class Cookies
    {
        public static string GetSign(string s)
        {
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
            byte[] hash = provider.ComputeHash(Encoding.Default.GetBytes(s));
            return BitConverter.ToString(hash).ToLower().Replace("-", "");
        }

        public static bool CheckLogin(Page page)
        {
            bool t = false;
            HttpCookie login = page.Request.Cookies["username"];
            HttpCookie sign = page.Request.Cookies["sign"];
            HttpCookie role = page.Request.Cookies["role"];
            HttpCookie id = page.Request.Cookies["id"];
            if (login != null && role != null && sign != null)
            {
                if (sign.Value == GetSign(login.Value + "secretCode" + role.Value +id.Value))
                    t = true;
            }
            return t;
        }

        public static void CheckLoginAndRedirectToLogin(Page page)
        {
            if (CheckLogin(page) == false)
                page.Response.Redirect("Login.aspx");
        }
        public static void CheckLoginAndRedirectToMain(Page page)
        {
            if (CheckLogin(page) == false)
                page.Response.Redirect("MainPage.aspx");
        }
        public static string Role(Page page)
        {
            if (page.Request.Cookies["role"] != null)
                return page.Request.Cookies["role"].Value.ToString();
            else
                return "";
        }
        public static int GetUserId(Page page)
        {
            if (page.Request.Cookies["id"] != null)
                return System.Convert.ToInt32(page.Request.Cookies["id"].Value);
            else
                Cookies.CheckLoginAndRedirectToMain(page);
            return 0;
        }
    }
}