
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace TelephoneNetwork.EF
{

using System;
    using System.Collections.Generic;
    
public partial class TariffPlan
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TariffPlan()
    {

        this.Number = new HashSet<Number>();

    }


    public int IdTariffPlan { get; set; }

    public string TariffName { get; set; }

    public string Description { get; set; }

    public decimal Cost { get; set; }

    public bool IsDeleted { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Number> Number { get; set; }

}

}
