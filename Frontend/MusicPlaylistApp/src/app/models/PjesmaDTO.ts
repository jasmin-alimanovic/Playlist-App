import { Kategorija } from './Kategorija';

export class PjesmaDTO {
  id?: number;
  naziv!: string;
  nazivIzvodjaca!: string;
  ocjena?: number;
  kategorijaId?: number;
  kategorija?: Kategorija;
  url!: string;
  jeLiFavorit!: boolean;
}
