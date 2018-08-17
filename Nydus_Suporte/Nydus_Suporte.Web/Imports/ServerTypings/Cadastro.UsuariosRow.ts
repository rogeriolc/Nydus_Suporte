namespace Nydus_Suporte.Cadastro {
    export interface UsuariosRow {
        NydusUsersId?: number;
        Login?: string;
        NomeReal?: string;
        Email?: string;
        Cargo?: string;
        UserImage?: string;
        DataEntrada?: string;
        DataSaida?: string;
        Ativo?: number;
    }

    export namespace UsuariosRow {
        export const idProperty = 'NydusUsersId';
        export const nameProperty = 'Login';
        export const localTextPrefix = 'Cadastro.Usuarios';

        export declare const enum Fields {
            NydusUsersId = "NydusUsersId",
            Login = "Login",
            NomeReal = "NomeReal",
            Email = "Email",
            Cargo = "Cargo",
            UserImage = "UserImage",
            DataEntrada = "DataEntrada",
            DataSaida = "DataSaida",
            Ativo = "Ativo"
        }
    }
}
