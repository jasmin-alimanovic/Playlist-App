import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'app-play-music',
  templateUrl: './play-music.component.html',
  styleUrls: ['./play-music.component.css'],
})
export class PlayMusicComponent implements OnInit {
  constructor(
    public dialogRef: MatDialogRef<PlayMusicComponent>,
    @Inject(MAT_DIALOG_DATA) public data: string,
    private sanitizer: DomSanitizer
  ) {}

  ngOnInit(): void {
    console.log(this.data);
  }
  photoURL() {
    return this.sanitizer.bypassSecurityTrustResourceUrl(this.data);
  }
}
