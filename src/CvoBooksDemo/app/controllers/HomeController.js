(function () {
    "use strict";
    angular.module("CvoDemo.controllers")
        .controller("HomeController", [
            "$q", "$log", "$scope", "$modal", "CustomerService", function($q, $log, $scope, $modal, CustomerService) {

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
                    orderBy: 'firstname',
                };

                $scope.FetchResult = function () {
                    return CustomerService.Get($scope.FilterCriteria).then(function(data) {
                        $scope.Customers = data.Records;
                        $scope.TotalItems = data.TotalItems;
                    }, function() {
                        $scope.Customers = [];
                        $scope.TotalItems = 0;
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
                            customerCopy: function() {
                                return {};
                            }
                        }
                    });
                    modalInstance.result.then(function () {
                        $scope.FetchResult();
                    }, function() {
                        $log.info('Modal dismissed at: ' + new Date());
                    });
                };

                $scope.FetchResult();
            }
        ]);
})();