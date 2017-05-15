using BookstoreWebForms.CartService;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookstoreWebForms
{
    public partial class CartPay : System.Web.UI.Page
    {

        private const string _ePayClientID = "D165763063";
        private const string _secretEPayKey = "VJQPCBT3LXJ4SQ6KUPW1GZDK73IG9RCT778Z51G8UWFZGQL4C6HBS1EALL6F6B4D";
        private CartServiceClient cs = new CartServiceClient();

        protected string _encoded;
        protected string _checksum;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //подготвяме заявка към ePay
            {
                if (!User.Identity.IsAuthenticated)
                {
                    Response.Redirect("~/Account/Login.aspx");
                    Response.End();
                    return;
                }

                var cart = (CartService.Cart)Session["cart"];
                if (cart == null)
                {
                    cart = cs.CreateCart(User.Identity.GetUserId());
                    Session["cart"] = cart;
                }
                int cartId = ((CartService.Cart)Session["cart"]).CartID;
                cart = cs.GetCart(cartId);
                decimal sum = cart.Books.Sum(x => x.Book.Price * x.Quantity);

                string request = $"MIN={_ePayClientID}\r\n"
                    + $"INVOICE={1000 + cart.CartID}\r\n"
                    + $"AMOUNT={sum.ToString("G")}\r\n"
                    + "CURRENCY=BGN\r\n"
                    + $"EXP_TIME={DateTime.Now.AddDays(2).ToString("dd.MM.yyyy")}\r\n"
                    + "DESCR=Buying books";

                _encoded = Convert.ToBase64String(Encoding.ASCII.GetBytes(request));
                _checksum = HMACSHA1(_encoded, _secretEPayKey);
            }
            else //получаваме потвърждение от ePay
            {
                string encoded = Request.Form["ENCODED"];
                string checksum = Request.Form["CHECKSUM"];
                if (checksum != HMACSHA1(encoded, _secretEPayKey))
                {
                    //невалиден отговор
                }
                else
                {
                    //обработваме статуса на плащането
                    //обикновен стринг като например: "INVOICE=1230001:STATUS=PAID:PAY_TIME=YYYYMMDDhhmmss:STAN=[6 числа]:BCODE=[6 числа/букви]"
                    string decoded = Encoding.ASCII.GetString(Convert.FromBase64String(encoded));
                    string[] kvPairs = decoded.Split(':');
                    string invoice = "", status = "";
                    foreach (var pair in kvPairs)
                    {
                        string[] kv = pair.Split('=');
                        switch (kv[0])
                        {
                            case "INVOICE":
                                invoice = kv[1];
                                break;
                            case "STATUS":
                                status = kv[1];
                                break;
                        }
                    }
                    //изпращаме заявка към сървис-а със статуса на плащането...
                    //...    
                    //ако всичко е наред, връщаме ОК, за да не получаваме повече известия за това плащане
                    Response.Write($"INVOICE={invoice}:STATUS=OK");
                    Response.End();
                }
            }
        }
        private string HMACSHA1(string text, string secretkey)
        {
            byte[] byteArray = Encoding.ASCII.GetBytes(text);
            byte[] key = Encoding.ASCII.GetBytes(secretkey);
            using (var h = new HMACSHA1(key))
            {
                var hashArray = h.ComputeHash(byteArray);
                var result = new StringBuilder();
                foreach (var b in hashArray)
                {
                    result.Append(b.ToString("X2"));
                }
                return result.ToString();
            }
        }
    }
}