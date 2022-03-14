import { Component } from '@angular/core';
import { EmployeeService } from './employee.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'DemoApp';
  employeeList: any[] = [];
  teststr: string = "";
constructor(private es : EmployeeService){}
  ngOnInit() {
    this.loadData();
  }
  loadData() {
    this.teststr = "test value";
    this.es.getAllEmployees().subscribe((response)=>{
      this.employeeList = response;
    });
  }
}

