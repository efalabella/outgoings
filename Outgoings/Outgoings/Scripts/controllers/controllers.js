/**
 * Base Controller
 **/ 

define(['angular', 'controllers/outgoings'],

 	function (angular, outgoings) {
 		
 		var controllers = angular.module('controllers', ['services']);

 		controllers.controller('outgoings', outgoings);
 		
 		return controllers;
 	}
);