import { Component,Inject } from '@angular/core'
import { IStudentData } from '../StudentList/student.component'
import { ActivatedRoute } from '@angular/router'
import { HttpClient } from '@angular/common/http';


@Component({
    selector: 'app-studentdetail-data',
    templateUrl: './studentDetail.component.html'
})

export class StudentDetailComponent
{
    studentDetail: IStudentData;
    id: string;
    constructor(private httpService: HttpClient, @Inject("BASE_URL") baseUrl: string, private _activateRoute: ActivatedRoute)
    {
        this.id = _activateRoute.snapshot.paramMap.get("id");
        var studentDetailURl = baseUrl + 'student/studentDetail/' + parseInt(this.id);
        debugger;
        this.httpService.get<IStudentData>(studentDetailURl)
            .subscribe(result =>
            {
                console.log(result);
                this.studentDetail = result;
            }, error => console.log(error))
    }
}
