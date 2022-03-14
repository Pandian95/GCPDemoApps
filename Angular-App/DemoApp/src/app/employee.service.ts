import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  //url = "https://azuredevopsapi-dev.azurewebsites.net/api/Employees";
  url = "http://localhost:53094/api/Employees";
  constructor(private http: HttpClient) { }

  getAllEmployees(): Observable<any> {
    return this.http.get<any>(this.url);
  }
}
