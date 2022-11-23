import { Cliente } from "./cliente";
import { Artista } from "./artista";

export interface Agendamento {
  id?: number;
  LocalDaTattoo: string;
  ArtistaId: number;
  artista?: Artista;
  ClienteId: number;
  cliente?: Cliente;
  // Dia: number;
  // Mes: number;
  // Ano: number;
  dataAgendamento: string;
  criadoEm?: string;
}
