import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Kategorija } from 'src/app/models/Kategorija';
import { PjesmaDTO } from 'src/app/models/PjesmaDTO';
import { KategorijaService } from 'src/app/services/kategorija.service';

@Component({
  selector: 'app-add-pjesma',
  templateUrl: './add-pjesma.component.html',
  styleUrls: ['./add-pjesma.component.css'],
})
export class AddPjesmaComponent implements OnInit {
  constructor(
    public dialogRef: MatDialogRef<AddPjesmaComponent>,
    @Inject(MAT_DIALOG_DATA) data: PjesmaDTO,
    private kategorijaService: KategorijaService
  ) {
    this.data = new PjesmaDTO();
    this.kategorije = [];
  }

  data: PjesmaDTO;
  kategorije: Kategorija[];

  ngOnInit(): void {
    this.kategorijaService.getKategorije().subscribe((data) => {
      this.kategorije = data;
    });
  }

  close(): void {
    this.dialogRef.close();
  }
  onAdd(): void {
    alert('Successfully added song.');
  }
}
