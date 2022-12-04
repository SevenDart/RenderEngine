using System.Numerics;

namespace RenderEngine.Models;

public class Material
{
    public string Name { get; set; } = string.Empty;

    public IlluminationModel IlluminationModel { get; set; }
    
    public Vector3 Ambient { get; set; }
    public Vector3 Diffuse { get; set; }
    public Vector3 Specular { get; set; }
    public Vector3 Emission { get; set; }
    
    public float SpecularExponent { get; set; }
    public float Opaque { get; set; }
    
    public float OpticalDensity { get; set; }
    
    public Texture? AmbientTexture { get; set; } 
    public Texture? DiffuseTexture { get; set; } 
    
    public Texture? SpecularColorTexture { get; set; }
    public Texture? SpecularHighlightTexture { get; set; }
    
    public Texture? NormalMapTexture { get; set; }
    
    public Texture? EmissionTexture { get; set; } 
}

public enum IlluminationModel
{
    ConstantColor,
    LambertianIllumination,
    PhongIllumination
}