using System.ComponentModel.DataAnnotations;

namespace CafeManagement.Shared.Enums
{
    public enum EnumDelivery
    {
        [Display(Name = "Visit")]
        Visit = 1,

        [Display(Name = "Ship")]
        Ship = 2,
    }
}
