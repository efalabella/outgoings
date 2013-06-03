/**
 * outgoingsData.js
 **/

define(function () {

    'use strict';

    var service = function ($resource) {

        return $resource('/Home/getOutgoingsByUserId', {}, {
            getOutgoingsByUserId: { method: 'GET' }
        });

    };

    service.$inject = ['$resource'];

    return service;
});
