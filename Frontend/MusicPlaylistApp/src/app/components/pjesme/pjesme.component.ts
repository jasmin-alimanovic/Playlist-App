import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Pjesma } from 'src/app/models/Pjesma';
import { PjesmaDTO } from 'src/app/models/PjesmaDTO';
import { PjesmaService } from 'src/app/services/pjesma.service';
import { AddPjesmaComponent } from '../add-pjesma/add-pjesma.component';
import { DataSharingService } from 'src/app/services/data-sharing.service';
import { PlayMusicComponent } from '../play-music/play-music.component';

@Component({
  selector: 'app-pjesme',
  templateUrl: './pjesme.component.html',
  styleUrls: ['./pjesme.component.css'],
})
export class PjesmeComponent implements OnInit {
  pjesme: Pjesma[];
  pjesma: PjesmaDTO;

  constructor(
    private pjesmaService: PjesmaService,
    private dialog: MatDialog,
    private dataSharing: DataSharingService
  ) {
    this.pjesme = [];
    this.pjesma = new PjesmaDTO();
    this.dataSharing.editPjesma.subscribe((value) => {
      if (!(value.id === undefined || value.id === null)) {
        this.pjesmaService.editPjesma(value.id!, value).subscribe((res) => {
          this.pjesmaService.getPjesme().subscribe((result) => {
            this.pjesme = result;
          });
        });
      }
    });
  }

  ngOnInit(): void {
    this.pjesmaService.getPjesme().subscribe((p) => {
      this.pjesme = p;
    });
  }
  deleteSong(id: number): void {
    this.pjesmaService.deletePjesma(id).subscribe((result) => {
      this.pjesmaService.getPjesme().subscribe((result) => {
        this.pjesme = result;
      });
    });
  }

  openPlayMusicDialog(url: string): void {
    const dialogRef = this.dialog.open(PlayMusicComponent, {
      data: url,
    });
  }

  openAddPjesmaDialog(): void {
    const dialogRef = this.dialog.open(AddPjesmaComponent, {
      width: '400px',
      data: this.pjesma,
    });

    dialogRef.afterClosed().subscribe((result) => {
      this.pjesma = result;
      this.pjesmaService.addPjesma(this.pjesma).subscribe((result) => {
        this.pjesmaService.getPjesme().subscribe((result) => {
          this.pjesme = result;
        });
      });
    });
  }
}
