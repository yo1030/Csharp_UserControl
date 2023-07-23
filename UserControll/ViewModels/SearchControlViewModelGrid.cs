using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControll.Domain;

namespace UserControll.ViewModels
{
    public sealed class SearchControlViewModelGrid
    {
        private ProductEntity _entity;

        public SearchControlViewModelGrid(ProductEntity entity)
        {
            _entity = entity;
        }

        public string ProductId => _entity.ProductId.ToString().PadLeft(4, '0');
        public string ProductName => _entity.ProductName;
        public string Price => _entity.Price + "円";
    }
}
