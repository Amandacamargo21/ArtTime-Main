import { HttpClient } from "@angular/common/http";
import { Call } from "@angular/compiler";
import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { Artista } from "src/app/models/artista";

@Component({
  selector: "app-cadastrar-artista",
  templateUrl: "./cadastrar-artista.component.html",
  styleUrls: ["./cadastrar-artista.component.css"],
})
export class CadastrarArtistaComponent implements OnInit {
  id!: number;
  nome!: string;
  cpf!: string;
  dataNascimento!: string;
  mensagem!: string;
  Artistaid!: string;

  constructor(
    private http: HttpClient,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.route.params.subscribe({
      next: (params) => {
        let { id, cpf } = params;
        this.id = id;
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
          //Executamos o que for necessário quando a requisição for bem sucedida
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
