public interface IBaseControl
{
    string Show();
    void GoToDefaultPage();
    bool LoginControl(string Email, string Password);
    void GoToLogonPage();
    void IsLogin();
}