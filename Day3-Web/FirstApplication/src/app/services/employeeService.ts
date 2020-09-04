
import {HttpClient} from '@angular/common/http';
import {Employee} from '../models/employee';
import { Injectable } from '@angular/core';

@Injectable()
export class EmployeeService{

    constructor(private myHttpClient:HttpClient){

    }
    getAllEmployeesFromAPI(){
        return this.myHttpClient.get("http://dummy.restapiexample.com/api/v1/employees");
    }

    addEmployee(employee:Employee){
        return this.myHttpClient.post("http://dummy.restapiexample.com/api/v1/create",employee);
    }
}