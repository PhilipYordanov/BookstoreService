using BookstoreWebForms.CartService;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookstoreWebForms
{
    public partial class ViewBook : System.Web.UI.Page
    {

        private int _bookId;

        protected void Page_Load(object sender, EventArgs e)
        {
            _bookId = Convert.ToInt32(this.Request.QueryString["id"]);
        }
        protected void BuyButton_Click(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Account/Login.aspx");
                Response.End();
                return;
            }

            string userId = User.Identity.GetUserId();

            using (var cs = new CartServiceClient())
            {
                var cart = (CartService.Cart)Session["cart"];
                if (cart == null)
                {
                    cart = cs.CreateCart(userId);
                    Session["cart"] = cart;
                }

                bool success = cs.AddToCart(cart.CartID, _bookId);
                if (success)
                {
                    Response.Redirect("~/Cart.aspx");
                }
            }
        }
    }
}