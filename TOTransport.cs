//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TransportCompany
{
    using System;
    using System.Collections.Generic;
    
    public partial class TOTransport
    {
        public int IDTO { get; set; }
        public int IDTransport { get; set; }
        public string Master { get; set; }
        public System.DateTime PeriodTO { get; set; }
    
        public virtual Transport Transport { get; set; }
    }
}
