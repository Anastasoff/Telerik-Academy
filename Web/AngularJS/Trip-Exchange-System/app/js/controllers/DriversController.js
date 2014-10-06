'use strict';

app.controller('DriversController', function ($scope, driverData) {
    driverData.getLatest10Reg()
        .then(function (data) {
            $scope.drivers = data;
        });
});