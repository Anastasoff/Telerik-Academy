'use strict';

var app = angular.module('myApp', ['ngRoute', 'ngResource', 'ngCookies']).
    config(['$routeProvider', function ($routeProvider) {

        $routeProvider
            .when('/', {
                templateUrl: 'views/partials/home.html',
                controller: 'HomeController'
            })
            .when('/register', {
                templateUrl: 'views/partials/register.html',
                controller: 'SignUpCtrl'
            })
            .when('/trips', {
                templateUrl: 'views/partials/trips.html',
                controller: 'TripsController'
            })
            .when('/drivers', {
                templateUrl: 'views/partials/drivers.html',
                controller: 'DriversController'
            })
            .when('/create-trip', {
                templateUrl: 'views/partials/create-trip.html',
                controller: 'CreateTripController'
            })
            .when('/statistics', {
                templateUrl: 'views/partials/statistics.html',
                controller: 'StatisticsController'
            })
            .otherwise({ redirectTo: '/' });
    }])
    .value('toastr', toastr)
    //.constant('baseServiceUrl', 'http://localhost:1337/');
    .constant('baseServiceUrl', 'http://spa2014.bgcoder.com/');

app.run(function ($rootScope, $location) {
    $rootScope.$on('$routeChangeError', function (ev, current, previous, rejection) {
        if (rejection === 'not authorized') {
            $location.path('/unauthorized');
        }
    })
});