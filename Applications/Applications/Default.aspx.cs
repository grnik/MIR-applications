using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ApplicationsMir.DAL;

namespace ApplicationsMir
{
    public partial class _Default : System.Web.UI.Page
    {
        private List<Applications> applications;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                //EntityDataSource dataSource = new EntityDataSource(new EntityConnection("name=ApplicationsEntities"));
                using(ApplicationsEntities applicationsEntities = new ApplicationsEntities("name=ApplicationsEntities"))
                {
                    applications = applicationsEntities.Applications.ToList();
                }
            }
        }
    }
}
