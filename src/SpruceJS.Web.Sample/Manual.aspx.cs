using System;
using SpruceJS.Core.Config;
using SpruceJS.Core.Engine;

namespace SpruceJS.Web.Sample
{
	public partial class Manual : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			IAppConfig config = new WebAppConfig("app.config", Context);

			IEngine engine = new WebEngine(config, Context);
			
			Response.ContentType = "text/javascript";
			Response.Write(engine.Render());
		}
	}
}