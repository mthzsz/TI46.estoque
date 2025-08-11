using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI46.estoque._0._1
{
    internal static class principal
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            // Exibe o formulário de login
            var loginForm = new telaLogin();
            var result = loginForm.ShowDialog();  // Mostra o formulário de login e aguarda o resultado

            if (result == DialogResult.OK) // Se o login for bem-sucedido
            {
                // Se o login for válido, abre o formulário principal do sistema
                Application.Run(new inicial()); // Substitua "inicial" pelo seu formulário principal
            }
            else
            {
                // Se o login falhar, fecha o aplicativo
                Application.Exit();
            }

        }
    }
}
