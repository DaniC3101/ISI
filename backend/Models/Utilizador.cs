namespace Models
{
    public class Utilizador
    {
        string auth0UserId;

        public string Auth0UserId
        {
            get { return auth0UserId; }
            set { auth0UserId = value; }
        }

        public Utilizador()
        {
        }

        public Utilizador(string auth0UserId)
        {
            Auth0UserId = auth0UserId;
        }
    }
}