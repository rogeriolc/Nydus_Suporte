
namespace Nydus_Suporte.Cadastro.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Cadastro"), TableName("[dbo].[NydusUsers]")]
    [DisplayName("Usuarios"), InstanceName("Usuarios")]
    [ReadPermission("Cadastro:Usuarios")]
    [ModifyPermission("Cadastro:Usuarios")]
    public sealed class UsuariosRow : Row, IIdRow, INameRow
    {

        [DisplayName("Nydus Users Id"), Identity]
        public Int32? NydusUsersId
        {
            get { return Fields.NydusUsersId[this]; }
            set { Fields.NydusUsersId[this] = value; }
        }

        [DisplayName("Login"), Column("login"), Size(100), NotNull, QuickSearch]
        public String Login
        {
            get { return Fields.Login[this]; }
            set { Fields.Login[this] = value; }
        }

        [DisplayName("Nome Real"), Size(100), NotNull]
        public String NomeReal
        {
            get { return Fields.NomeReal[this]; }
            set { Fields.NomeReal[this] = value; }
        }

        [DisplayName("Email"), Size(100)]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        [DisplayName("Cargo"), Size(100)]
        public String Cargo
        {
            get { return Fields.Cargo[this]; }
            set { Fields.Cargo[this] = value; }
        }

        [DisplayName("Função")]
        public Int32? Funcao
        {
            get { return Fields.Funcao[this]; }
            set { Fields.Funcao[this] = value; }
        }

        [DisplayName("User Image"), Size(100)]
        public String UserImage
        {
            get { return Fields.UserImage[this]; }
            set { Fields.UserImage[this] = value; }
        }

        [DisplayName("Data Entrada"), NotNull]
        public DateTime? DataEntrada
        {
            get { return Fields.DataEntrada[this]; }
            set { Fields.DataEntrada[this] = value; }
        }

        [DisplayName("Data Saida")]
        public DateTime? DataSaida
        {
            get { return Fields.DataSaida[this]; }
            set { Fields.DataSaida[this] = value; }
        }

        [DisplayName("Ativo"), NotNull]
        public Int16? Ativo
        {
            get { return Fields.Ativo[this]; }
            set { Fields.Ativo[this] = value; }
        }



        IIdField IIdRow.IdField
        {
            get { return Fields.NydusUsersId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Login; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public UsuariosRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {

            public Int32Field NydusUsersId;

            public StringField Login;

            public StringField NomeReal;

            public StringField Email;

            public StringField Cargo;

            public StringField UserImage;

            public DateTimeField DataEntrada;

            public DateTimeField DataSaida;

            public Int16Field Ativo;

            public Int32Field Funcao;


		}
    }
}
