import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './Component/login/login.component';
import { RegisterComponent } from './Component/register/register.component';
import { ForgotComponent } from './Component/forgot/forgot.component';
import { DashboardComponent } from './Component/dashboard/dashboard.component';


const routes: Routes = [
  {path : '', component: LoginComponent},
  {path : 'login', component: LoginComponent},
  {path : 'register', component: RegisterComponent},
  {path : 'forgot', component: ForgotComponent},
  {path : 'dashboard', component: DashboardComponent,
children: [
  
]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
