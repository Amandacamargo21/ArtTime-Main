export interface Agendamento {
  id?: number;
  Pessoa: string;
  cpf: string;
  LocalDaTattoo: string;
  ArtistaId: number;
  Dia: number;
  Mes: number;
  Ano: number;
  criadoEm?: string;
}
