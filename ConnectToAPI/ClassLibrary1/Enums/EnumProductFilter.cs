﻿using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Enums
{
    public enum EnumProductFilter
    {
        [Display(Name = "Giá tăng dần")]
        PriceAsc = 0,

        [Display(Name = "Giá giảm dần")]
        PriceDesc = 1,

        [Display(Name = "Ngày tăng dần")]
        DateAsc = 2,

        [Display(Name = "Ngày giảm dần")]
        DateDesc = 3,
    }
}
