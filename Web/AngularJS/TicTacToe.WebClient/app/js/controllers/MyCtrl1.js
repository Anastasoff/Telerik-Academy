'use strict';

app.controller('MyCtrl1', ['$scope', 'notifier', function MyCtrl1($scope, notifier) {
    notifier.success('Success Partial 1!');
    notifier.error('Error Partial 1.');
}]);