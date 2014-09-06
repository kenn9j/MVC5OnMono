'use strict';

/**
 * @ngdoc function
 * @name testMvcmono2App.controller:MainCtrl
 * @description
 * # MainCtrl
 * Controller of the testMvcmono2App
 */
angular.module('testMvcmono2App')
  .controller('MainCtrl', function ($scope) {
    $scope.awesomeThings = [
      'HTML5 Boilerplate',
      'AngularJS',
      'Karma'
    ];
  });
