import { Artista } from "src/app/models/artista";
import { Agendamento } from "src/app/models/agendamento";
import { HttpClient } from "@angular/common/http";
import { MatSnackBar } from "@angular/material/snack-bar";
import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Cliente } from "src/app/models/cliente";

@Component({
  selector: "app-cadastrar-agendamento",
  templateUrl: "./cadastrar-agendamento.component.html",
  styleUrls: ["./cadastrar-agendamento.component.css"],
})
export class CadastrarAgendamentoComponent implements OnInit {
  id!: number;
  Pessoa!: string;
  cpf!: string;
  LocalDaTattoo!: string;
  artistas!: Artista[];
  ArtistaId!: number;
  clientes!: Cliente[];
  ClienteId!: number;
  data!: string;

  constructor(
    private http: HttpClient,
    private router: Router,
    private _snackBar: MatSnackBar
  ) {}

  ngOnInit(): void {
    this.http
      .get<Artista[]>("https://localhost:5001/api/artista/listar")
      .subscribe({
        next: (artistas) => {
          this.artistas = artistas;
        },
      });
  }

  cadastrar(): void {
    console.log(this.ArtistaId);
    let dataConvertida = new Date(this.data);

    let agendamento: Agendamento = {
      Pessoa: this.Pessoa,
      cpf: this.cpf,
      LocalDaTattoo: this.LocalDaTattoo,
      Dia: dataConvertida.getDay(),
      Mes: dataConvertida.getMonth() + 1,
      Ano: dataConvertida.getFullYear(),
      ArtistaId: this.ArtistaId,
    };

    this.http
      .post<Agendamento>(
        "https://localhost:5001/api/agendamento/cadastrar",
        agendamento
      )
      .subscribe({
        next: (agendamento) => {
          this._snackBar.open("Agendamento cadastrado!", "Ok!", {
            horizontalPosition: "right",
            verticalPosition: "top",
          });
          this.router.navigate(["pages/agendamento/listar"]);
        },
      });
  }

  alterar(): void {
    console.log(this.id);
    let dataConvertida = new Date(this.data);
    let Agendamento: Agendamento = {
      id: this.id,
      Pessoa: this.Pessoa,
      cpf: this.cpf,
      LocalDaTattoo: this.LocalDaTattoo,
      Dia: dataConvertida.getDay(),
      Mes: dataConvertida.getMonth() + 1,
      Ano: dataConvertida.getFullYear(),
      ArtistaId: this.ArtistaId,
    };

    this.http
      .patch<Agendamento>(
        "https://localhost:5001/api/agendamento/alterar",
        Agendamento
      )
      .subscribe({
        next: (agendamento) => {
          this.router.navigate(["pages/agendamento/listar"]);
        },
      });
  }
}
