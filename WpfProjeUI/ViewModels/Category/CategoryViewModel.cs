using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProjeUI.ViewModels.Category
{
    public class CategoryViewModel
    {
        public List<Deneme> Test { get; set; }
        public CategoryViewModel()
        {
            Test = new List<Deneme>() {

               new Deneme {Name="şehmus", Surname="çakar"},
               new Deneme {Name="murat", Surname="çakar2"}

           };
        }
    }
    public class Deneme
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

}

