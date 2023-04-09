namespace WinFormLibrary.Classes;

public static class Factory
{
    private static Broadcaster _broadcaster;

    public static Broadcaster Broadcaster()
    {
        return _broadcaster ??= new Broadcaster();
    }
}