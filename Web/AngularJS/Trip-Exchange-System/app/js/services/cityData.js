'use strict';

app.factory('cityData', function ($http, $q, baseServiceUrl) {
    var cityApi = baseServiceUrl + 'api/cities';

    return {
        getAllCities: function () {
            var deferred = $q.defer();

            $http.get(cityApi)
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