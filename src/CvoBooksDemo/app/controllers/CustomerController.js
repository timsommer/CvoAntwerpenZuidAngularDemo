(function () {
    "use strict";
    angular.module("CvoDemo.controllers")
		.controller("CustomerController", ["$scope", "$modalInstance", "CustomerService", "customerCopy", function ($scope, $modalInstance, CustomerService, customerCopy) {

		    var id = 0;

		    function getCustomer() {
		        if (customerCopy !== undefined) {
		            id = customerCopy.id;
		        }

		        CustomerService.get({ id: id }, function (message) {
		            $scope.data = message;
		        });
		    }

		    getCustomer();


		    $scope.ok = function() {
		        
		        $scope.data.$save(function () {
		            $modalInstance.close();
		        }, function (response) {
		            alert("error !");
		        });

		    };

		    $scope.cancel = function () {
		        $modalInstance.dismiss('cancel');
		    };
		}]);
})();