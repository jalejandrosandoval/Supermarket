using System.Collections.Generic;

namespace APIRESTFul.Domain.Models
{
    public class Category
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Products> Products { get; set; } = new List<Products>();

    }
}
