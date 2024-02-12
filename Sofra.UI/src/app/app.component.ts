import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  reservationForm: FormGroup= new FormGroup({
    reservationDate: new FormControl(''),
    customerCount: new FormControl('')
  });;
  reservationDate: string = "";
  customerCount: number = 0;

  constructor(private http: HttpClient, private toastr: ToastrService) {}

  ngOnInit() {
    this.reservationForm = new FormGroup({
      reservationDate: new FormControl(''),
      customerCount: new FormControl(''),
    });
  }

  createReservation() {
    // API isteği oluştur
    console.log(this.reservationForm.value);
    console.log(this.customerCount);
    this.http.post('https://localhost:7234/Reservation', this.reservationForm.value)
      .subscribe(
        (response: any) => {
          // TODO: Add success functions for response
          // this.toastr.success(response.message, 'İşlem başarılı!');
        },
        (error: any) => {
          // TODO: Add error functions for response
          // this.toastr.error(error.message, 'Hata oluştu!');
        }
      );
  }

  title = 'angularapp1.client';
}
