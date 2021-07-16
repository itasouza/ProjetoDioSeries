using DIO.Series.Interfaces;
using System;
using System.Collections.Generic;


namespace DIO.Series
{
    public class SerieRepository : IRepository<Serie>
    {

        private List<Serie> ListaSerie = new List<Serie>();

        public void Atualizar(int id, Serie objeto)
        {
            ListaSerie[id] = objeto;
        }

        public void Excluir(int id)
        {
            ListaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            ListaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}
