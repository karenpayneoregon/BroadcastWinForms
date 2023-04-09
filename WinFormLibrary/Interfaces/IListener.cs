namespace WinFormLibrary.Interfaces;

public interface IMessageListener1 
{
    void OnListen(string message, Form form);
    void OnListen(int value, Form form);
    void OnListen(object sender, Form form);
}