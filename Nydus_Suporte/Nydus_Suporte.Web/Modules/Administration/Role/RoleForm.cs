﻿
namespace Nydus_Suporte.Administration.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Administration.Role")]
    [BasedOnRow(typeof(Entities.RoleRow), CheckNames = true)]
    public class RoleForm
    {
        public String RoleName { get; set; }
    }
}