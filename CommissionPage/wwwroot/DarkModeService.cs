namespace CommissionPage.wwwroot;

public class DarkModeService
{
    public bool IsDarkMode { get; private set; } = false;
    public event Action? OnDarkModeChange;
    public void ToggleDarkMode(bool isDarkMode)
    {
        IsDarkMode =  isDarkMode;
        OnDarkModeChange?.Invoke();
    }
    
}