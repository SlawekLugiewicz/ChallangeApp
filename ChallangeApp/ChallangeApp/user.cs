﻿
namespace ChallangeApp
{
    public class User
    {
        private List<int> score = new List<int>();

        public User(string login, string password)
        {
            this.Login = login;
            this.Passwrod = password;

        }

        public string Login { get; private set; }

        public string Passwrod { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();

            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);

        }
    }
}
