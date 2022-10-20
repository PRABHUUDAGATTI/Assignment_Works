using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductEntity
{
    public class Article
    {
        [Key]//primary key is id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//auto generate col
        public Guid articleId { get; set; }
        public string articleName { get; set; }
      
        [ForeignKey("Colour")]
        public Guid colourID { get; set; }
        public Colour Colour { get; set; }
    }
}
