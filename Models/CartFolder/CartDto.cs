using ProjectAPI.Models.BaseFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models.CartFolder
{
    public class CartDto : BaseDto
    {
        // public virtual List<CartItem> CartItems { get; set; }
        public virtual int ItemId { get; set; }

        public virtual int Quantity { get; set; }

        public CartDto()
        {

        }

        public CartDto(Cart cart)
        {
            Id = cart.Id;
            ItemId = cart.ItemId;
            Quantity = cart.Quantity;
        }
    }
}
