import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { AuthService } from '@auth0/auth0-angular';
import { Weather } from './weather.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  private readonly _httpClient: HttpClient;
  private readonly _authService: AuthService;

  constructor(httpClient: HttpClient, authService: AuthService) {
    this._httpClient = httpClient;
    this._authService = authService;
    this.weather = [];
  }

  public weather: Weather[];

  public login(): void {
    this._authService.loginWithRedirect();
  }

  public logout(): void {
    this._authService.logout();
  }

  public async ngOnInit(): Promise<void> {
    try {
      const weather = await this._httpClient
        .get<Weather[]>('http://localhost:5216/WeatherForecast')
        .toPromise();
      this.weather = weather;
    } catch (error) {
      console.log(error);
    }

    this._authService.user$.subscribe((u) => console.log(u));
  }
}
