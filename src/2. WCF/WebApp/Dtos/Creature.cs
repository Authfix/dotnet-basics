using System;
using System.Runtime.Serialization;

namespace MyCompany.Codex.WebApp.Dtos
{
    [DataContract]
    public class Creature
    {
        [DataMember]
        public Guid Id { get; set; }
    }
}