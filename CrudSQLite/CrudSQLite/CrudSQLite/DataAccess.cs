using System;
using SQLite.Net;
using System.IO;
using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;
using CrudSQLite.Models;

namespace CrudSQLite
{
    public class DataAccess : IDisposable
    {
        private SQLiteConnection conexaoSQLite;

        public DataAccess()
        {
            var config = DependencyService.Get<IConfig>();
            conexaoSQLite = new SQLiteConnection(config.Plataforma, Path.Combine(config.DiretorioSqLite, "Cadastro.db3"));
            conexaoSQLite.CreateTable<Aluno>();
        }

        public void InserirAluno(Aluno aluno)
        {
            conexaoSQLite.Insert(aluno);
        }

        public void AtualizarAluno(Aluno aluno)
        {
            conexaoSQLite.Update(aluno);
        }

        public void DeletarAluno(Aluno aluno)
        {
            conexaoSQLite.Delete(aluno);
        }

        public Aluno GetAluno(int codigo)
        {
            return conexaoSQLite.Table<Aluno>().FirstOrDefault(a => a.Id == codigo);
        }

        public List<Aluno> GetAlunos()
        {
            return conexaoSQLite.Table<Aluno>().OrderBy(a => a.Nome).ToList();
        }

        public void Dispose()
        {
            conexaoSQLite.Dispose();
        }
    }
}