(function () {
    "use strict";
    angular.module("CvoDemo.controllers")
		.controller("CustomerController", ["$scope", "$modalInstance", "CustomerService", "customerCopy", function ($scope, $modalInstance, CustomerService, customerCopy) {

		    function getCustomer() {
		        var id = 0;

		        if (customerCopy !== undefined) {
		            id = customerCopy.id;
		        }

		        $scope.data = CustomerService.get({ id: id }, function (message) {
		            $scope.data = message;
		        });
		    }

		    getCustomer();


		    $scope.ok = function() {

		        $scope.data.$save(function () {
		            $modalInstance.close();
		        }, function (response) {
		            //errorAlert('#alert-area', response.data.message);µ
		            alert("error !");
		        });

		        //CustomerService.save($scope.customerCopy).then(function (data) {


		        //    $modalInstance.close();
		    };

		    $scope.cancel = function () {
		        $modalInstance.dismiss('cancel');
		    };
		}]);
})();