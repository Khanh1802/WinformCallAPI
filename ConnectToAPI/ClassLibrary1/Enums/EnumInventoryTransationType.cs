using System.ComponentModel.DataAnnotations;

namespace CafeManagement.Shared.Enums
{
    public enum EnumInventoryTransationType
    {
        [Display(Name = "Nhập kho")]
        Import = 1,

        [Display(Name = "Xuất kho")]
        Export = 2,
    }
}
