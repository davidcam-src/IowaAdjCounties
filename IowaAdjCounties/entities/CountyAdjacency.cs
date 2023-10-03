using System.ComponentModel.DataAnnotations;

namespace IowaAdjCounties.entities
{
    public class CountyAdjacency
    {
        [Key]
        public int CountyAdjacencyId { get; set; }
        public int CountyID { get; set; }
        public int AdjacentCountyID { get; set; }
    }
}
