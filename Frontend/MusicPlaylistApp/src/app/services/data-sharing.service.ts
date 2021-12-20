import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { PjesmaDTO } from '../models/PjesmaDTO';

@Injectable({
  providedIn: 'root',
})
export class DataSharingService {
  public editPjesma: BehaviorSubject<PjesmaDTO> =
    new BehaviorSubject<PjesmaDTO>(new PjesmaDTO());
  constructor() {}
}
