/**
 * main.js
 * Require.js configuration and initialization.
 **/

// require.js configuration
require.config({
    baseUrl: '/Scripts/',
    paths: {
        'jquery': 'lib/jQuery/jquery-1.9.1.min',
        'angular': 'lib/angular/1.0.6/angular',
        'resource': 'lib/angular/1.0.6/angular-resource'
    },
    shim: {
        'jquery': { 'exports': '$' },
        'angular': { 'deps': ['jquery'], 'exports': 'angular' },
        'resource': { 'deps': ['angular'], 'exports': 'resource' }
    }
});



require(['angular', 'app', 'routes', 'services/services', 'directives/directives', 'providers/providers',
        'filters/filters', 'controllers/controllers'],

    function (angular, app) {

        // Bootstraps the application
        angular.element(document).ready(function () {
            angular.bootstrap(document, ['myApp']);
        });
    }
);
