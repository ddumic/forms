namespace FOI.PI.MusicBandApp.Desktop.Helper
{
    public class AccountHelper
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public int? AccountType { get; set; }

        private static AccountHelper _instance;
        private static object syncLock = new object();


        protected AccountHelper()
        {

        }

        public static void Logout()
        {
            _instance = new AccountHelper();
        }

        public static AccountHelper GetInstance()
        {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new AccountHelper();
                    }
                }
            }

            return _instance;
        }
    }
}
