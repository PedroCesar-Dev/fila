using Fila;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Fila<int> fila = new Fila<int>();
        fila.Inserir(1);
        fila.Inserir(2);
        fila.Inserir(3);
        Console.WriteLine("Tamanho da fila: " + fila.Tamanho());
        Console.WriteLine("Primeiro elemento: " + fila.Recuperar());
        fila.Alterar(10);
        Console.WriteLine("Primeiro elemento após alteração: " + fila.Recuperar());
        fila.Remover();
        Console.WriteLine("Primeiro elemento após remoção: " + fila.Recuperar());
        Console.WriteLine("Existe dado 2 no início? " + fila.ExisteDado(2));
        fila.Limpa();
        Console.WriteLine("Tamanho da fila após limpeza: " + fila.Tamanho());
    }
}