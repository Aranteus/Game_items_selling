//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Game_items_selling_web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Чек
    {
        public int Код_чека { get; set; }
        public int Код_фирмы { get; set; }
        public int Код_предмета { get; set; }
        public System.DateTime Дата { get; set; }
        public int Кол_во_предметов { get; set; }
    
        public virtual Предметы_из_игр Предметы_из_игр { get; set; }
        public virtual Торговые_площадки Торговые_площадки { get; set; }
    }
}
