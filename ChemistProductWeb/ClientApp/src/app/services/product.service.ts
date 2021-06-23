import {
  Injectable
} from '@angular/core';

import { Product } from '../model/Product.Model';
import {  HttpClient, HttpHeaders } from '@angular/common/http';
import {  Observable } from 'rxjs';

export class ProductService {
  apiUrl: string = "http://localhost:49850/Api/User/";
  constructor(private http: HttpClient) { }
  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.apiUrl);
  }
}
