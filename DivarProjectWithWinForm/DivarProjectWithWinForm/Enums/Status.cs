using System.ComponentModel;

namespace DivarProjectWithWinForm.Enums
{
    public enum Status
    {
        [Description("در صف انتشار")]
        Pending = 1,
        [Description("منتشر شده")]
        Published = 2,
        [Description("نیازمند ویرایش")]
        NeedsEditing = 3,
        [Description("رد شده")]
        Failed = 4
    }
}

