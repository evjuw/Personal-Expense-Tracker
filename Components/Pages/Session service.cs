public class UserSessionService
{
    private string _username;
    private string _preferredCurrency;

    public string Username
    {
        get => _username;
        set => _username = value;
    }

    public string PreferredCurrency
    {
        get => _preferredCurrency;
        set => _preferredCurrency = value;
    }

   
    public void ClearSession()
    {
        _username = null;
        _preferredCurrency = null;
    }
}
