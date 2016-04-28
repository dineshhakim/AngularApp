(function () {
    'use strict';
    config.$inject = ['$routeProvider', '$locationProvider'];

    angular.module('angularApp', [
        'ngRoute', 'heroesService'
    ]).config(config);
    function config($routeProvider, $locationProvider) {
        $routeProvider
            .when('/hero', {
                templateUrl: '/hero.html',
                controller: 'heroesController'
            });


        $locationProvider.html5Mode(true);
    }

})();