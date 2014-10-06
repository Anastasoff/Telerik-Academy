'use strict';

app.controller('RegisterController', function ($scope) {
    $scope.carFieldShow = false;
    $scope.isDriver = $scope.carFieldShow;
    $scope.carFieldShowText = 'I am a driver';
    $scope.showAndHideCarField = showAndHideCarField;

    function showAndHideCarField() {
        if ($scope.carFieldShow == false) {
            $scope.carFieldShowText = 'I am not a driver';
            $scope.carFieldShow = true;
        } else {
            $scope.carFieldShowText = 'I am a driver';
            $scope.carFieldShow = false;
        }

        $scope.isDriver = $scope.carFieldShow;
    }
});