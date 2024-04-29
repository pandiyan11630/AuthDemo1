using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace AuthDemo1;

public class MyAccountLogin:Controller
{

    public IActionResult Login(){
        return View();
    }

    [HttpPost]
    public IActionResult Login(string userName,string passWord){
        ClaimsIdentity myIdentity = null;
        ClaimsPrincipal userPrincipal=null;
        if(userName.Equals("Pandiyan") && passWord.Equals("password")){
            myIdentity=new ClaimsIdentity(new[]{
                new Claim(ClaimTypes.Name,userName),
                new Claim(ClaimTypes.Role,"CTO")
            },CookieAuthenticationDefaults.AuthenticationScheme);
            
            userPrincipal = new ClaimsPrincipal(myIdentity);
            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,userPrincipal);
            return RedirectToAction("Index","Home");
        }
        if(userName.Equals("Ajay") && passWord.Equals("password")){
            myIdentity=new ClaimsIdentity(new[]{
                new Claim(ClaimTypes.Name,userName),
                new Claim(ClaimTypes.Role,"Project Manager")
            },CookieAuthenticationDefaults.AuthenticationScheme);
            
            userPrincipal = new ClaimsPrincipal(myIdentity);
            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,userPrincipal);
            return RedirectToAction("Index","Home");
        }
        if(userName.Equals("Ashok") && passWord.Equals("password")){
            myIdentity=new ClaimsIdentity(new[]{
                new Claim(ClaimTypes.Name,userName),
                new Claim(ClaimTypes.Role,"Employee")
            },CookieAuthenticationDefaults.AuthenticationScheme);
            
            userPrincipal = new ClaimsPrincipal(myIdentity);
            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,userPrincipal);
            return RedirectToAction("Index","Home");
        }
        return View();
    }
    

    public IActionResult Logout(){
        var logout=HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Login","MyAccountLogin");
    }
}
