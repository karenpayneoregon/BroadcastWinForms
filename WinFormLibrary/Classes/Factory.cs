#pragma warning disable CS8618
namespace WinFormLibrary.Classes;

public static class Factory
{
    private static Dispatcher _dispatcher;

    public static Dispatcher Dispatcher()
    {
        return _dispatcher ??= new Dispatcher();
    }
}