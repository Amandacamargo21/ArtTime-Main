import { Cliente } from "./cliente";
import { Artista } from "./artista";

export interface Agendamento {
  id?: number;
  localDaTattoo: string;
  artista?: Artista;
  artistaId: number;
  cliente?: Cliente;
  clienteId: number;
  dataAgendamento: string;
  criadoEm?: string;
}
