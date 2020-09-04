import { Component, OnInit } from '@angular/core';
import { Employee } from '../models/employee';
import { EmployeeService } from '../services/employeeService';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {
employees:Employee[];
  constructor(private employeeService:EmployeeService) { 
    this.employees = [];
    this.employeeService.getAllEmployeesFromAPI().subscribe((myData)=>{
      this.employees = myData["data"];
      console.log(this.employees);
    }
    );
  }

  ngOnInit(): void {
  }

}
