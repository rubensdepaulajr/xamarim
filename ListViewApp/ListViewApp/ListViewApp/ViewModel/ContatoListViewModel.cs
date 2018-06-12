using ListViewApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewApp.ViewModel
{
    public class ContatoListViewModel
    {
        //define a fonte do listview e a quantidade de itens a ser exibida no rodape
        public IList<Contato> Items { get; private set; }
        public int ItemsCount { get; private set; }
        //define o telefone a ser exibido na view (não existe no model)
        public string Telefone { get; private set; } = "+55 (11) 9807-0055";
        //construtor
        public ContatoListViewModel()
        {
            var repo = new ContatoService();
            Items = repo.TodosContatos.OrderBy(c => c.Nome).ToList();
            ItemsCount = repo.TodosContatos.Count;
        }
    }
}
