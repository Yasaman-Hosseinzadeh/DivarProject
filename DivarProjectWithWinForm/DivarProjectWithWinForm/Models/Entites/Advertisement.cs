using DivarProjectWithWinForm.Enums;
using DivarProjectWithWinForm.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivarProjectWithWinForm.Models.Entites
{
    public class Advertisement
    {
        public int Id { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
        public int CreatorUserId { get; set; }
        public IntactStatus IntactStatus { get; set; }
        public Status Status { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool IsFixedPrice { get; set; }
        public bool LikeToExchange { get; set; }
    }
}
