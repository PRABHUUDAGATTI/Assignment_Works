using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductEntity
{
    public class SizeScale
    {

        [Key]//primary key is id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//auto generate col
        public Guid sizScaleId { get; set; }
        public string sizeScaleName { get; set; }
    }
}
