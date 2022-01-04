using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace MyCompany.Codex.Dtos
{
    [DataContract]
    public class CreatureDto
    {
        [Required]
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}