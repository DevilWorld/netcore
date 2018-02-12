import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AddStudentComponent } from './student/add-student/add-student.component';
import { GetStudentsComponent } from './student/get-students/get-students.component';

const routes: Routes = [
  { path: '', redirectTo: '/addStudent', pathMatch: 'full'},
  { path: 'addStudent', component: AddStudentComponent },
  { path: 'getStudents', component: GetStudentsComponent }
]

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
