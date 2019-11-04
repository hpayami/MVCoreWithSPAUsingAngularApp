import { Component, Inject, OnInit } from "@angular/core";
import { HttpClient } from '@angular/common/http'

@Component({
    selector: 'app-student-data',
    templateUrl: './student.component.html'
})

export class StudentComponent{

    studentList: IStudentData[];
  
    constructor(public _httpService: HttpClient, @Inject('BASE_URL') baseUrl: string) {

        debugger;
        this._httpService.get<IStudentData[]>(baseUrl + 'student/get').subscribe(s => {
            debugger;
            console.log(s);
            this.studentList = s;
            console.log(this.studentList);
        }, error => console.log(error), () => console.log("Done"));
        console.log(this.studentList);
    }
}


export interface IStudentData {
    studentID: number;
    studentName: string;
    standard: string;
    address: string;
}
