(function(){
"use strict";
    angular.module("CvoDemo.controllers")
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/home', {
                title: 'Home',
                templateUrl: 'app/views/home/list.html',
                controller: 'HomeController'
            })
            .when('/team4talent', {
                title: 'Team4Talent',
                templateUrl: 'app/views/team4talent.html',
                controller: 'Team4TalentController'
            })
            .when('/contact', {
                title: 'Contact',
                template: '<div class="container"><h1>{{title}}</h1>@todo</div>'
            })
            .otherwise({
                redirectTo: '/home'
            });
    }])
    .constant("config", {
        //Just in case...
    })
    .run(['$location', '$rootScope', function($location, $rootScope, $scope) {
        $rootScope.$on('$routeChangeSuccess', function (event, current, previous) {
            $rootScope.title = current.$$route ? current.$$route.title : '';
        });
    }]);
}());