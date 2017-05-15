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
    public partial class Cart : System.Web.UI.Page
    {
        private CartServiceClient cs = new CartServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Account/Login.aspx");
                Response.End();
                return;
            }

            string userId = User.Identity.GetUserId();
            var cart = (CartService.Cart)Session["cart"];
            if (cart == null)
            {
                cart = cs.CreateCart(userId);
                Session["cart"] = cart;
            }

            cart = RefreshCart(cart.CartID);
        }

        private CartService.Cart RefreshCart(int cartId)
        {
            var cart = cs.GetCart(cartId);

            gvCart.DataSource = cart.Books;
            gvCart.DataBind();

            lblSum.Text = cart.Books.Sum(x => x.Quantity * x.Book.Price).ToString("G");
            return cart;
        }

        protected void gvCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int bookId = Convert.ToInt32(e.Keys["BookID"]);
            int cartId = ((CartService.Cart)Session["cart"]).CartID;
            bool success = cs.RemoveFromCart(cartId, bookId);
            if (success)
            {
                RefreshCart(cartId);
            }
            else
            {
                lblErrorDeleting.Visible = true;
            }
        }

        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            int cartId = ((CartService.Cart)Session["cart"]).CartID;
            cs.SetDeliveryOptions(cartId, new DeliveryOption() { DeliveryOptionID = Convert.ToInt32(listDeliveryOptions.SelectedValue) });
            cs.SetPaymentMethod(cartId, new PaymentMethod() { PaymentMethodID = Convert.ToInt32(listPaymentMethods.SelectedValue) });

            Response.Redirect("~/CartPay.aspx");
        }
    }
}
