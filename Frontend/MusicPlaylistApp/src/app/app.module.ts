import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { MatButtonModule } from '@angular/material/button';
import { MatDividerModule } from '@angular/material/divider';
import { MatIconModule } from '@angular/material/icon';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { MatDialogModule } from '@angular/material/dialog';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { PjesmeComponent } from './components/pjesme/pjesme.component';
import { HomeComponent } from './components/home/home.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AddPjesmaComponent } from './components/add-pjesma/add-pjesma.component';
import { EditPjesmaComponent } from './components/edit-pjesma/edit-pjesma.component';
import { PlayMusicComponent } from './components/play-music/play-music.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: 'pjesme',
    component: PjesmeComponent,
  },
  { path: 'pjesme/edit/:id', component: EditPjesmaComponent },
];

@NgModule({
  declarations: [
    AppComponent,
    PjesmeComponent,
    HomeComponent,
    AddPjesmaComponent,
    EditPjesmaComponent,
    PlayMusicComponent,
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),
    NgbModule,
    MatButtonModule,
    MatDividerModule,
    MatIconModule,
    HttpClientModule,
    FormsModule,
    MatDialogModule,
    BrowserAnimationsModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
