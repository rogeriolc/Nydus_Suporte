using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Nydus_Suporte.Editors
{
    public partial class CadastroEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Nydus_Suporte.Editors.CadastroEditor";

        public CadastroEditorAttribute()
            : base(Key)
        {
        }
    }
}
