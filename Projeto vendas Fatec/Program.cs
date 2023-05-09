using Bella_Bijoux;
using Projeto_vendas_Fatec.br.com.projeto.view;
using Projeto_vendas_Fatec.br.com.pvf.view;
using Sistema_locadora.br.com.locadora.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_vendas_Fatec
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmenu());
        }
    }
}
