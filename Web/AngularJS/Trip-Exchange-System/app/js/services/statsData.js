'use strict';

app.factory('statsData', function ($http, $q, baseServiceUrl) {
    var statsApi = baseServiceUrl + 'api/stats';

    return {
        getAllCities: function () {
            var deferred = $q.defer();

            $http.get(statsApi)
                .success(function (data) {
                    deferred.resolve(data);
                })
                .error(function (err) {
                    deferred.reject(err)
                });

            return deferred.promise;
        }
    }
});