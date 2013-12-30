﻿
namespace SpruceJS.Core.Content
{
	public class ExternalItem
	{
		public string Url { get; private set; }
		public string Content { get; private set; }

		public ExternalItem(string url, string content)
		{
			Url = url;
			Content = content;
		}

		public override int GetHashCode()
		{
			return Url.GetHashCode();
		}

		public override bool Equals(object o)
		{
			var item = (ExternalItem)o;
			return item.Url.Equals(Url);
		}
	}
}
