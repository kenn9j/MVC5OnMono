'use strict';

/**
 * @ngdoc function
 * @name testMvcmono2App.controller:AboutCtrl
 * @description
 * # AboutCtrl
 * Controller of the testMvcmono2App
 */
angular.module('testMvcmono2App')
  .controller('AboutCtrl', function ($scope) {
    $scope.awesomeThings = [
      'HTML5 Boilerplate',
      'AngularJS',
      'Karma'
    ];
  });
