//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testSustem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class FinishedTest
    {
        public int FinishedTestID { get; set; }
        public Nullable<int> TestID { get; set; }
        public Nullable<int> UsersID { get; set; }
        public Nullable<int> Points { get; set; }
        public Nullable<System.TimeSpan> Time { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
    
        public virtual Test Test { get; set; }
        public virtual User User { get; set; }
    }
}
