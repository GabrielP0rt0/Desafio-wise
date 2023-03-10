using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransferenciaAPi.Data.Entidades
{
    /// <summary>
    /// Inserindo a tabela de Contas onde teremos os dados mais "superficiais" dos usuários
    /// </summary>
    [Table("Conta")]
    public class Conta
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("id_conta")]
        public int IdConta { get; set; }
        [Column("id_usuario_private")]
        public int IdUsuarioPrivate { get; set; }
        [Column("id_usuario_public")]
        public int IdUsuarioPublic { get; set; }
        [Column("saldo")]
        public decimal Saldo { get; set; }
    }
}
