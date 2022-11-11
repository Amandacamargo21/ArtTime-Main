export interface Agendamento {
  id?: number;
  Cliente: string;
  cpf: string;
  LocalDaTattoo: string;
  ArtistaId: number;
  Dia: number;
  Mes: number;
  Ano: number;
  criadoEm?: string;
}
