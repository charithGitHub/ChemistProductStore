"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.ProductService = void 0;
var ProductService = /** @class */ (function () {
    function ProductService(http) {
        this.http = http;
        this.apiUrl = "http://localhost:49850/Api/User/";
    }
    ProductService.prototype.getProducts = function () {
        return this.http.get(this.apiUrl);
    };
    return ProductService;
}());
exports.ProductService = ProductService;
//# sourceMappingURL=product.service.js.map