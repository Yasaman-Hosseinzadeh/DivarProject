using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivarProjectWithWinForm.Enums
{
    public enum IntactStatus : int
    {
        [Description("نو")]
        New = 1,
        [Description("در حد نو")]
        LikeNew = 2,
        [Description("کار کرده")]
        Worked = 3,
        [Description("نیاز به تعمیر")]
        NeedRepair = 4
    }
}
