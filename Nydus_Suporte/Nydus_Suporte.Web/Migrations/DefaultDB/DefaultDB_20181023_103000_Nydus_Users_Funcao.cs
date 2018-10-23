using FluentMigrator;
using System;

namespace Nydus_Suporte.Migrations.DefaultDB
{

    [Migration(20181023103000)]
    public class DefaultDB_20181023_103000_Nydus_Users_Funcao : AutoReversingMigration
    {
        public override void Up()
        {

            Alter.Table("NydusUsers").AddColumn("Funcao").AsInt32().NotNullable().WithDefaultValue(0);
    

        }
    }
}