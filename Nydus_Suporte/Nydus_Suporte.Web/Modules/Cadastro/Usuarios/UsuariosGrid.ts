
namespace Nydus_Suporte.Cadastro {

    @Serenity.Decorators.registerClass()
    export class UsuariosGrid extends Serenity.EntityGrid<UsuariosRow, any> {
        protected getColumnsKey() { return 'Cadastro.Usuarios'; }
        protected getDialogType() { return UsuariosDialog; }
        protected getIdProperty() { return UsuariosRow.idProperty; }
        protected getLocalTextPrefix() { return UsuariosRow.localTextPrefix; }
        protected getService() { return UsuariosService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}