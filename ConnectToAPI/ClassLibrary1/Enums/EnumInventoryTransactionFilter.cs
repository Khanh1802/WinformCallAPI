using System.ComponentModel.DataAnnotations;

namespace CafeManagement.Shared.Enums
{
    public enum EnumInventoryTransactionFilter
    {
        [Display(Name = "Ngày tăng dần")]
        DateAsc = 1,

        [Display(Name = "Ngày giảm dần")]
        DateDesc = 2,

        [Display(Name = "Còn ít số lượng nhất")]
        QuatityAsc = 3,

        [Display(Name = "Còn nhiều số lượng nhất")]
        QuatytiDesc = 4,
    }
}
