using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductEntity
{
    public  class Product
    {

        [Key]//primary key is id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//auto generate col
        public Guid productId { get; set; }
        public string productName { get; set; }
        public string productCode { get; set; }
        public int productYear { get; set; }
        [ForeignKey("SizeScale")]
        public Guid sizScaleId { get; set; }
        public SizeScale SizeScale { get; set; }
        public int channelId { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
       
        public List<Article> articles { get; set; }
        //public Article Article { get; set; }

    }
}
