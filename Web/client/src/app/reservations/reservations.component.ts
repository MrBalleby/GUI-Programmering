import { Component } from '@angular/core';
import { ReservationsService, Today } from '../reservations.service';

@Component({
  templateUrl: './reservations.component.html'
})
export class ReservationsComponent {
  today: Today

  constructor(private reservation: ReservationsService) {}

  ngOnInit() {
    this.reservation.today().subscribe(
      reservation => {
        this.today = reservation;
      },
      err => {
        console.error(err);
      }
    );
  }
}