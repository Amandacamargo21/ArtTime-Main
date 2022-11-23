import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { Artista } from "src/app/models/artista";
import { MatSnackBar } from "@angular/material/snack-bar";

@Component({
  selector: "app-cadastrar-artista",
  templateUrl: "./cadastrar-artista.component.html",
  styleUrls: ["./cadastrar-artista.component.css"],
})
export class CadastrarArtistaComponent implements OnInit {
  id!: string;
  nome!: string;
  cpf!: string;
  dataNascimento!: string;
  mensagem!: string;

  constructor(
    private http: HttpClient,
    private router: Router,
    private route: ActivatedRoute,
    private _snackBar: MatSnackBar
  ) {}

  ngOnInit(): void {
    this.route.params.subscribe({
      next: (params) => {
        let { id } = params;
        if (id !== undefined) {
          this.http
            .get<Artista>(`https://localhost:5001/api/artista/buscar/${id}`)
            .subscribe({
              next: (Artista) => {
                this.id = id;
                this.nome = Artista.nome;
                this.cpf = Artista.cpf;
              },
            });
        }
      },
    });
  }

  alterar(): void {
    let artista: Artista = {
      artistaId: Number.parseInt(this.id),
      nome: this.nome,
      cpf: this.cpf,
      dataNascimento: this.dataNascimento,
    };

    this.http
      .patch<Artista>("https://localhost:5001/api/artista/alterar", artista)
      .subscribe({
        next: (artista) => {
          this._snackBar.open("Artista alterado!", "Ok!", {
            horizontalPosition: "right",
            verticalPosition: "top",
          });
          this.router.navigate(["pages/artista/listar"]);
        },
      });
  }

  cadastrar(): void {
    let artista: Artista = {
      nome: this.nome,
      cpf: this.cpf,
      dataNascimento: this.dataNascimento,
    };

    this.http
      .post<Artista>("https://localhost:5001/api/artista/cadastrar", artista)

      //Executar a requisição
      .subscribe({
        next: (artista) => {
          this._snackBar.open("Artista cadastrado!", "Ok!", {
            horizontalPosition: "right",
            verticalPosition: "top",
          });
          this.router.navigate(["pages/artista/listar"]);
        },
        error: (error) => {
          //Executa o que for necessario quando a requisição for mal sucedida
          if (error.status === 400) {
            this.mensagem = "Algum erro de validação aconteceu :/";
          } else if (error.status === 0) {
            this.mensagem = "A sua API não está rodando :/";
          }
        },
      });
  }
}
