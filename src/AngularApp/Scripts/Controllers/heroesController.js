(function () {
    'use strict';

    angular
        .module('angularApp')
        .controller('heroesController', heroesController);

    heroesController.$inject = ['$scope', 'Heroes'];

    function heroesController($scope, Heroes) {
        $scope.Heroes = Heroes.query();
    }
})();