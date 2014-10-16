(function () {
    "use strict";
    angular.module("CvoDemo")
      .config(function ($provide) {
          $provide.decorator('$exceptionHandler', ['$log', '$delegate',
            function ($log, $delegate) {
                return function (exception, cause) {
                    $log.debug('Exception:' + cause);
                    $delegate(exception, cause);
                };
            }
          ]);
      });
}());