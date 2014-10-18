(function() {
    "use strict";
    
    angular.module("CvoDemo.services")
        .factory('CustomerService', ['$resource', function ($resource) {
            return $resource('http://localhost:50872/api/customers/', {}, {});
        }]);


    //.factory('CustomerService', ['$q', function ($q) {
    //    return {
    //        Get: function (query) {

    //            var deferred = $q.defer();

    //            /*
    //            return $http.get('http://localhost/api/customers', { params: query }).then(function (result) {
    //                return result.data;
    //            });
    //            */

    //            var customers = [
    //                { "id": 1, "firstname": "Marie", "lastname": "Lewis", "email": "mlewis0@diigo.com" },
    //                { "id": 2, "firstname": "Charles", "lastname": "Mason", "email": "cmason1@pbs.org"},
    //                { "id": 3, "firstname": "Emily", "lastname": "Gibson", "email": "egibson2@over-blog.com" },
    //                { "id": 4, "firstname": "Craig", "lastname": "Berry", "email": "cberry3@seattletimes.com" },
    //                { "id": 5, "firstname": "Ruth", "lastname": "Hall", "email": "rhall4@flavors.me"},
    //                { "id": 6, "firstname": "Amy", "lastname": "Turner", "email": "aturner5@cisco.com"},
    //                { "id": 7, "firstname": "Justin", "lastname": "Rivera", "email": "jrivera6@tripadvisor.com"},
    //                { "id": 8, "firstname": "Laura", "lastname": "Rogers", "email": "lrogers7@github.com"  },
    //                { "id": 9, "firstname": "Jos", "lastname": "Wagenmakers", "email": "wagenmakers@gmail.com" },
    //                { "id": 10, "firstname": "Gert", "lastname": "de Vos", "email": "gert@hotmail.com" }
    //            ];

    //            var begin = ((query.Page - 1) * query.PageSize),
    //                end = begin + query.PageSize;

    //            deferred.resolve({ Records: customers.slice(begin,end), TotalItems : customers.length });

    //            return deferred.promise;
    //        },
    //        Save: function(model) {
    //            //Service call :-)
    //            var deferred = $q.defer();
    //            deferred.resolve({ msg: 'whoop' });
    //            return deferred.promise;
    //        }
        //};
    //}]);
}());