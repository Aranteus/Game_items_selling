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
    
    public partial class Игры
    {
        public Игры()
        {
            this.Предметы_из_игр = new HashSet<Предметы_из_игр>();
            this.Издатели = new HashSet<Издатели>();
            this.Возрастной_рейтинг = new HashSet<Возрастной_рейтинг>();
        }
    
        public int Код_игры { get; set; }
        public int Код_разработчика { get; set; }
        public int Код_жанра { get; set; }
        public int Код_платформы { get; set; }
        public string Игра { get; set; }
        public string Движок { get; set; }
        public System.DateTime Дата_создания { get; set; }
    
        public virtual Жанры Жанры { get; set; }
        public virtual Платформы Платформы { get; set; }
        public virtual Разработчики Разработчики { get; set; }
        public virtual ICollection<Предметы_из_игр> Предметы_из_игр { get; set; }
        public virtual ICollection<Издатели> Издатели { get; set; }
        public virtual ICollection<Возрастной_рейтинг> Возрастной_рейтинг { get; set; }
    }
}
