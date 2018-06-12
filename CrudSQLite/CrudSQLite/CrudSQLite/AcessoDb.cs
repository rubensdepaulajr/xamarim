using System;
using SQLite.Net;
using System.IO;
using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;
using CrudSQLite.Models;

namespace CrudSQLite
{
    public class AcessoDb : IDisposable
    {
        private SQLiteConnection conexaoSQLite;

        public AcessoDb()
        {
            var config = DependencyService.Get<IConfig>();
            conexaoSQLite = new SQLiteConnection(config.Plataforma, Path.Combine(config.DiretorioSqLite, "Cadastro.db3"));
            conexaoSQLite.CreateTable<Cliente>();
        }

        public void InserirCliente(Cliente cliente)
        {
            conexaoSQLite.Insert(cliente);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            conexaoSQLite.Update(cliente);
        }

        public void DeletarCliente(Cliente cliente)
        {
            conexaoSQLite.Delete(cliente);
        }

        public Cliente GetCliente(int codigo)
        {
            return conexaoSQLite.Table<Cliente>().FirstOrDefault(c => c.Id == codigo);
        }

        public List<Cliente> GetClientes()
        {
            return conexaoSQLite.Table<Cliente>().OrderBy(c => c.Nome).ToList();
        }

        public void Dispose()
        {
            conexaoSQLite.Dispose();
        }
    }
}