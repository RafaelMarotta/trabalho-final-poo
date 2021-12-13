﻿using System;

namespace CadastroClientes.model
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
