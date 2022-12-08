import { Component, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { Person } from 'src/app/model/Person';

@Component({
  selector: 'app-create-memo',
  templateUrl: './create-memo.component.html',
  styleUrls: ['./create-memo.component.css']
})
export class CreateMemoComponent implements OnInit {
  @ViewChild('f') memoForm!: NgForm;
  
  constructor() { }

  ngOnInit(): void {
  }
  
  onSubmit() {
    console.log(this.memoForm);
    console.log("Title: " + this.memoForm.value['memo-title']);
    console.log("Content: " + this.memoForm.value['memo-content']);

    this.memoForm.reset();
  }
}
