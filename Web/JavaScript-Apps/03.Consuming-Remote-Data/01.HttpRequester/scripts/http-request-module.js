define(['jquery'], function ($) {
    'use strict';
    var httpRequest;

    httpRequest = (function () {
        var getHttpRequest,
            makeRequest,
            getJSON,
            postJSON;

        getHttpRequest = (function () {
            var xmlHttpFactories;

            xmlHttpFactories = [
                function () {
                    return new XMLHttpRequest();
                },
                function () {
                    return new ActiveXObject("Msxml3.XMLHTTP");
                },
                function () {
                    return new ActiveXObject("Msxml2.XMLHTTP.6.0");
                },
                function () {
                    return new ActiveXObject("Msxml2.XMLHTTP.3.0");
                },
                function () {
                    return new ActiveXObject("Msxml2.XMLHTTP");
                },
                function () {
                    return new ActiveXObject("Microsoft.XMLHTTP");
                }
            ];

            return function () {
                var xmlFactory,
                    i,
                    len;

                for (i = 0, len = xmlHttpFactories.length; i < len; i++) {
                    xmlFactory = xmlHttpFactories[i];
                    try {
                        return xmlFactory();
                    } catch (_error) {

                    }
                }

                return null;
            };
        }());

        makeRequest = function (options) {
            var httpRequest,
                requestUrl,
                type,
                contentType,
                accept,
                data,
                deferred;

            deferred = $.Deferred(); // TODO: implement it with Q version 1.0.1

            httpRequest = getHttpRequest();

            options = options || {};
            requestUrl = options.url;
            type = options.type || 'GET';
            contentType = options.contentType || '';
            accept = options.accept || '';
            data = options.data || null;

            httpRequest.onreadystatechange = function () {
                if (httpRequest.readyState === 4) {
                    switch (Math.floor(httpRequest.status / 100)) {
                        case 2:
                            deferred.resolve(httpRequest.responseText);
                            break;
                        default:
                            deferred.reject(httpRequest.responseText);
                            break;
                    }
                }
            };
            httpRequest.open(type, requestUrl, true);
            httpRequest.setRequestHeader('Content-Type', contentType);
            httpRequest.setRequestHeader('Accept', accept);
            httpRequest.send(data);

            return deferred.promise();
        };

        getJSON = function (url, headers) {
            var options = {
                url: url,
                type: 'GET',
                contentType: headers.contentType,
                accept: headers.accept
            };

            return makeRequest(options);
        };

        postJSON = function (url, data, headers) {
            var options = {
                url: url,
                type: 'POST',
                contentType: headers.contentType,
                accept: headers.accept,
                data: JSON.stringify(data)
            };

            return makeRequest(options);
        };

        return {
            getJSON: getJSON,
            postJSON: postJSON
        }
    }());

    return httpRequest;
});