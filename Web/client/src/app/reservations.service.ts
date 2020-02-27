import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Today {
  table_id: number
  table: string
  number_of_seats: number
  res_in_16: number
  res_in_17: number
  res_in_18: number
  res_in_19: number
  res_in_20: number
  res_in_21: number
  res_in_22: number
  res_in_23: number
}

export interface Info {
  id: number
  employee: string
  table: string
  start_date: Date
  end_date: Date
}

@Injectable()
export class ReservationsService {
  constructor(private http: HttpClient) {}

  public today(): Observable<any> {
    return this.http.get(`/api/reservations/today`);
  }

  public info(id: number): Observable<any> {
    return this.http.get(`/api/reservations/info/${id}`);
  }
}