using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.SetUp();
        }

        private void SetUp()
        {
            
            
            for(int i=0;i<=1;i++)
            {
                this.Makepage(i);
            }

           
        }

        private void Makepage(int i)
        {
            Panel pageBlock = new Panel();
            pageBlock.CssClass = "pageblock";

            Label l = new Label();
            l.Text ="Page:" +  i.ToString();
            pageBlock.Controls.Add(l);

            this.Panel1.Controls.Add(pageBlock);
        }
    }
}