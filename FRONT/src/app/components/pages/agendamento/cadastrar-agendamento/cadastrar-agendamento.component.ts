import { Artista } from "src/app/models/artista";
import { Agendamento } from "src/app/models/agendamento";
import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";

@Component({
  selector: "app-cadastrar-agendamento",
  templateUrl: "./cadastrar-agendamento.component.html",
  styleUrls: ["./cadastrar-agendamento.component.css"],
})
export class CadastrarAgendamentoComponent implements OnInit {
  id!: number;
  Cliente!: string;
  cpf!: string;
  LocalDaTattoo!: string;
  artistas!: Artista[];
  ArtistaId!: number;
  data!: string;

  constructor(private http: HttpClient, private router: Router) {}

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

    let Agendamento: Agendamento = {
      Cliente: this.Cliente,
      cpf: this.cpf,
      LocalDaTattoo: this.LocalDaTattoo,
      Dia: dataConvertida.getDay(),
      Mes: dataConvertida.getMonth() + 1,
      Ano: dataConvertida.getFullYear(),
      ArtistaId: this.ArtistaId,
      id: this.id,
    };

    this.http
      .post<Agendamento>(
        "https://localhost:5001/api/agendamento/cadastrar",
        Agendamento
      )
      .subscribe({
        next: (Agendamento) => {
          this.router.navigate(["pages/agendamento/listar"]);
        },
      });
  }

  alterar(): void {
    console.log(this.id);
    let dataConvertida = new Date(this.data);
    let Agendamento: Agendamento = {
      id: this.id,
      Cliente: this.Cliente,
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
