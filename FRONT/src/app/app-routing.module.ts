import { ListarArtistaComponent } from "./components/pages/artista/listar-artista/listar-artista.component";
import { CadastrarArtistaComponent } from "./components/pages/artista/cadastrar-artista/cadastrar-artista.component";
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
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
