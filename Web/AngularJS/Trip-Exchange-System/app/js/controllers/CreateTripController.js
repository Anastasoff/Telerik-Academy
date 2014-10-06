'use strict';

app.controller('CreateTripController', function ($scope, $location, createTrip, notifier) {
    $scope.createTrip = createTripFunc;

    function createTripFunc(trip) {
        createTrip.createTrip(trip).then(function (data) {
            notifier.success('Trip created successfully!');
            //TODO: user must be a driver to create a trip

            $location.path('/trips');
        })
    }

});