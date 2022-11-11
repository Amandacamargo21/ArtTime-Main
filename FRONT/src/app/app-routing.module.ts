import { ListarArtistaComponent } from "./components/pages/artista/listar-artista/listar-artista.component";
import { CadastrarArtistaComponent } from "./components/pages/artista/cadastrar-artista/cadastrar-artista.component";
import { CadastrarAgendamentoComponent } from "./components/pages/agendamento/cadastrar-agendamento/cadastrar-agendamento.component";
import { ListarAgendamentoComponent } from "./components/pages/agendamento/listar-agendamento/listar-agendamentos.component";
import { NgModule, Component } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

const routes: Routes = [
  {
    path: "pages/artista/cadastrar",
    component: CadastrarArtistaComponent,
  },

  {
    path: "pages/artista/cadastrar/:id",
    component: CadastrarArtistaComponent,
  },
  {
    path: "pages/artista/listar",
    component: ListarArtistaComponent,
  },
  {
    path: "pages/agendamento/cadastrar",
    component: CadastrarAgendamentoComponent,
  },
  {
    path: "pages/agendamento/listar",
    component: ListarAgendamentoComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
