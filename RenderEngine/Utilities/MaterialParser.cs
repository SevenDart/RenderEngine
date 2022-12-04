using System.Numerics;
using RenderEngine.Interfaces;
using RenderEngine.Models;

namespace RenderEngine.Utilities;

public class MaterialParser : IMaterialParser
{
	private List<Material> _materials = new();

	private string _currentFilepath = null!;
    public async Task<List<Material>> ParseFile(string filepath)
    {
	    _currentFilepath = filepath;
	    _materials.Clear();
	    using var file = new StreamReader(filepath);

        while (!file.EndOfStream)
        {
            var line = await file.ReadLineAsync();
            if (line != null && line.Length > 0) 
                ParseLine(line);
        }

        return _materials;
    }
    
    private void ParseLine(string input)
	{
		var spaceIndex = input.IndexOf(' ');
		if (spaceIndex == -1)
		{
			return;
		}

		var lineType = input.Substring(0, spaceIndex);
		var inputValues = input.Substring(spaceIndex + 1).Split(' ', StringSplitOptions.RemoveEmptyEntries);

		switch (lineType)
		{
			case "newmtl":
				var material = new Material()
				{
					Name = string.Concat(inputValues)
				};
				_materials.Add(material);
				break;
			
			case "Ns":
				_materials.Last().SpecularExponent = float.Parse(inputValues[0]);
				break;
			
			case "Ka":
				_materials.Last().Ambient = ParseVector(inputValues);
				break;
			
			case "Kd":
				_materials.Last().Diffuse = ParseVector(inputValues);
				break;
			
			case "Ks":
				_materials.Last().Specular = ParseVector(inputValues);
				break;
			
			case "d":
				_materials.Last().Opaque = float.Parse(inputValues[0]);
				break;
			
			case "Ni":
				_materials.Last().OpticalDensity = float.Parse(inputValues[0]);
				break;
			
			case "illum":
				_materials.Last().IlluminationModel = (IlluminationModel)int.Parse(inputValues[0]);
				break;
			
			case "map_Kd":
				_materials.Last().DiffuseTexture = new Texture(CreateFullPath(inputValues[0]), TextureType.Diffusion);
				break;
			
			case "map_Ka":
				_materials.Last().AmbientTexture = new Texture(CreateFullPath(inputValues[0]), TextureType.Diffusion);
				break;
			
			case "map_Ks":
				_materials.Last().SpecularColorTexture = new Texture(CreateFullPath(inputValues[0]), TextureType.Specular);
				break;
			
			case "map_Ns":
				_materials.Last().SpecularHighlightTexture = new Texture(CreateFullPath(inputValues[0]), TextureType.Specular);
				break;
			
			case "bump":
				_materials.Last().NormalMapTexture = new Texture(CreateFullPath(inputValues[0]), TextureType.Normal);
				break;
		}
	}

    private Vector3 ParseVector(string[] inputValues)
    {
	    return new Vector3()
	    {
		    X = float.Parse(inputValues[0]),
		    Y = float.Parse(inputValues[1]),
		    Z = float.Parse(inputValues[2])
	    };
    }

    private string CreateFullPath(string filepath)
    {
	    if (!Path.IsPathRooted(filepath))
	    {
		    filepath = Path.Combine(Path.GetDirectoryName(_currentFilepath), filepath);
	    }

	    return filepath;
    }
}