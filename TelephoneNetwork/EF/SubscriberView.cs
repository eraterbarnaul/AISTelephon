
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
    
public partial class SubscriberView
{

    public int IdSubscriber { get; set; }

    public string LastName { get; set; }

    public string FirstName { get; set; }

    public string Patronymic { get; set; }

    public string GenderCode { get; set; }

    public Nullable<System.DateTime> BirthDate { get; set; }

    public string Email { get; set; }

    public string PassportSeries { get; set; }

    public string PassportNumber { get; set; }

    public string Address { get; set; }

    public System.DateTime RegDate { get; set; }

    public string BenefitCode { get; set; }

    public string BenefitCertififcate { get; set; }

    public bool IsDeleted { get; set; }

}

}
