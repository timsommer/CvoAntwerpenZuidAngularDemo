(function(){
"use strict";
	/* 
	Get started!
	https://angularjs.org/		
	http://angular-ui.github.io/bootstrap/
	*/
	
    angular.module("CvoDemo", [
        "CvoDemo.controllers", "CvoDemo.services", "CvoDemo.directives", "ngMessages"
    ]);
    angular.module("CvoDemo.controllers", ["ngRoute", "ui.bootstrap"]);
    angular.module("CvoDemo.services", []);
    angular.module("CvoDemo.filter", []);
	angular.module("CvoDemo.directives", ["jb.directives"]);
}());