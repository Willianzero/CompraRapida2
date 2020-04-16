import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {
  public usuario;
  public usuarioAutenticado: boolean;
  constructor() {
    //instanciando o email e a senha da classe Usuario que traz os valores do banco
    this.usuario = new Usuario();
  }
  // mostra o email e a senha inseridos na tela do login
  entrar() {
  }
}
