import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { PjesmaService } from './services/pjesma-service.service';
import { AppComponent } from './app.component';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { PjesmeComponent } from './components/pjesme/pjesme.component';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';

const routes: Routes = [
  { path: '', component: PjesmeComponent },
  { path: 'pjesme', component: PjesmeComponent },
];

@NgModule({
  declarations: [AppComponent, PjesmeComponent, HomeComponent],
  imports: [BrowserModule, NoopAnimationsModule, RouterModule.forRoot(routes)],
  providers: [PjesmaService],
  bootstrap: [AppComponent],
})
export class AppModule {}
