using CsharpEgitimKampi301.BusinessLayer.Abstract;
using CsharpEgitimKampi301.BusinessLayer.Concrete;
using CsharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CsharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpEgitimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService=new CategoryManager(new EfCategoryDal());
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll();
            cmbkategori.DataSource= values;
            cmbkategori.DisplayMember = "CategoryName";
            cmbkategori.ValueMember = "CategoryId";

        }

        ProductManager produckManager = new ProductManager(new EfProductDal());
        private void btnlist_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource= values;   
        }

        private void btnlist2_Click(object sender, EventArgs e)
        {
            var values= _productService.GetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            MessageBox.Show("Silme işlemi yapıldı.");

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = int.Parse(cmbkategori.SelectedValue.ToString());
            product.ProductPrice=decimal.Parse(txtfiyat.Text);
            product.ProducName=txtname.Text;
            product.ProductDescription=txtaciklama.Text;
            product.ProductStock=int.Parse(txtstok.Text);
            _productService.TInsert(product);
            MessageBox.Show("Ekleme işlemi yapıldı.");
        }

        private void btnidgetir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value =_productService.TGetById(id);
            dataGridView1.DataSource = value;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = _productService.TGetById(id);
            value.ProductDescription=txtaciklama.Text;
            value.CategoryId = int.Parse(cmbkategori.SelectedValue.ToString());
            value.ProductPrice=Decimal.Parse(txtstok.Text);
            value.ProductStock = int.Parse(txtstok.Text);
            value.ProducName= txtname.Text;
            _productService.TUpdate(value);
            MessageBox.Show("Güncelleme işlemi yapıldı.");

        }
    }
}
