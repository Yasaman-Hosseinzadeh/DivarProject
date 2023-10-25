using DivarProjectWithWinForm.Enums;
using DivarProjectWithWinForm.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivarProjectWithWinForm.Models.Models
{
    public class AdvertismentModel
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string IntactStatus { get; set; }
        public string Status { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool IsFixedPrice { get; set; }
        public bool LikeToExchange { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
