using System.ComponentModel.DataAnnotations.Schema;

namespace BikeMarket.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Make Make { get; set; }

        [ForeignKey(nameof(Make))]
        public int MakeFK { get; set; }
    }
}
