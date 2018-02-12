import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './/app-routing.module';

import { AddStudentComponent } from './student/add-student/add-student.component';
import { GetStudentsComponent } from './student/get-students/get-students.component';


@NgModule({
  declarations: [
    AppComponent,
    AddStudentComponent,
    GetStudentsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
