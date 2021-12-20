import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Kategorija } from '../models/Kategorija';

@Injectable({
  providedIn: 'root',
})
export class KategorijaService {
  baseUrl: string = environment.base_url;

  constructor(private http: HttpClient) {}

  getKategorije(): Observable<Kategorija[]> {
    return this.http.get<Kategorija[]>(`${this.baseUrl}/Kategorija`);
  }
}
