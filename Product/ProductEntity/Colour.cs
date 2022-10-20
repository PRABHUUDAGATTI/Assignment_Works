using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductEntity
{
    public class Colour
    {
        [Key]//primary key is id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//auto generate col
        public Guid colourID { get; set; }
        public string colourCode { get; set; }
        public string colourName { get; set; }
    }
}
