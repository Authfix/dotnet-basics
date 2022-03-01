import { NgModule } from '@angular/core';
import { AuthModule } from '@auth0/auth0-angular';

@NgModule({
  imports: [
    AuthModule.forRoot({
      domain: 'xxxxxxxxxx.eu.auth0.com',
      clientId: 'xxxxxxxxxxxxxxxxxxxxx',

      audience: 'http://localhost:5216',
      scope: '',

      httpInterceptor: {
        allowedList: [
          {
            uri: 'http://localhost:5216/*',
            tokenOptions: {
              audience: 'http://localhost:5216',
              scope: ''
            }
          }
        ]
      }
    })
  ],
  exports: [AuthModule],
  declarations: [],
  providers: [],
})
export class AppAuthenticationModule { }
