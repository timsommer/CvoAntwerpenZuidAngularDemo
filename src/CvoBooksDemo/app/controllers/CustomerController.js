(function () {
    "use strict";
    angular.module("CvoDemo.controllers")
		.controller("CustomerController", ["$scope", "$modalInstance", "CustomerService", "customerCopy", function ($scope, $modalInstance, CustomerService, customerCopy) {
		    
		    $scope.customerCopy = customerCopy;

		    $scope.ok = function () {
		        CustomerService.Save($scope.customerCopy).then(function (data) {
		            alert('tst');
		            $modalInstance.close();
		        }, function() {
		            // issue
		        });
		    };

		    $scope.cancel = function () {
		        $modalInstance.dismiss('cancel');
		    };
		}]);
})();