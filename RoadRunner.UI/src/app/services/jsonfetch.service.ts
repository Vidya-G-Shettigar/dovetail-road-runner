import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import 'rxjs/Rx';
import 'rxjs/add/operator/map';
@Injectable({
  providedIn: 'root',
})
export class JsonfetchService {
  artType: any;
  constructor(private http: HttpClient, private router: Router) {}

  getData() {
    this.artType = this.router.url.split('?')[0].split('/').pop();
    console.log(this.artType);
    return this.http.get(
      '/assets/road-runner/content/' + this.artType + '.json'
    );
    // .map((response: Response) => response.json());
  }
}
