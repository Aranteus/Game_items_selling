//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Game_items_selling_forms
{
    using System;
    using System.Collections.Generic;
    
    public partial class Разработчики
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Разработчики()
        {
            this.Игры = new HashSet<Игры>();
        }
    
        public int Код_разработчика { get; set; }
        public string Название { get; set; }
        public System.DateTime Дата_основания { get; set; }
        public int Кол_во_сотрудников { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Игры> Игры { get; set; }
    }
}
