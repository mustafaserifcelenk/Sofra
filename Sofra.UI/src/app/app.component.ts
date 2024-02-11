import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

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

  constructor(private http: HttpClient) {}

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
        (response) => {
          console.log('Rezervasyon başarıyla oluşturuldu:', response);
          // İşlem tamamlandıktan sonra gerekli işlemleri gerçekleştir
          // Örneğin: Kullanıcıya bir onay mesajı göster
        },
        (error) => {
          console.error('Rezervasyon oluşturulurken bir hata oluştu:', error);
          // Hata durumunda kullanıcıya uygun bir mesaj göster
        }
      );
  }

  title = 'angularapp1.client';
}
