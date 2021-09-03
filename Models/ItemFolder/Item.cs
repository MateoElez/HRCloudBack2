﻿using Castle.MicroKernel.SubSystems.Conversion;
using ProjectAPI.Models.BaseFolder;
using ProjectAPI.Models.ItemFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class Item : TEntity
    {
        public Item() { }

        public Item(ItemDto itemDto)
        {
            Id = itemDto.Id;
            ItemName = itemDto.ItemName;
            ItemPrice = itemDto.ItemPrice;
            ItemImageUrl = itemDto.ItemImageUrl;
        }
        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public virtual string ItemName { get; set; }

        [Required]
        [Column(TypeName = "integer")]
        public virtual int ItemPrice { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public virtual string ItemImageUrl { get; set; }
    }
}

