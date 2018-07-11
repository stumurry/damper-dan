import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { BuildingLocatorComponent } from 'src/app/building-locator/building-locator.component';

const routes: Routes = [
  { path: '', redirectTo: '/building-locator', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'building-locator', component: BuildingLocatorComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
