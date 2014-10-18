(function () {
    "use strict";
    angular.module("CvoDemo.controllers")
        .controller("HomeController", [
            "$q", "$log", "$scope", "$modal",  "$window", "CustomerService", function($q, $log, $scope, $modal, $window, CustomerService) {

                //Fields
                $scope.Headers = [
                    { Title: "Id", Value: "id" },
                    { Title: "First Name", Value: "firstName" },
                    { Title: "Last Name", Value: "lastName" },
                    { Title: "E-mail", Value: "emailAdress" },
                    { Title: "Phone Number", Value: "phoneNumber" }
                ];

                $scope.FilterCriteria = {
                    PageSize: 10,
                    Page: 1,
                    orderBy: 'firstName',
                };

            $scope.sliceIndex = 5;

                $scope.FetchResult = function () {
                    CustomerService.get($scope.FilterCriteria, function (message) {
                        $scope.data = message;
                        $scope.data.customers = message.customers.slice(0, $scope.sliceIndex);
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

                $scope.loadMore = function () {
                    $scope.sliceIndex += 5;
                    $scope.$broadcast("CvoDemo:HomeController:autoload");
                }

                $scope.$on('CvoDemo:HomeController:autoload', function (event, mass) {
                    $scope.FetchResult();
                });

                $scope.FetchResult();
            }
        ]);
})();