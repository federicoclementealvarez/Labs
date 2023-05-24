
using System.Collections;
using System.ComponentModel;
using System.Dynamic;

namespace Clases
{

    public class BD
    {
        private List<Usuario> usuarios;

        public BD()
        {
            usuarios = new List<Usuario>();
        }

        public int GetLength()
        {
            return (usuarios.Count);
        }
        public void AddUser(string name, string pass)
        {
            usuarios.Add(new Usuario(name, pass));
        }

        public int IndexUser(string name)
        {
            int index=0;
            foreach(Usuario user in usuarios)
            {
                if (user.Username == name) {
                    break;
                }
                index++;
            }
            return (index);
        }

        public bool ValidatePass(string pass, int index)
        {
            return (usuarios[index].ValidatePass(pass));
        }
    }

    public class Usuario
    {
        private string password;
        private string username;
        public Usuario(string name, string pass)
        {
            password = pass;
            username = name;
        }
        public string Password
        {
            get => password;
            set
            {
                password = value;
            }
        }

        public string Username
        {
            get => username;
            set
            {
                username = value;
            }
        }
        public bool ValidatePass(string pass) { return (pass == password); }
    }
}