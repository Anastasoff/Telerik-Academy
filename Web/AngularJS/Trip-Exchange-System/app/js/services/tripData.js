'use strict';

app.factory('tripData', function ($http, $q, authorization, baseServiceUrl) {
    var tripApi = baseServiceUrl + 'api/trips';


    return {
        getTop10Trips: function () {
            var deferred = $q.defer();

            $http.get(tripApi)
                .success(function (data) {
                    deferred.resolve(data);
                })
                .error(function (err) {
                    deferred.reject(err);
                });

            return deferred.promise;
        },
        getTrips: function () {
            var deferred = $q.defer();
            var header = authorization.getAuthorizationHeader();
            $http.get(tripApi, {headers: header})
                .success(function (data, status, headers, config) {
                    deferred.resolve(data);
                })
                .error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        },
        getTripDetail: function (id) {
            var deferred = $q.defer();
            var header = authorization.getAuthorizationHeader();
            $http.get(tripApi + '/' + id, {headers: header})
                .success(function (data, status, headers, config) {
                    deferred.resolve(data);
                })
                .error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        },
        joinTrip: function (id) {
            var deferred = $q.defer();
            var header = authorization.getAuthorizationHeader();
            $http.put(tripApi + '/' + id, {headers: header})
                .success(function (data, status, headers, config) {
                    deferred.resolve(data);
                })
                .error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }
    };
});