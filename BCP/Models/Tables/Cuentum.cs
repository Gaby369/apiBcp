using System;
using System.Collections.Generic;

namespace BCP.Models.Tables
{
    public partial class Cuentum
    {
        public int IdIn { get; set; }
        public int? FkClienteIdIn { get; set; }
        public string? NombreCuentaVc { get; set; }
        public string? TipoCuentaVc { get; set; }
        public string? TipoMonedaVc { get; set; }
        public string? SucursalVc { get; set; }
        public DateTime? FechaRegistroDt { get; set; }
        public string? UsaurioRegistroVc { get; set; }
    }
}
