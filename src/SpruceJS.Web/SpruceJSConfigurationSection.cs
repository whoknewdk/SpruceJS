using System;
using System.Configuration;

namespace SpruceJS.Web
{
	public class SpruceJSConfigurationSection : ConfigurationSection
	{
		private static SpruceJSConfigurationSection instance;
		public static SpruceJSConfigurationSection Instance
		{
			get
			{
				if (instance != null)
					return instance;

				return instance = ConfigurationManager.GetSection("SpruceJS") as SpruceJSConfigurationSection ?? new SpruceJSConfigurationSection();
			}
		}

		[ConfigurationProperty("minify", DefaultValue = "true", IsRequired = false)]
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
