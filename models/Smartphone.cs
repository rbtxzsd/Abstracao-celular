using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_poo_desafio.models
{
    public abstract class Smartphone
    {
        // construtores
        public Smartphone() { }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;

        }

        // variáveis
        public string Numero { get; set; }
        private string modelo;
        private string imei;
        private int memoria;

        // getters e setters 
        public string Modelo
        {
            get => modelo;
            set => modelo = value;
        }
        public string Imei
        {
            get => imei;
            set => imei = value;
        }
        public int Memoria
        {
            get => memoria;
            set => memoria = value;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando ...");

        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação!");
        }

        public abstract void InstalarAplicativo(string nome);
    }
    

}