using RenderEngine.Models;

namespace RenderEngine.Interfaces;

public interface IMaterialParser
{
    Task<List<Material>> ParseFile(string filepath);
}