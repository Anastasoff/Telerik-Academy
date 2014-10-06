'use strict';

app.controller('HomeController', function HomeController($scope, tripData, driverData) {
    tripData.getTop10Trips()
        .then(function (data) {
            $scope.latestTrips = data;
        });

    driverData.getLatest10Reg()
        .then(function (data) {
            $scope.lastRegDrivers = data;
        })
});