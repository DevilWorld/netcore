import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddStudentComponent } from './add-student/add-student.component';
import { GetStudentsComponent } from './get-students/get-students.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [AddStudentComponent, GetStudentsComponent]
})
export class StudentModule { }
