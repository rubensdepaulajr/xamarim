using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ListViewApp.Model
{
    public class ContatoService
    {
        /// <summary>
        /// Obtém a lista com todos os contatos registrados.
        /// </summary>
        public ObservableCollection<Contato> TodosContatos { get; private set; }

        /// <summary>
        /// Inicializa uma instância dessa classe populando a lista de contatos.
        /// </summary>
        public ContatoService()
        {
            TodosContatos = new ObservableCollection<Contato>
            {
                new Contato {Nome = "Jose Macoratti", Email = "egestas@anequeNullam.co.uk"},
                new Contato {Nome = "Maria Julia", Email = "a.tortor@Sed.net"},
                new Contato {Nome = "Osmar Bueno", Email = "tristique@faucibusutnulla.net"},
                new Contato {Nome = "Yuri Lima", Email = "montes.nascetur.ridiculus@fringillaest.ca"},
                new Contato {Nome = "Leonardo Silveira", Email = "imperdiet.ullamcorper@Quisque.com"},
                new Contato {Nome = "Nadir Figueiredo", Email = "adipiscing@anteipsum.ca"},
                new Contato {Nome = "Emely Soares", Email = "aliquet.molestie.tellus@Nam.net"},
            };
        }
    }
}
