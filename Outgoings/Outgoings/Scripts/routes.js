/**
 *  route.js
 **/
define(['app', 'controllers/outgoings'],
    function (app, outgoingsCtl) {

        return app.config(['$routeProvider',

            function ($routeProvider) {

                $routeProvider.
                    when('/account', { template: '<h3>Account</h3>' }).
                    when('/outgoings-list', { template: '<h3>Outgoings List</h3>' }).
                    when('/new-outgoing', { template: '<h3>New Outgoing</h3>' }).

                    when('/', { // Home
                        templateUrl: 'Partials/views/home/container.html',
                        controller: outgoingsCtl
                    }).
                    otherwise({ redirectTo: '/' });
            }
        ]);
    });