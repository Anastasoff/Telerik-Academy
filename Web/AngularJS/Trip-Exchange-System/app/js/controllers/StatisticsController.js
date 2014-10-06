'use strict';

app.controller('StatisticsController', function ($scope, statsData) {
    statsData.getAllCities()
        .then(function (data) {
            $scope.stats = data;
        })
});