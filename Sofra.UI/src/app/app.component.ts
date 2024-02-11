import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  reservationDate: string = "";
  customerCount: number = 0;

  constructor(private http: HttpClient) {}

  ngOnInit() {
  }

  createReservation() {
    // API isteği oluştur
    const reservationData = {
      date: this.reservationDate,
      numberOfPeople: this.customerCount
    };

    this.http.post('/createReservation', reservationData)
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
