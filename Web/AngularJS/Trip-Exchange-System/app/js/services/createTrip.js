'use strict';

app.factory('createTrip', function ($http, $q, authorization, baseServiceUrl) {
    var tripUrl = baseServiceUrl + 'api/trips/create';

    return {
        createTrip: function (trip) {
            var deferred = $q.defer();

            var header = authorization.getAuthorizationHeader();
            var body = {
                from: trip.from,
                to: trip.to,
                availableSeats: trip.availableSeats,
                departureTime: trip.departureTime
            };

            $http.post(tripUrl, body, { headers: header})
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
