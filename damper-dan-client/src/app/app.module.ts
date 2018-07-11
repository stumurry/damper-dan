import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { BuildingLocatorComponent } from './building-locator/building-locator.component';
import { NavComponent } from './nav/nav.component';

import { FormsModule } from '@angular/forms';
import { AngularFireModule } from 'angularfire2';
import { AngularFireAuthModule } from 'angularfire2/auth';
import { environment } from '../environments/environment';
import { AngularFirestore } from 'angularfire2/firestore';
import { AuthService } from './service/auth.service';

import {ButtonModule} from 'primeng/button';
import {InputTextModule} from 'primeng/inputtext';
import {MenubarModule} from 'primeng/menubar';
import {GMapModule} from 'primeng/gmap';

import {BrowserAnimationsModule} from '@angular/platform-browser/animations';

import { AgmCoreModule } from '@agm/core';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    BuildingLocatorComponent,
    NavComponent,
  ],
  imports: [
    AngularFireModule.initializeApp(environment.firebaseConfig),
    AngularFireAuthModule,
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ButtonModule,
    InputTextModule,
    MenubarModule,
    BrowserAnimationsModule,
    GMapModule,
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyB0U8UcaRCdpkk-45jlLOpuqsjr3PsJtts'
    }),

  ],
  providers: [ AngularFirestore, AuthService],
  bootstrap: [AppComponent]
})
export class AppModule { }
