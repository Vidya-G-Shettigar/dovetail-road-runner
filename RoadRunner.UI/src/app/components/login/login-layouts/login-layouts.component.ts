import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import * as $ from 'jquery';
@Component({
  selector: 'app-login-layouts',
  templateUrl: './login-layouts.component.html',
  styleUrls: ['./login-layouts.component.css'],
})
export class LoginLayoutsComponent implements OnInit {
  loginForm: FormGroup;
  submitted = false;
  constructor(private formBuilder: FormBuilder) {}

  ngOnInit(): void {
    this.loginForm = this.formBuilder.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required]],
    });
  }
  get f() {
    return this.loginForm.controls;
  }
  onSubmit() {
    this.submitted = true;
    // console.log(this.f.email.errors.required);
    // stop here if form is invalid
    if (this.loginForm.invalid) {
      return;
    }

    // display form values on success
    alert('SUCCESS!! :-)\n\n' + JSON.stringify(this.loginForm.value, null, 4));
  }

  click(ev) {
    alert('hi');

    var d = new Date(); //create a cookie for 'I agree'
    document.cookie = 'VALSignInAgree=Yes;expires=' + d.toUTCString();
  }
}

function getCookie(name) {
  var v = document.cookie.match('(^|;) ?' + name + '=([^;]*)(;|$)');
  return v ? v[2] : null;
}

$('coupon_question').change(function () {
  if ($(this).is(':checked')) {
    alert('clicked');
    var d = new Date(); //create a cookie for 'I agree'

    document.cookie = 'VALSignInAgree=Yes;expires=' + d.toUTCString();
    $('#frm1').show();
  } else {
    $('#frm1').hide();
  }
});

// $(document).ready(function () {
//   var VALSignInAgree = getCookie('VALSignInAgree');
//   if (VALSignInAgree == 'Yes') {
//     alert('hi');
//     $('#divByClickingBox').hide();
//     $('#divChkAgree').hide();
//     $('#frm1').show();
//   } else {
//     $('#divByClickingBox').show();
//     $('#divChkAgree').show();
//     $('#chkAgree').prop('checked', false);
//     $('#frm1').hide();
//   }
// });
