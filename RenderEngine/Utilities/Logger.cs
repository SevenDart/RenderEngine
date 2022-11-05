namespace RenderEngine.Utilities;

public class Logger: IDisposable
{
    private readonly StreamWriter _writer;
    private readonly object _lockObject = new();

    public Logger()
    {
        _writer = new StreamWriter("log.txt");
    }

    public void Log(string logString)
    {
        lock (_lockObject)
        {
            _writer.WriteLine(logString);
            _writer.Flush();
        }
    }

    public void Dispose()
    {
        _writer.Dispose();
    }
}