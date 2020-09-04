import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../services/employeeService';
import { Employee } from '../models/employee';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-addemployee',
  templateUrl: './addemployee.component.html',
  styleUrls: ['./addemployee.component.css']
})
export class AddemployeeComponent implements OnInit {

  employee:Employee;
  frmEmployee:FormGroup;
  constructor(private employeeService:EmployeeService) {
    this.employee = new Employee();
      this.frmEmployee = new FormGroup({
        id:new FormControl( null,Validators.required),
        name:new FormControl(null,Validators.required),
        salary:new FormControl(null,Validators.required),
      })
   }
   get id(){
     return this.frmEmployee.get("id");
   }
   get name(){
    return this.frmEmployee.get("name");
  }
  get salary(){
    return this.frmEmployee.get("salary");
  }
  createEmployee(){
    if(this.frmEmployee.valid)
    {
      this.employee.id = this.id.value;
      this.employee.employee_name = this.name.value;
      this.employee.employee_salary = this.salary.value;
        this.employeeService.addEmployee(this.employee).subscribe((result)=>{
          console.log(result);
        })
    }
  }
  ngOnInit(): void {
  }

}
