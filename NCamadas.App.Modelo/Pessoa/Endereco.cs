﻿namespace NCamadas.App.Modelo.Pessoa
{
    public class Endereco
    {
        public string Logradouro { get; internal set; }
        public int Numero { get; internal set; }
        public string Complemento { get; internal set; }
        public string Bairro { get; internal set; }
        public string Cidade { get; internal set; }
        public string Estado { get; internal set; }      
        
        public Cliente Cliente { get; set; }
    }
}
