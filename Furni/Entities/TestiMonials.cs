using Microsoft.AspNetCore.Mvc;

namespace Furni.Entities
{
    public class TestiMonials : BaseEntity
    {
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public string Name{ get; set; }
        public string Status { get; set; }
    }
}
