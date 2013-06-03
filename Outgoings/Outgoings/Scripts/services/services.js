/**
 * BaseService
 **/
 
define(['angular', 'services/outgoingsData', 'resource'],

    function (angular, outgoingsData) {
 		
		var services = angular.module('services', ['ngResource']);

		services.factory('outgoingsData', outgoingsData);

 		return services;
 	}
 );