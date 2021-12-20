import Kategorija from './Kategorija';
export default class Pjesma {
  public Id: number;
  public Naziv: string;
  public NazivIzvodjaca: string;
  public Ocjena: number;
  public DatumPostavljanja: Date;
  public DatumEditovanja: Date;
  public Kategorija: Kategorija;
  public Url: string;
  public JeLiFavorit: boolean;
}
