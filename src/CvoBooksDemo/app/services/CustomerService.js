(function() {
    "use strict";
    
    angular.module("CvoDemo.services")
        .factory('CustomerService', ['$resource', function ($resource) {
            return $resource('http://localhost:50872/api/customers/', {}, {});
        }]);
}());