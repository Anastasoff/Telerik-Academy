'use strict';

app.factory('driverData', function ($http, $q, authorization, baseServiceUrl) {
    var driversApi = baseServiceUrl + 'api/drivers';


    return {
        getLatest10Reg: function () {
            var deferred = $q.defer();

            $http.get(driversApi)
                .success(function (data) {
                    deferred.resolve(data);
                })
                .error(function (err) {
                    deferred.reject(err);
                });

            return deferred.promise;
        },
        getDrivers: function () {
            var deferred = $q.defer();
            var header = authorization.getAuthorizationHeader();
            $http.get(driversApi, {headers: header})
                .success(function (data, status, headers, config) {
                    deferred.resolve(data);
                })
                .error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        },
        getDriverDetail: function (id) {
            var deferred = $q.defer();
            var header = authorization.getAuthorizationHeader();
            $http.get(driversApi + '/' + id, {headers: header})
                .success(function (data, status, headers, config) {
                    deferred.resolve(data);
                })
                .error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }
    }
});