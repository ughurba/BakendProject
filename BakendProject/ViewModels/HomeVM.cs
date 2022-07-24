using BakendProject.Models;
using System.Collections.Generic;

namespace BakendProject.ViewModels
{
    public class HomeVM
    {
        public int Id{ get; set; }
        public List<Slider> sliders{ get; set; }
        public List<ModalProduct> modalProducts{ get; set; }
        public List<Product> products{ get; set; }
        public List<Category> categories{ get; set; }
        public List <Brand> brands{ get; set; }
        public List <Blog> blogs{ get; set; }
        public List<Bio> Bios { get; set; }
    }
}
