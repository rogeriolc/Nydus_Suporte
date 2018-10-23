
namespace Nydus_Suporte.Cadastro.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Cadastro.Usuarios")]
    [BasedOnRow(typeof(Entities.UsuariosRow), CheckNames = true)]
    public class UsuariosColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 NydusUsersId { get; set; }
        [EditLink]
        public String Login { get; set; }
        public String NomeReal { get; set; }
        public String Email { get; set; }
        public String Cargo { get; set; }
        public Int32 Funcao { get; set; }
        public String UserImage { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public Int16 Ativo { get; set; }
    }
}