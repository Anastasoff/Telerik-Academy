'use strict';

app.controller('MyCtrl2', ['$scope', 'notifier', function MyCtrl2($scope, notifier) {
    notifier.success('Success Partial 2!');
    notifier.error('Error Partial 2.')
}]);