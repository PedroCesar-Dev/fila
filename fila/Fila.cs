using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
    public class Fila<T>
    {
        private List<T> queue;
        public Fila()
        {
            queue = new List<T>();
        }
        public void Inserir(T elemento)
        {
            queue.Add(elemento);
        }
        public bool ExisteDado(T elemento)
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("A fila está vazia.");
            }
            return queue[0].Equals(elemento);
        }
        public bool isEmpty()
        {
            return queue.Count == 0;
        }
        public T Recuperar()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("A fila está vazia.");
            }
            return queue[0];
        }
        public void Alterar(T elemento)
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("A fila está vazia.");
            }
            queue[0] = elemento;
        }
        public void Remover()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("A fila está vazia.");
            }
            queue.RemoveAt(0);
        }
        public int Tamanho()
        {
            return queue.Count;
        }
        public void Limpa()
        {
            queue.Clear();
        }
    }
}
