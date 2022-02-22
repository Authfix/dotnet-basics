import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '@auth0/auth0-angular';

import { AuthenticatedComponent } from './authenticated.component';

const routes: Routes = [{
  path: 'authenticated',
  component: AuthenticatedComponent,
  canActivate: [AuthGuard]
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
