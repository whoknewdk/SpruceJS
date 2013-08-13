
namespace SpruceJS.Core.Minification
{
	public interface IMinificator
	{
		MinifyResult Minify(JSModuleList Modules);
	}
}
