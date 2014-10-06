'use strict';

app.controller('TripsController', function ($scope, tripData) {
    tripData.getTop10Trips()
        .then(function (data) {
            $scope.trips = data;
        });
});