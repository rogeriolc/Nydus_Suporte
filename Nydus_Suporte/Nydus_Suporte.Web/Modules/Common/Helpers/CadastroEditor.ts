namespace Nydus_Suporte.Editors {
    @Serenity.Decorators.registerEditor()
    export class CadastroEditor extends Serenity.Select2Editor<any, any> {

        constructor(container: JQuery) {
            super(container, null);

            this.addOption("1", "Analista");
            this.addOption("2", "Suporte");
            this.addOption("3", "Desenvolvedor");
            this.addOption("4", "Leitura");
            this.addOption("5", "Acordo Coletivo");
            this.addOption("6", "Administrador de Dados");
            
        }
    }
}