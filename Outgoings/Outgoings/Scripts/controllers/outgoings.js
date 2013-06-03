/**
 * outgoings.js
 *
  **/

define(function () {

    'use strict';

    function OutgoingsController($scope, outgoingsData) {
        outgoingsData.getOutgoingsByUserId(function (data) {
            $scope.model = data.Title;
        });
    }


    OutgoingsController.$inject = ['$scope', 'outgoingsData'];

    return OutgoingsController;
});