//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace negrigei
{
    using System;
    using System.Collections.Generic;
    
    public partial class Perevozka
    {
        public int ID_Perevozka { get; set; }
        public string Номер { get; set; }
        public int ID_Marshret { get; set; }
        public int ID_Bilet { get; set; }
        public int ID_Dispetcher { get; set; }
        public int ID_Avtobus { get; set; }
        public int ID_Voditel { get; set; }
    
        public virtual Avtobus Avtobus { get; set; }
        public virtual Bilet Bilet { get; set; }
        public virtual Dispetcher Dispetcher { get; set; }
        public virtual Marshrut Marshrut { get; set; }
        public virtual Voditel Voditel { get; set; }
    }
}
