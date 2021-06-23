"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.ProductComponent = void 0;
var ProductComponent = /** @class */ (function () {
    function ProductComponent(productService, router) {
        this.productService = productService;
        this.router = router;
        this.columnDefs = [
            { headerName: 'Name', field: 'Name', sortable: true, },
            { headerName: 'Price', field: 'Price', sortable: true, },
            { headerName: 'Type', field: 'Type', sortable: true, },
            { headerName: 'Active', field: 'Active', sortable: true, },
        ];
    }
    ProductComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.productService.getProducts().subscribe(function (data) {
            _this.products = data;
        });
    };
    ProductComponent.prototype.onGridReady = function (params) {
        this.api = params.api;
        this.columnApi = params.columnApi;
        this.api.sizeColumnsToFit();
    };
    ProductComponent.prototype.Add = function () {
        this.router.navigate(['addProduct']);
    };
    return ProductComponent;
}());
exports.ProductComponent = ProductComponent;
//# sourceMappingURL=product.component.js.map