/**
 * directives.js
 **/

define(['angular', 'directives/outgoings'],

 	function (angular, outgoings) {
 		
 	    var directives = angular.module('directives', []);

 	    directives.directive('outgoings', outgoings);

 	    return directives;
});