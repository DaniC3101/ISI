namespace Models
{
    public class Utilizador
    {
        #region Attributes

        string auth0UserId;
        string nome;
        string email;
        string imgUrl;

        #endregion

        #region Properties
        public string Auth0UserId
        {
            get { return auth0UserId; }
            set { auth0UserId = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string ImgUrl
        {
            get { return imgUrl; }
            set { imgUrl = value; }
        }
        #endregion

        #region Constructors
        public Utilizador()
        {
        }

        public Utilizador(string auth0UserId, string nome, string email, string imgUrl)
        {
            Auth0UserId = auth0UserId;
            Nome = nome;
            Email = email;
            ImgUrl = imgUrl;
        }
        #endregion
    }
}