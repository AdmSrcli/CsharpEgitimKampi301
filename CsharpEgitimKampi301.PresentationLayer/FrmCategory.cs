using CsharpEgitimKampi301.BusinessLayer.Abstract;
using CsharpEgitimKampi301.BusinessLayer.Concrete;
using CsharpEgitimKampi301.DataAccessLayer.Abstract;
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
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;
        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }
       

        private void btnlist_Click(object sender, EventArgs e)
        {
            var categoryyValues = _categoryService.TGetAll();
            dataGridView1.DataSource=categoryyValues;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName=txtname.Text;
            category.CategoryStatus=true;
            _categoryService.TInsert(category);
            MessageBox.Show("Ekleme Başarılı Şekilde Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var values= _categoryService.TGetById(id);
            _categoryService.TDelete(values);
            MessageBox.Show("Silme Başarılı Şekilde Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnidgetir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = _categoryService.TGetById(id);
            dataGridView1.DataSource=values;

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Category category=new Category();
            int updatedId=int.Parse(txtId.Text);
            var Updatedvalue=_categoryService.TGetById(updatedId);
            Updatedvalue.CategoryName=txtname.Text;
            Updatedvalue.CategoryStatus=true;
            _categoryService.TUpdate(Updatedvalue);
        }
    }

    
}
