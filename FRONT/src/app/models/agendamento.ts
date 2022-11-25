import { Cliente } from "./cliente";
import { Artista } from "./artista";

export interface Agendamento {
  id?: number;
  LocalDaTattoo: string;
  artista?: Artista;
  cliente?: Cliente;
  dataAgendamento: string;
  criadoEm?: string;
}
