import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Pjesma } from '../models/Pjesma';
import { PjesmaDTO } from '../models/PjesmaDTO';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
  }),
  Vary: 'Origin',
};

@Injectable({
  providedIn: 'root',
})
export class PjesmaService {
  baseUrl: string = environment.base_url;

  constructor(private http: HttpClient) {}

  getPjesme(): Observable<Pjesma[]> {
    return this.http.get<Pjesma[]>(`${this.baseUrl}/Pjesma`);
  }
  getPjesmaById(id: number): Observable<PjesmaDTO> {
    return this.http.get<Pjesma>(`${this.baseUrl}/Pjesma/${id}`);
  }
  addPjesma(pjesma: PjesmaDTO): Observable<any> {
    return this.http.post(`${this.baseUrl}/Pjesma`, pjesma, httpOptions);
  }

  editPjesma(id: number, pjesma: PjesmaDTO): Observable<any> {
    return this.http.put(`${this.baseUrl}/Pjesma/${id}`, pjesma, httpOptions);
  }

  deletePjesma(id: number): Observable<any> {
    return this.http.delete(`${this.baseUrl}/Pjesma/${id}`);
  }
}
