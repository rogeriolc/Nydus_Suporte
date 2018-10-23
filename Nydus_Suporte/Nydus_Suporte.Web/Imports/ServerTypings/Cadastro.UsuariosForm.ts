namespace Nydus_Suporte.Cadastro {
    export interface UsuariosForm {
        Login: Serenity.StringEditor;
        NomeReal: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        Cargo: Serenity.StringEditor;
        Funcao: Editors.CadastroEditor;
        UserImage: Serenity.StringEditor;
        DataEntrada: Serenity.DateEditor;
        DataSaida: Serenity.DateEditor;
        Ativo: Serenity.IntegerEditor;
    }

    export class UsuariosForm extends Serenity.PrefixedContext {
        static formKey = 'Cadastro.Usuarios';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UsuariosForm.init)  {
                UsuariosForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = Editors.CadastroEditor;
                var w2 = s.DateEditor;
                var w3 = s.IntegerEditor;

                Q.initFormType(UsuariosForm, [
                    'Login', w0,
                    'NomeReal', w0,
                    'Email', w0,
                    'Cargo', w0,
                    'Funcao', w1,
                    'UserImage', w0,
                    'DataEntrada', w2,
                    'DataSaida', w2,
                    'Ativo', w3
                ]);
            }
        }
    }
}
