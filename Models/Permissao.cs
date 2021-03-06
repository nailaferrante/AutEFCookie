using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutEFCookie.Models
{
    public class Permissao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPermissao { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 4)]
        public string Nome { get; set; }

        public ICollection<UsuarioPermissao> UsuarioPermissao { get; set; }
    }
}