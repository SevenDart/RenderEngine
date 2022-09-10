using System.Numerics;
using Renderer.Utilities;
using Renderer.Utilities.Implementations;

namespace Renderer.Tests;

public class ObjFileParserTests
{
    [SetUp]
    public void Setup()
    {
        _fileParser = new ObjFileParser();
    }

    private IFileParser _fileParser = null!;

    [TestCase("1 1 1", 1, 1, 1, 1)]
    [TestCase("-1.1 0.43 0", -1.1f, 0.43f, 0, 1)]
    [TestCase("1 1 1 0", 1, 1, 1, 0)]
    public void ParseVertex(string input, float x, float y, float z, float w)
    {
        //Arrange
        var expectedCoordinates = new Vector3(x, y, z);
        //Act
        var result = _fileParser.ParseVertex(input.Split());
        //Assert
        Assert.AreEqual(expectedCoordinates, result.Coordinates);
        Assert.AreEqual(w, result.WCoordinate);
    }

    [TestCase("1", 1, 0, 0)]
    [TestCase("1 1", 1, 1, 0)]
    [TestCase("1 1 1", 1, 1, 1)]
    public void ParseTextureCoordinates(string input, float x, float y, float z)
    {
        //Arrange
        var expectedCoordinates = new Vector3(x, y, z);
        //Act
        var result = _fileParser.ParseTextureCoordinates(input.Split());
        //Assert
        Assert.AreEqual(expectedCoordinates, result);
    }
    
    
    [TestCase("1 0 0", 1, 0, 0)]
    [TestCase("0 5.23 2.34", 0, 5.23f, 2.34f)]
    [TestCase("1 1 1", 1, 1, 1)]
    public void ParseNormalVector(string input, float x, float y, float z)
    {
        //Arrange
        var expectedCoordinates = new Vector3(x, y, z);
        //Act
        var result = _fileParser.ParseNormalVector(input.Split());
        //Assert
        Assert.AreEqual(expectedCoordinates, result);
    }
    
    
    
    [TestCase("1 2 3")]
    [TestCase("1 1 -1")]
    public void ParsePolygon_OnlyVertices(string input)
    {
        //Arrange
        _fileParser.ParseLine("v 1 0 0");
        _fileParser.ParseLine("v 1 1 1");
        _fileParser.ParseLine("v 1 1 2");
        //Act
        var result = _fileParser.ParsePolygon(input.Split());
        //Assert
        Assert.AreEqual(3, result.Vertices.Count);
    }
}