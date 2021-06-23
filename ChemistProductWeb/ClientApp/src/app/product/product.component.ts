import { Component, OnInit } from '@angular/core';
import { Product } from '../model/Product.Model';
import { ProductService } from '../services/Product.Service';
import { Router } from '@angular/router';
import {  ColDef,  GridApi,  ColumnApi } from 'ag-grid-community';

export class ProductComponent implements OnInit {

  public products: Product[];
  private api: GridApi;
  private columnApi: ColumnApi;

  columnDefs = [
    { headerName: 'Name', field: 'Name', sortable: true, },
    { headerName: 'Price', field: 'Price', sortable: true, },
    { headerName: 'Type', field: 'Type', sortable: true, },
    { headerName: 'Active', field: 'Active', sortable: true, },
  ];

  constructor(private productService: ProductService, private router: Router) {
    
  }

  ngOnInit() {
    this.productService.getProducts().subscribe(data => {
      this.products = data
    });
  }
  onGridReady(params): void {
    this.api = params.api;
    this.columnApi = params.columnApi;
    this.api.sizeColumnsToFit();
  }
  Add() {
    this.router.navigate(['addProduct']);
  }
}
