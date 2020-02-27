import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ReservationsService, Info } from '../reservations.service';

@Component({
  templateUrl: './info.component.html'
})
export class InfoComponent {
  info: Info
  reservationId: number

  constructor(private reservation: ReservationsService, private actRoute: ActivatedRoute) {
    this.reservationId = this.actRoute.snapshot.params.id;
  }

  ngOnInit() {
    this.reservation.info(this.reservationId).subscribe(
      info => {
        this.info = info
      },
      err => {
        console.error(err);
      }
    );
  }
}