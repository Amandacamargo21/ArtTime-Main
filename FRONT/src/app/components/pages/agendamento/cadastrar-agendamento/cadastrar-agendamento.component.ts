import { Artista } from "src/app/models/artista";
import { Agendamento } from "src/app/models/agendamento";
import { HttpClient } from "@angular/common/http";
import { MatSnackBar } from "@angular/material/snack-bar";
import { Component, OnInit } from "@angular/core";
import { Cliente } from "src/app/models/cliente";
import { ActivatedRoute, Router } from "@angular/router";

@Component({
  selector: "app-cadastrar-agendamento",
  templateUrl: "./cadastrar-agendamento.component.html",
  styleUrls: ["./cadastrar-agendamento.component.css"],
})
export class CadastrarAgendamentoComponent implements OnInit {
  id!: number;
  LocalDaTattoo!: string;
  artistas!: Artista[];
  artista!: Artista;
  cliente!: Cliente;
  clientes!: Cliente[];
  //clienteId!: number;
  dataAgendamento!: string;

  constructor(
    private http: HttpClient,
    private router: Router,
    private route: ActivatedRoute,
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
    this.http
      .get<Cliente[]>("https://localhost:5001/api/cliente/listar")
      .subscribe({
        next: (clientes) => {
          this.clientes = clientes;
        },
      });
  }

  cadastrar(): void {
    console.log(this.artista);
    console.log(this.cliente);
    let agendamento: Agendamento = {
      LocalDaTattoo: this.LocalDaTattoo,
      dataAgendamento: this.dataAgendamento,
      artista: this.artista,
      cliente: this.cliente,
    };
    console.log(agendamento);
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
}
