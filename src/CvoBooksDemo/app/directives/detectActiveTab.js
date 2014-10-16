(function(){
"use strict";
    angular.module("CvoDemo.directives")
	.directive('detectActiveTab', ['$location', function ($location) {
    return {
      link: function postLink(scope, element, attrs) {      	
          scope.$on("$routeChangeSuccess", function (event, current, previous) {
            //get child href element
            var aElement = element[0].querySelector('a');
            //remove location base path
            var href = aElement.href.replace($location.$$protocol + "://" + $location.$$host + ":" + $location.$$port + "/#", "");

            //detect if using different levens on page and eventually apply
			var pathLevel = attrs.detectActiveTab || 1,
                pathToCheck = $location.path().split('/')[pathLevel] || false,
                tabLink = href.split('/')[pathLevel] || href;
	        // now compare the two:
	        if (pathToCheck === tabLink) {
	          element.addClass("active");
	        } else {
	          element.removeClass("active");
	        }
        });
      }
    };
  }]);
}());