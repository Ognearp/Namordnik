//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Namordnik.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MaterialsProduct
    {
        public string Product { get; set; }
        public string name_material { get; set; }
        public Nullable<double> neobxodimoe_kol_vo_materiala { get; set; }
    
        public virtual Materials Materials { get; set; }
        public virtual Product Product1 { get; set; }
    }
}