using AppManager.Entity;
using AppManager.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Model
{
    public class InputProductModel
    {
        public long GroupId { get; set; }
        public string GroupName { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public long ColorId { get; set; }
        public string ColorName { get; set; }
        public long SizeId { get; set; }
        public string SizeName { get; set; }
        public int Quantity { get; set; }
        public string ItemPrice { get; set; }
        public string TotalPrice { get; set; }
    }

    public static class InputProductModelEmm
    {
        public static OrderInputItem ToEntity(this InputProductModel model, long orderInputId)
        {
            return new OrderInputItem()
            {
                ProductId = model.ProductId,
                ColorId = model.ColorId,
                Price = model.ItemPrice.ToPrice(),
                Quantity = model.Quantity,
                SizeId = model.SizeId,
                OrderInputId = orderInputId,
            };
        }
        public static List<OrderInputItem> ToListEntity(this IList<InputProductModel> models, long orderInputId)
        {
            var result = new List<OrderInputItem>();
            foreach (var item in models)
            {
                result.Add(item.ToEntity(orderInputId));
            }
            return result;
        }
    }
}
