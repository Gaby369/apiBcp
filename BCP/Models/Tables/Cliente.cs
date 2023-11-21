using System;
using System.Collections.Generic;

namespace BCP.Models.Tables
{
    public partial class Cliente
    {
        public int IdIn { get; set; }
        public int? DocumentoVc { get; set; }
        public string? NombresVc { get; set; }
        public string? PaternoVc { get; set; }
        public string? MaternoVc { get; set; }
        public DateTime? FechaNacimientoDt { get; set; }
        public string? EstadoCivilVc { get; set; }
        public string? DomicilioVc { get; set; }
        public string? NacionalidadVc { get; set; }
        public DateTime? FechaRegistroDt { get; set; }
        public string? UsuarioRegistroVc { get; set; }
    }
}
