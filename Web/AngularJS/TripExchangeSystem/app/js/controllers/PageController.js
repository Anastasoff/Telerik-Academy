'use strict';

tripExchange.controller('PageController',
    function PageController($scope, author, githubUrl) {
        $scope.author = author;
        $scope.githubUrl = githubUrl;
        $scope.year = new Date().getFullYear();
    }
);