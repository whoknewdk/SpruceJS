﻿using System;
using System.Configuration;

namespace SpruceJS.Web.Configuration
{
	public class SpruceConfigurationSection : ConfigurationSection
	{
		private static SpruceConfigurationSection instance;
		public static SpruceConfigurationSection Instance
		{
			get
			{
				if (instance != null)
					return instance;

				return instance = ConfigurationManager.GetSection("SpruceJS") as SpruceConfigurationSection ?? new SpruceConfigurationSection();
			}
		}

		[ConfigurationProperty("minify", DefaultValue = "true", IsRequired = false)]
		public bool Minify
		{
			get
			{
				return (bool)this["minify"];
			}
			set
			{
				this["minify"] = value;
			}
		}
	}
}
