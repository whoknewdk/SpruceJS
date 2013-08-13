using System;
using System.Configuration;

namespace SpruceJS.Web
{
	public class SpruceJSConfigurationSection : ConfigurationSection
	{
		private static SpruceJSConfigurationSection instance;
		public static SpruceJSConfigurationSection Instance
		{
			get { return instance ?? (instance = (SpruceJSConfigurationSection)ConfigurationManager.GetSection("SpruceJS")); }
		}

		[ConfigurationProperty("minify", DefaultValue = "false", IsRequired = false)]
		public Boolean Minify
		{
			get
			{
				return (Boolean)this["minify"];
			}
			set
			{
				this["minify"] = value;
			}
		}

		[ConfigurationProperty("cache", DefaultValue = "false", IsRequired = false)]
		public Boolean Cache
		{
			get
			{
				return (Boolean)this["cache"];
			}
			set
			{
				this["cache"] = value;
			}
		}
	}
}
