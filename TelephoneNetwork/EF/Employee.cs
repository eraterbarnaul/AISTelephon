
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
    
public partial class Employee
{

    public int IdEmployee { get; set; }

    public int IdPosition { get; set; }

    public string LastName { get; set; }

    public string FirstName { get; set; }

    public string Patronymic { get; set; }

    public string GenderCode { get; set; }

    public System.DateTime BirthDate { get; set; }

    public string NumberPhone { get; set; }

    public string Email { get; set; }

    public string Login { get; set; }

    public string Password { get; set; }



    public virtual Gender Gender { get; set; }

    public virtual Position Position { get; set; }

}

}
