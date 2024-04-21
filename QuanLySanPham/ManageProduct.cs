using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    public class ManageProduct : IProduct
    {
        private List<Product> products { get; set; } = new List<Product>();
        public void Delete(int id, string name)
        {
            products.RemoveAll(x => x.Id ==id || x.Name ==name);
        }

        public void Insert(Product p)
        {
            throw new NotImplementedException();
        }

        public void DeleteMulti(Product p)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
