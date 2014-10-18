(function () {
    "use strict";
    angular.module("CvoDemo.controllers")
        .controller("HomeController", [
            "$q", "$log", "$scope", "$modal",  "$window", "CustomerService", function($q, $log, $scope, $modal, $window, CustomerService) {

                //Fields
                $scope.Headers = [
                    { Title: "Id", Value: "id" },
                    { Title: "First Name", Value: "firstname" },
                    { Title: "Last Name", Value: "lastname" },
                    { Title: "E-mail", Value: "email" }
                ];

                $scope.FilterCriteria = {
                    PageSize: 10,
                    Page: 1,
                    orderBy: 'firstName',
                };


                $scope.FetchResult = function () {
                    $scope.data = CustomerService.get($scope.FilterCriteria, function (message) {
                        $scope.TotalItems = message.customers.length;
                    });
                };
                

                $scope.edit = function(customer) {
                    var modalInstance = $modal.open({
                        templateUrl: 'app/views/home/_customer.html',
                        controller: 'CustomerController',
                        resolve: {
                            customerCopy: function() {
                                return angular.copy(customer);
                            }
                        }
                    });
                    modalInstance.result.then(function() {
                        $scope.FetchResult();
                    }, function() {
                        $log.info('Modal dismissed at: ' + new Date());
                    });
                };

                $scope.create = function() {
                    var modalInstance = $modal.open({
                        templateUrl: 'app/views/home/_customer.html',
                        controller: 'CustomerController',
                        resolve: {
                            customerCopy: {}
                        }
                    });
                    modalInstance.result.then(function () {
                        $scope.FetchResult();
                    }, function() {
                        $log.info('Modal dismissed at: ' + new Date());
                    });
                };

                $scope.delete = function (customer) {
                    if ($window.confirm("Are you sure?")) {
                        $scope.data.$delete({ id: customer.id }, function () {
                            $scope.FetchResult();
                        }), function (response) {
                            //errorAlert('#alert-area', response.data.message);µ
                            alert("error !");
                        };
                    }
                };

                $scope.FetchResult();
            }
        ]);
})();