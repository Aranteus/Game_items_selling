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
    
    public partial class Возрастной_рейтинг
    {
        public Возрастной_рейтинг()
        {
            this.Игры = new HashSet<Игры>();
        }
    
        public int Код_возрастного_рейтинга { get; set; }
        public string Название_рейтинга { get; set; }
        public string Рейтинг { get; set; }
    
        public virtual ICollection<Игры> Игры { get; set; }
    }
}
