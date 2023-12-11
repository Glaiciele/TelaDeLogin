using TelaDeLogin.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace TelaDeLogin.ViewModels
{
    public class MainWindow
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public ICommand ValidaçãoSenha { get; set; }

        public MainWindow()
        {
            this.ValidaçãoSenha = new Command(() => Validar(), () => true);

        }

        private void Validar()
        {
            if (Login == "Maria" && Senha == "12345")
            {
                MessageBox.Show("Login com Sucesso!", "Informação", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else
            {
                MessageBox.Show("Erro, Senha incorreta!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

    }
}
