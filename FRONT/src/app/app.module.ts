import { CadastrarAgendamentoComponent } from "./components/pages/agendamento/cadastrar-agendamento/cadastrar-agendamento.component";
import { ListarArtistaComponent } from "./components/pages/artista/listar-artista/listar-artista.component";
import { HttpClientModule } from "@angular/common/http";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { CadastrarArtistaComponent } from "./components/pages/artista/cadastrar-artista/cadastrar-artista.component";

@NgModule({
  declarations: [
    AppComponent,
    CadastrarArtistaComponent,
    ListarArtistaComponent,
    CadastrarAgendamentoComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, FormsModule, HttpClientModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
