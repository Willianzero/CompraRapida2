import { Component } from "@angular/core";

@Component({
  selector: "app-produto",
  template: "<html><body>{{obterNome()}}</body></html>"
})

export class ProdutoComponent {
  public name: string;
  public liberadoParaVenda: boolean;
  public obterNome(): string {
    return "Samsung";
  }


}
