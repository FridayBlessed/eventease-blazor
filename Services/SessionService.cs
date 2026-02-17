namespace EventEase.Services
{
    public class SessionService
    {
        public string? CurrentUserName { get; private set; }
        public string? CurrentUserEmail { get; private set; }
        public bool IsLoggedIn => !string.IsNullOrEmpty(CurrentUserName);

        public event Action? OnSessionChanged;

        public void Login(string name, string email)
        {
            CurrentUserName = name;
            CurrentUserEmail = email;
            OnSessionChanged?.Invoke();
        }

        public void Logout()
        {
            CurrentUserName = null;
            CurrentUserEmail = null;
            OnSessionChanged?.Invoke();
        }
    }
}
