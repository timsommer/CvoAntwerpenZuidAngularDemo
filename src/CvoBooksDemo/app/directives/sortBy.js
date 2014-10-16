(function () {
    "use strict";
    angular.module("jb.directives", ["jb.directives.sortby", "jb.templates"]);

    angular.module("jb.directives.sortby", [])
    .directive('sortBy', function () {
        return {
            templateUrl: 'template/sortby.html',
            restrict: 'E',
            transclude: true,
            replace: true,
            scope: {
                reverse: '=',
                order: '=',
                value: '@'
            },
            controller: function ($scope) {
                $scope.reverse = $scope.reverse || false;
                $scope.sort = function () {
                    if ($scope.order != $scope.value) {
                        $scope.order = $scope.value;
                    } else {
                        $scope.reverse = !$scope.reverse;
                    }
                }
            }
        };
    });

    angular.module("jb.templates", []).run(["$templateCache", function ($templateCache) {
        $templateCache.put("template/sortby.html",
          "<a ng-click=\"sort()\">" +
          "      <span ng-transclude></span>" +
          "      <span ng-show=\"order == value\">" +
          "          <i ng-class=\"{true: 'glyphicon glyphicon-arrow-down', false: 'glyphicon glyphicon-arrow-up'}[reverse]\"></i>" +
          "      </span>" +
          "</a>");
    }]);
}());