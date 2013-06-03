/**
 * outgoings.js
 * 
 **/

define(['controllers/outgoings'], function (OutgoingsController) {

    'use strict';

    function outgoings() {
        return {
            restrict: 'E',
            templateUrl: '/Partials/views/outgoings.html',
            replace: true,
            controller: OutgoingsController
        };
    }

    return outgoings;
});