
namespace Nydus_Suporte.Cadastro {

    @Serenity.Decorators.registerClass()
    export class UsuariosDialog extends Serenity.EntityDialog<UsuariosRow, any> {
        protected getFormKey() { return UsuariosForm.formKey; }
        protected getIdProperty() { return UsuariosRow.idProperty; }
        protected getLocalTextPrefix() { return UsuariosRow.localTextPrefix; }
        protected getNameProperty() { return UsuariosRow.nameProperty; }
        protected getService() { return UsuariosService.baseUrl; }

        protected form = new UsuariosForm(this.idPrefix);

    }
}