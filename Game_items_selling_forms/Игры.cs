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
    
    public partial class Игры
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Игры()
        {
            this.Предметы_из_игр = new HashSet<Предметы_из_игр>();
            this.Возрастной_рейтинг = new HashSet<Возрастной_рейтинг>();
            this.Издатели = new HashSet<Издатели>();
        }
    
        public int Код_игры { get; set; }
        public int Код_разработчика { get; set; }
        public int Код_жанра { get; set; }
        public int Код_платформы { get; set; }
        public string Движок { get; set; }
        public System.DateTime Дата_создания { get; set; }
        public string Игра { get; set; }
    
        public virtual Жанры Жанры { get; set; }
        public virtual Платформы Платформы { get; set; }
        public virtual Разработчики Разработчики { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Предметы_из_игр> Предметы_из_игр { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Возрастной_рейтинг> Возрастной_рейтинг { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Издатели> Издатели { get; set; }
    }
}
