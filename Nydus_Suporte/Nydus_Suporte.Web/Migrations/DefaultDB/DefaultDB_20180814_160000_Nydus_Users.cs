using FluentMigrator;
using System;

namespace Nydus_Suporte.Migrations.DefaultDB
{

    [Migration(20180814160000)]
    public class DefaultDB_20180814_160000_Nydus_Users : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("NydusUsers", "NydusUsersId", s => s
                .WithColumn("login").AsString(100).NotNullable()
                .WithColumn("NomeReal").AsString(100).NotNullable()
                .WithColumn("Email").AsString(100).Nullable()
                .WithColumn("Cargo").AsString(100).Nullable()
                .WithColumn("UserImage").AsString(100).Nullable()
                .WithColumn("DataEntrada").AsDateTime().NotNullable()
                .WithColumn("DataSaida").AsDateTime().Nullable()
                .WithColumn("Ativo").AsInt16().NotNullable().WithDefaultValue(1));


        }
    }
}