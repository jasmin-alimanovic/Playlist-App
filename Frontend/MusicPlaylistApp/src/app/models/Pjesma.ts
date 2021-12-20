import { Kategorija } from './Kategorija';

export class Pjesma {
  id!: number;
  naziv!: string;
  nazivIzvodjaca!: string;
  ocjena?: number;
  datumPostavljanja!: Date;
  datumEditovanja!: Date;
  kategorija!: Kategorija;
  url!: string;
  jeLiFavorit!: boolean;
}
