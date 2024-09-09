using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Desafio_Target_4
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string RazaoSocial { get; set; }
        public int EstadoID { get; set; }
        public Estado Estado { get; set; }
        public ICollection<Telefone> Telefones { get; set; }
    }

    public class Telefone
    {
        public int TelefoneID { get; set; }
        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }
        public string Numero { get; set; }
        public int TipoTelefoneID { get; set; }
        public TipoTelefone TipoTelefone { get; set; }
    }

    public class TipoTelefone
    {
        public int TipoTelefoneID { get; set; }
        public string Descricao { get; set; }
        public ICollection<Telefone> Telefones { get; set; }
    }

    public class Estado
    {
        public int EstadoID { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
    }

}

