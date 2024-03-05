using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class Inspection
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Estados { get; set; } = string.Empty;

        [StringLength(200)]
        public string Detalles { get; set; } =string .Empty;

        public int TipoInspecionId { get; set; }

        public InspectionType? TipoInspecion { get; set;}


    }
}
