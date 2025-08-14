using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_poo_desafio.models
{
    public class Iphone : Smartphone
    {
        // construtores
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public Iphone(){ }

        // método de assinatura sobrescrito
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo: {nome} no Iphone ...");
        }
    }
}