using System;
using System.Configuration;

namespace SpruceJS.Core.Config
{
	public class SpruceJSConfigurationSection : ConfigurationSection
	{
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

		[ConfigurationProperty("cache", DefaultValue = "cache", IsRequired = false)]
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
