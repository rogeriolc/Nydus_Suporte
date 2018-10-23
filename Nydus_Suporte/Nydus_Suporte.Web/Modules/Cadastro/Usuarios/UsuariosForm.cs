
namespace Nydus_Suporte.Cadastro.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using Nydus_Suporte.Editors;

    [FormScript("Cadastro.Usuarios")]
    [BasedOnRow(typeof(Entities.UsuariosRow), CheckNames = true)]
    public class UsuariosForm
    {
        public String Login { get; set; }
        public String NomeReal { get; set; }
        public String Email { get; set; }
        public String Cargo { get; set; }
        [CadastroEditor]
        public Int32 Funcao { get; set; }
        public String UserImage { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public Int16 Ativo { get; set; }
    }
}