using RenderEngine.Models;

namespace RenderEngine.Interfaces;

public interface IFileParser
{
	Task<List<RenderObject>> ParseFile(string filepath);
}
