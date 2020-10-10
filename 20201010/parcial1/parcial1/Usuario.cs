using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace parcial1
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [MaxLength(50)]
        [MinLength(10)]
        public string Nombre { get; set; }

        [Required]
        [Column("password", TypeName = "char(20)")]
        public string Clave { get; set; }

        [NotMapped]
        public string Imagen { get; set; }



    }
}
